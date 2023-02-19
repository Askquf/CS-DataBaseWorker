using System;
using DatabaseContext;
using DatabaseModels;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public class DataBaseCore
    {
        DataBaseContext _dataBase;
        StudentEntity _student;
        CuratorEntity _curator;
        GroupEntity _group;

        public DataBaseCore()
        {
            _dataBase = new DataBaseContext();
            _student = new StudentEntity(_dataBase);
            _curator = new CuratorEntity(_dataBase);
            _group = new GroupEntity(_dataBase);
        }

        public List<string> GetGroupNames()
        {
            return _group.GroupNamesGet();
        }

        public void AddStudentWithGroupId(string name, int groupId, string age)
        {
            _student.AddStudentWithGroupId(name, groupId, age);
        }

        public void AddStudentWithGroupName(string name, string groupName, string email)
        {
            _student.AddStudentWithGroupName(name, groupName, email);
        }

        public void AddCuratorWithGroupId(string name, int groupId, string email)
        {
            _curator.AddCuratorWithGroupId(name, groupId, email);
        }

        public void AddCuratorWithGroupName(string name, string groupName, string age)
        {
            int groupId = _group.FindGroupWithName(groupName);
            AddCuratorWithGroupId(name, groupId, age);
        }

        public void AddGroup(string name, DateTime time)
        {
            _group.AddGroup(name, time);
        }

        public BindingList<Group> TakeAllGroups()
        {
            return _group.TakeAllGroups();
        }

        public BindingList<Student> TakeAllStudents()
        {
            return _student.TakeAllStudents();
        }

        public BindingList<Curator> TakeAllCurators()
        {
            return _curator.TakeAllCurators();
        }

        public void UpdateGroupName (string newName, string tmpId)
        {
            _group.UpdateGroupName(newName, tmpId);
        }

        public void UpdateGroupTime(DateTime time, string tmpId)
        {
            _group.UpdateGroupTime(time, tmpId);
        }

        public void UpdateStudentName(string newName, string tmpId)
        {
            _student.UppdateStudentName(newName, tmpId);
        }

        public void UpdateStudentAge(string newAge, string tmpId)
        {
            _student.UppdateStudentAge(newAge, tmpId);
        }

        public void UpdateStudentGroupWithId(int newGroupId, string tmpId)
        {
            _student.UppdateStudentGroupWithId(newGroupId, tmpId);
        }

        public void UpdateStudentGroupWithName(string groupName, string tmpId)
        {
            int groupId = _group.FindGroupWithName(groupName);
            UpdateStudentGroupWithId(groupId, tmpId);
        }

        public void UpdateCuratorName(string newName, string tmpId)
        {
            _curator.UpdateCuratorName(newName, tmpId);
        }

        public void UpdateCuratorEmail(string email, string tmpId)
        {
            _curator.UpdateCuratorEmail(email, tmpId);
        }

        public void UpdateCuratorGroupWithId(int newGroupId, string tmpId)
        {
            _curator.UppdateCuratorGroupWithId(newGroupId, tmpId);
        }

        public void UpdateCuratorGroupWithName(string groupName, string tmpId)
        {
            int groupId = _group.FindGroupWithName(groupName);
            UpdateCuratorGroupWithId(groupId, tmpId);
        }

        public void DeleteGroup (string tmpId)
        {
            _group.DeleteGroup(tmpId);
        }

        public void DeleteStudent(string tmpId)
        {
            _student.DeleteStudent(tmpId);
        }

        public void DeleteCurator(string tmpId)
        {
            _curator.DeleteCurator(tmpId);
        }

        public int CountAll(int groupId)
        {
            return _student.CountAll(groupId);
        }

        public string FindCuratorsName(int groupId)
        {
            return _curator.FindCuratorsName(groupId);
        }

        public double CountAverageAge(int groupId)
        {
            return _student.CountAverageAge(groupId);
        }
    }
}
