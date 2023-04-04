using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Idea1.Models
{
    public class User
    {
        public User(ApplicationUser user)
        {
            UserId = user.Id;
            Name = user.UserName;


        }
        public string UserId { get; set; }
        public string Name { get; set; }
    }
}