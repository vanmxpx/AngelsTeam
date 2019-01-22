using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AngelsTeam.Model
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Contact { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Photo { get; set; }
        public DateTime SubLeft { get; set; }

        public int UserType { get; set; }

        public Subscription Subscription { get; set; }
    }
}