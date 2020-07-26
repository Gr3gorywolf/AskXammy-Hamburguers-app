using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace HamburguersApp.Models
{
   public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }


    public class UserLogin
    {
       public string Email { get; set; }
       public string Password { get; set; }
    }
}
