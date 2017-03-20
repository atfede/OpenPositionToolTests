using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OpenPositionToolTests.Models
{
    public class User : DbContext
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; }
        public string UserDesiredType { get; set; }
        public string Password { get; set; }

        public User(string name, string email, string userType, string password)
        {
            //this.EmployeeId = EmployeeId;
            this.Name = name;
            this.Email = email;
            this.UserType = userType.ToString();
            this.Password = password;
        }
    }    
}

//email, user type(Basic User - RMG, TAG, PM, TL), password and password confirmation.