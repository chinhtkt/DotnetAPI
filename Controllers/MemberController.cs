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
    }
    
}
