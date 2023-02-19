using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Linq;
using DatabaseContext;
using DatabaseModels;

namespace Core
{
    class StudentEntity
    {
        DataBaseContext _dataBase;

        public StudentEntity(DataBaseContext dataBase)
        {
            _dataBase = dataBase;
        }

        public void AddStudentWithGroupId(string name, int groupId, string age)
        {
            int changeAge = Convert.ToInt32(age);
            _dataBase.AddStudent(name, groupId, changeAge);
        }

        public void AddStudentWithGroupName(string name, string groupName, string email)
        {
            int groupId = _dataBase.FindGroupWithName(groupName);
            AddStudentWithGroupId(name, groupId, email);
        }

        public BindingList<Student> TakeAllStudents()
        {
            _dataBase._students.Load();
            return _dataBase._students.Local.ToBindingList();
        }
        public void UppdateStudentName(string newName, string tmpId)
        {
            int changeId = Convert.ToInt32(tmpId);
            _dataBase.UppdateStudentName(newName, changeId);
        }

        public void UppdateStudentAge(string newAge, string tmpId)
        {
            int changeId = Convert.ToInt32(tmpId);
            int changeAge = Convert.ToInt32(newAge);
            _dataBase.UppdateStudentAge(changeAge, changeId);
        }
        public void UppdateStudentGroupWithId(int newGroupId, string tmpId)
        {
            int changeStudentId = Convert.ToInt32(tmpId);
            _dataBase.UppdateStudentGroup(newGroupId, changeStudentId);
        }

        public void DeleteStudent(string tmpId)
        {
            int changeId = Convert.ToInt32(tmpId);
            _dataBase.DeleteStudent(changeId);
        }

        public double CountAverageAge(int groupId)
        {
            double avg = 0;
            int counter = 0;
            var student = _dataBase._students.Where(u => u.GroupId == groupId).ToList();
            for (int i = 0; i < student.Count; i++)
            {
                avg += student[i].Age;
                counter++;
            }
            if (counter != 0)
                avg = avg / counter;
            return avg;
        }

        public int CountAll(int groupId)
        {
            var student = _dataBase._students.Where(u => u.GroupId == groupId).ToList();
            return student.Count;
        }


    }
}
