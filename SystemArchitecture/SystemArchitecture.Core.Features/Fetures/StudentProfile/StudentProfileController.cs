using SystemArchitecture.Core.Base;
using SystemArchitecture.Core.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SystemArchitecture.Core.Features.Fetures.StudentProfile
{
    public class StudentProfileController : ApiControllerBase
    {
        public StudentProfileController()
        {
            
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status429TooManyRequests)]
        [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
        [HttpGet]
        public IActionResult Get(StudentDto student)
        {
            student.UserName = "Jake Woods";
            student.Age = 19;
            student.Email = "jake.woods@gmail.com";
            return Ok(student);
        }
    }
}