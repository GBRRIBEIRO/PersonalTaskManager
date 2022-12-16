using PTM.Domain.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTM.Domain.Models.Users
{
    public class UserEntity
    {
        private string Password { get; set; }
        private string UserName { get;  set; } 
        public string Name { get; set; }
        public List<Work> Tasks { get; set; }

        public UserEntity(string password, string userName, string name)
        {
            Password = password;
            UserName = userName;
            Name = name;
        }

        public void AddTask(Work task) 
        {
            Tasks.Add(task);
        }

    }
}
