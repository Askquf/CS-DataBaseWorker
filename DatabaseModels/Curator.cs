using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseModels
{
    public class Curator
    {

        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string GroupName { get; set; }
        public Group Group { get; set; }

        public Curator(int groupId, string name, string email, string groupName, Group group)
        {
            GroupId = groupId;
            Name = name;
            Email = email;
            GroupName = groupName;
            Group = group;
        }

        public Curator()
        {

        }
    }
}
