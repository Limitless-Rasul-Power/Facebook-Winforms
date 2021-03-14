using System;

namespace WindowsForms_Task2
{
    public class User : Person
    {
        public User(string username, string password, string gender, DateTime birthDay, string description)
            : base(gender, birthDay)
        {
            Username = username;
            Password = password;
            Description = description;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }

    }
}
