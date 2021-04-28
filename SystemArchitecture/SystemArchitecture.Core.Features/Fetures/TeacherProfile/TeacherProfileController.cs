using SystemArchitecture.Core.Base;
using SystemArchitecture.Core.Dto;
using Microsoft.AspNetCore.Mvc;

namespace SystemArchitecture.Core.Features.Fetures.TeacherProfile
{
    public class TeacherProfileController : ApiControllerBase
    {
        public TeacherProfileController()
        {
            
        }

        public IActionResult Get(TeacherDto teacher)
        {
            teacher.UserName = "John Green";
            teacher.Age = 32;
            teacher.Email = "john.green@gmail.com";
            return Ok("Ok");
        }
    }
}