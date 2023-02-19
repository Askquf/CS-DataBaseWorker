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
    class CuratorEntity
    {
        DataBaseContext _dataBase;

        public CuratorEntity(DataBaseContext dataBase)
        {
            _dataBase = dataBase;
        }

        public void AddCuratorWithGroupId(string name, int groupId, string email)
        {
            _dataBase.AddCurator(name, groupId, email);
        }

        public BindingList<Curator> TakeAllCurators()
        {
            _dataBase._curators.Load();
            return _dataBase._curators.Local.ToBindingList();
        }

        public void UpdateCuratorName(string newName, string tmpId)
        {
            int changeId = Convert.ToInt32(tmpId);
            _dataBase.UppdateCuratorName(newName, changeId);
        }

        public void UpdateCuratorEmail(string email, string tmpId)
        {
            int changeId = Convert.ToInt32(tmpId);
            _dataBase.UppdateCuratorEmail(email, changeId);
        }

        public void UppdateCuratorGroupWithId(int newGroupId, string tmpId)
        {
            int changeStudentId = Convert.ToInt32(tmpId);
            _dataBase.UppdateCuratorGroup(newGroupId, changeStudentId);
        }

        public void DeleteCurator(string tmpId)
        {
            int changeId = Convert.ToInt32(tmpId);
            _dataBase.DeleteCurator(changeId);
        }

        public string FindCuratorsName(int groupId)
        {
            string name = "No curator!";
            var curator = _dataBase._curators.Where(u => u.GroupId == groupId).ToList();
            if (curator.Count > 0)
                name = curator[0].Name;
            return name;
        }

    }
}
