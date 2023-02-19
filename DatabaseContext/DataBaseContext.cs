using System;
using Microsoft.EntityFrameworkCore;
using DatabaseModels;
using System.Threading;
using System.Linq;
using System.ComponentModel;
using System.Collections.Generic;

namespace DatabaseContext
{
    public class DataBaseContext : DbContext
    {
        const string _sqlServer = "Host=localhost;Port=5432;Database=FullDBThree;Username=postgres;Password=1234";
        public DbSet<Student> _students { get; set; }
        public DbSet<Curator> _curators { get; set; }
        public DbSet<Group> _groups { get; set; }


        public DataBaseContext()
         {
             Database.EnsureCreated();        
        }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             optionsBuilder.UseNpgsql(_sqlServer);
         }
        
        public void AddStudent(string name, int groupId, int age)
        {
            if (FindGroupWithId(groupId)) 
            { 
                _students.Add(new Student(age, groupId, name, _groups.Find(groupId), _groups.Find(groupId).Name));
            }
            else
            {
                throw new Exception();
            }
            SaveChanges();
        }

        public void AddCurator(string name, int groupId, string email)
        {
            if (FindGroupWithId(groupId))
            {
                _curators.Add(new Curator(groupId, name, email, _groups.Find(groupId).Name, _groups.Find(groupId)));
            }
            else
            {
                throw new Exception();
            }
            SaveChanges();
        }

        public bool FindGroupWithId(int id)
         {
            bool res = false;
            var group = _groups.Where(u => u.Id == id).ToList();
            if (group.Count != 0)
                res = true;
            return res;
         }


        public void UppdateGroupName(string name, int id)
        {
            _groups.Find(id).Name = name;
            var student = _students.Where(c => c.GroupId == id).ToList<Student>();
            for (int i = 0; i < student.Count; i++)
            {
                _students.Find(student[i].Id).GroupName = name;
            }
            var curator = _curators.Where(c => c.GroupId == id).ToList<Curator>();
            _curators.Find(curator[0].Id).GroupName = name;
            SaveChanges();
        }

        public void UppdateStudentGroup(int groupId, int studentId)
        { 
            _students.Find(studentId).Group = _groups.Find(groupId);
            _students.Find(studentId).GroupName = _groups.Find(groupId).Name;
            _students.Find(studentId).GroupId = groupId;
            SaveChanges();
        }

        public void UppdateCuratorGroup(int GroupId, int curatorId)
        {
            Curator tmp = _curators.Find(curatorId);
            tmp.Group = _groups.Find(GroupId);
            tmp.GroupName = _groups.Find(GroupId).Name;
            tmp.GroupId = GroupId;
            SaveChanges();
        }

        public void DeleteGroup(int Id)
        {
            var student = _students.Where(c => c.GroupId == Id).ToList<Student>();
            for (int i = 0; i < student.Count; i++)
                _students.Remove(student[i]);
            var curator = _curators.Where(c => c.GroupId == Id).ToList<Curator>();
            if (curator.Count != 0)
                _curators.Remove(curator[0]);
            _groups.Remove(_groups.Find(Id));
            SaveChanges();
        }


        public void AddGroup(string name, DateTime time)
        {
            _groups.Add(new Group(name, time));
            SaveChanges();
        }
        

        public void UppdateGroupTime(DateTime time, int Id)
        {
            _groups.Find(Id).CreationDate = time;
            SaveChanges();
        }

        public void UppdateStudentAge(int age, int id)
        {
            _students.Find(id).Age = age;
            SaveChanges();
        }

        public void UppdateStudentName(string name, int id)
        {
            _students.Find(id).Name = name;
            SaveChanges();
        }


        public void DeleteStudent(int Id)
        {
            _students.Remove(_students.Find(Id));
            SaveChanges();
        }

        public void DeleteCurator(int Id)
        {
            _curators.Remove(_curators.Find(Id));
            SaveChanges();
        }

        public int FindGroupWithName(string groupName)
        {
            var group = _groups.Where(u => u.Name == groupName).ToList<Group>();
            return group[0].Id;
        }

        public void UppdateCuratorEmail(string email, int id)
        {
            _curators.Find(id).Email = email;
            SaveChanges();
        }

        public void UppdateCuratorName(string name, int id)
        {
            _curators.Find(id).Name = name;
            SaveChanges();
        }

        public List<string> GroupNamesGet()
        {
            _groups.Load();
            List<string> result = new List<string>(_groups.Local.Count);
            foreach (Group group in _groups)
            {
                result.Add(group.Name);
            }
            return result;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(s => s.Id);
            modelBuilder.Entity<Student>().Property(s => s.Name).IsRequired();
            modelBuilder.Entity<Student>().Property(s => s.Age).IsRequired();
            modelBuilder.Entity<Student>().Property(s => s.GroupName).IsRequired();
            modelBuilder.Entity<Group>().HasKey(g => g.Id);
            modelBuilder.Entity<Group>().Property(g => g.Name).IsRequired();
            modelBuilder.Entity<Group>().Property(g => g.CreationDate).IsRequired();
            modelBuilder.Entity<Curator>().HasKey(c => c.Id);
            modelBuilder.Entity<Curator>().Property(s => s.Name).IsRequired();
            modelBuilder.Entity<Curator>().Property(s => s.Email).IsRequired();
            modelBuilder.Entity<Curator>().Property(s => s.GroupName).IsRequired();
            modelBuilder.Entity<Group>().HasMany<Student>().WithOne(u => u.Group).IsRequired(true).HasForeignKey(t => t.GroupId);
            modelBuilder.Entity<Group>().HasOne<Curator>().WithOne(u => u.Group).IsRequired(true);
            base.OnModelCreating(modelBuilder);
        }
    }
}