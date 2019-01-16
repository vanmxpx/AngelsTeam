using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AngelsTeam.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Telegram { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime ExpirationDate { get; set; }

        //Role
        public int RoleId { get; set; }
        public Role Role { get; set; }

        //Credential
        public Credential Credential { get; set; }

        //Subscription
        public List<Subscription> Subscriptions { get; set; }
    }
}