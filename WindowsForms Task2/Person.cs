using System;

namespace WindowsForms_Task2
{
    public abstract class Person
    {
        protected Person(string gender, DateTime birthDay)
        {
            Gender = gender;
            BirthDay = birthDay;
        }

        public string Gender { get; set; }
        public DateTime BirthDay { get; set; }

    }
}
