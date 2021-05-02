﻿using SystemArchitecture.Core.Base;
using SystemArchitecture.Core.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SystemArchitecture.Core.Features.Fetures.TeacherProfile
{
    public class TeacherProfileController : ApiControllerBase
    {
        public TeacherProfileController()
        {
            
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status429TooManyRequests)]
        [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
        [HttpGet]
        public IActionResult Get(TeacherDto teacher)
        {
            teacher.UserName = "John Green";
            teacher.Age = 32;
            teacher.Email = "john.green@gmail.com";
            teacher.Competence = "Math"; 
            return Ok(teacher);
        }
    }
}