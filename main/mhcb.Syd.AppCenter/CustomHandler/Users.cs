using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.CustomHandler
{
    public class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string DateOfBirth { get; set; }

        public IEnumerable<Users> GetUsers()
        {
            return new List<Users>() {
                new Users {
                    Id = 101,
                    UserName = "anet",
                    Name = "Anet",
                    EmailId = "anet@test.com",
                    Password = "anet123",
                    Role="Admin" ,
                    DateOfBirth  = "01/01/2012"} ,
                 new Users {
                    Id = 102,
                    UserName = "Manager",
                    Name = "Manager",
                    EmailId = "Manager@test.com",
                    Password = "abc123",
                    Role="Manager" ,
                    DateOfBirth  = "01/01/2012"},
                  new Users {
                    Id = 103,
                    UserName = "Admin",
                    Name = "Admin",
                    EmailId = "Admin@test.com",
                    Password = "abc123",
                    Role="Admin" ,
                    DateOfBirth  = "01/01/2012"},
                  new Users {
                    Id = 104,
                    UserName = "Visitor",
                    Name = "Visitor",
                    EmailId = "Visitor@test.com",
                    Password = "abc123",
                    Role="" ,
                    DateOfBirth  = "01/01/2012"}
            };
        }
    }
}
