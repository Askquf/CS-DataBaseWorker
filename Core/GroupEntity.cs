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
    class GroupEntity
    {
        DataBaseContext _dataBase;

        public GroupEntity(DataBaseContext dataBase)
        {
            _dataBase = dataBase;
        }

        public List<string> GroupNamesGet()
        {
            return _dataBase.GroupNamesGet();
        }

        public int FindGroupWithName(string name)
        {
            return _dataBase.FindGroupWithName(name);
        }

        public void AddGroup(string name, DateTime time)
        {
            _dataBase.AddGroup(name, time);
        }

        public BindingList<Group> TakeAllGroups()
        {
            _dataBase._groups.Load();
            return _dataBase._groups.Local.ToBindingList();
        }

        public void UpdateGroupName(string newName, string tmpId)
        {
            int changeId = Convert.ToInt32(tmpId);
            _dataBase.UppdateGroupName(newName, changeId);
        }

        public void UpdateGroupTime(DateTime time, string tmpId)
        {
            int changeId = Convert.ToInt32(tmpId);
            _dataBase.UppdateGroupTime(time, changeId);
        }

        public void DeleteGroup(string tmpId)
        {
            int changeId = Convert.ToInt32(tmpId);
            _dataBase.DeleteGroup(changeId);
        }
    }
}
