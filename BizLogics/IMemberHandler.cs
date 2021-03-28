using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotnetAPI.BizLogics
{
    public interface IMemberHandLer
    {
        //Return a list of members who is Male
        List<Member> ListAllMaleMembers(string gender);

        
        //Return the oldest one based on “Age”
        Member ReturnTheOldestMember();
        //Return a new list that contains Full Name 
        List<string> GetMembersWithFullNameOnly();
        // Return list of members who has birth year is 2000
        List<Member> FilterMemberByBirthYear(int year);

        // Return list of members who has birth year greater than 2000
        List<Member> FilterMemberByBirthYearLessThan(int year);
        // Return list of members who has birth year less than 2000
        List<Member> FilterMemberByBirthYearGreaterThan(int year);
        // Return the first person who was born in Ha Noi
        List<Member> FilterMemberInHaNoi(string place);

        //List<Member> AddNewMember (Member member)
        
    }


}