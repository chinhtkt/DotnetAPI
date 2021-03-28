using System;

namespace DotnetAPI
{
    public class Person
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Gender { set; get; }
        public DateTime DateBirth { set; get; }
        public string PhoneNumber { set; get; }
        public string BirthPlace { set; get; }
        public bool isGraduated { get; set; }
    }

}