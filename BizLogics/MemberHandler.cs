using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotnetAPI.BizLogics
{
    public class MemberHandler : IMemberHandLer
    {

        public MemberHandler()
        {
            SeedingData();
        }

        






        public List<Member> FilterMemberInHaNoi(string place)
        {
            var result = _listMembers.Where(x => x.BirthPlace == place).ToList();

            return result;
        }

        public List<Member> FilterMemberByBirthYear(int year)
        {
            var result = _listMembers.Where(x => x.DateBirth.Year == year).ToList();

            return result;
        }

        public List<Member> FilterMemberByBirthYearGreaterThan(int year)
        {
            var result = _listMembers.Where(x => x.DateBirth.Year < year).ToList();

            return result;
        }

        public List<Member> FilterMemberByBirthYearLessThan(int year)
        {
            var result = _listMembers.Where(x => x.DateBirth.Year > year).ToList();

            return result;
        }

        public List<string> GetMembersWithFullNameOnly()
        {
            var result = _listMembers.Select(x => $"{x.FirstName + ' ' + x.LastName}").ToList();
            return result;
        }

        public List<Member> ListAllMaleMembers(string gender)
        {
            var result = _listMembers.Where(x => x.Gender == gender).ToList();

            return result;
        }

        public Member ReturnTheOldestMember()
        {
            var minDob = _listMembers.Min(x => x.DateBirth);
            var result = _listMembers.FirstOrDefault(x => x.DateBirth == minDob);

            return result;
            
        }

        private List<Member> _listMembers;

        private void SeedingData()
        {
            _listMembers = new List<Member>
            {
                new Member 
                {
                    FirstName = "Duc",
                    LastName= "Chinh",
                    BirthPlace = "Ha Noi",
                    DateBirth = DateTime.Now.AddYears(-21),
                    Gender = "Male",
                    isGraduated = true,
                    PhoneNumber = "0123456789",
                    StartDate = DateTime.Now.AddYears(-10),
                    EndDate = DateTime.Now.AddYears(5),

                },
                new Member 
                {
                    FirstName = "Van",
                    LastName= "Chien",
                    BirthPlace = "Ha Dong",
                    DateBirth = DateTime.Now.AddYears(-64),
                    Gender = "Male",
                    isGraduated = true,
                    PhoneNumber = "0123456789",
                    StartDate = DateTime.Now.AddYears(-10),
                    EndDate = DateTime.Now.AddYears(5),

                },
                new Member 
                {
                    FirstName = "Nguyen",
                    LastName= "A",
                    BirthPlace = "Ha Dong",
                    DateBirth = DateTime.Now.AddYears(-65),
                    Gender = "Female",
                    isGraduated = false,
                    PhoneNumber = "057398593423",
                    StartDate = DateTime.Now.AddYears(-10),
                    EndDate = DateTime.Now.AddYears(5),

                },
                new Member 
                {
                    FirstName = "Nguyen",
                    LastName= "B",
                    BirthPlace = "Lao Cai",
                    DateBirth = DateTime.Now.AddYears(-20),
                    Gender = "Female",
                    isGraduated = true,
                    PhoneNumber = "4123124124",
                    StartDate = DateTime.Now.AddYears(-10),
                    EndDate = DateTime.Now.AddYears(5),

                },
                new Member 
                {
                    FirstName = "Nguyen ",
                    LastName= "C",
                    BirthPlace = "Ha Tay",
                    DateBirth = DateTime.Now.AddYears(-54),
                    Gender = "Female",
                    isGraduated = false,
                    PhoneNumber = "4234341423",
                    StartDate = DateTime.Now.AddYears(-10),
                    EndDate = DateTime.Now.AddYears(5),

                },
            };
        }
    }
}