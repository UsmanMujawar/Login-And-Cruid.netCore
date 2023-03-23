using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication181.Models;

namespace WebApplication181.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
       
        [HttpGet]
        [Route("GetData")]
        public string GetData()
        {
            return "Authenticated With JWT";

        }
        [HttpGet]
        [Route("Details")]
        public string Details()
        {
            return "Authenticated With JWT";

        }
       
        [HttpPost]   
        public string AddUsers(Users user)
        {
            return "User added with username " + user.Username;

        }



    }
}
