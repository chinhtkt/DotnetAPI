using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetAPI.BizLogics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DotnetAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberController : ControllerBase
    {

        private IMemberHandLer _memberHandler;
        public MemberController(IMemberHandLer memberHandler)
        {
            _memberHandler = memberHandler;
        }

        [HttpGet]
        [Route("/api/member/memberbygender/{gender}")]
        public List<Member> ListAllMaleMembers(string gender)
        {
            return _memberHandler.ListAllMaleMembers(gender);
        }
        [HttpGet]
        [Route("/api/member/memberbyage/{age}")]
        public Member ReturnTheOldestMember()
        {
            return _memberHandler.ReturnTheOldestMember();
        }
        [HttpGet]
        [Route("/api/member/memberwithfullname")]
        public List<string> GetMembersWithFullNameOnly()
        {
            return _memberHandler.GetMembersWithFullNameOnly();
        }
        [HttpGet]
        [Route("/api/member/filtermember{year}")]
        public List<Member> FilterMemberByBirthYear(int year)
        {
            return _memberHandler.FilterMemberByBirthYear(year);
        }
        [HttpGet]
        [Route("/api/member/filtermemberless{year}")]
        public List<Member> FilterMemberByBirthYearLessThan(int year)
        {
            return _memberHandler.FilterMemberByBirthYearLessThan(year);
        }
        [Route("/api/member/filtermembergreater{year}")]
        public List<Member> FilterMemberByBirthYearGreaterThan(int year)
        {
            return _memberHandler.FilterMemberByBirthYearGreaterThan(year);
        }
        [Route("/api/member/FilterMemberInHaNoi{place}")]
        public List<Member> FilterMemberByBirthYearGreaterThan(string place)
        {
            return _memberHandler.FilterMemberInHaNoi(place);
        }
    }
    
}
