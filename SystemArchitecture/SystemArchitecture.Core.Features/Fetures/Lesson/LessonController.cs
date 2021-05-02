﻿using System;
using SystemArchitecture.Core.Base;
using SystemArchitecture.Core.Dto;
using SystemArchitecture.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SystemArchitecture.Core.Features.Fetures.Lesson
{
    public class LessonController : ApiControllerBase
    {
        public LessonController()
        {
            
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status429TooManyRequests)]
        [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
        [HttpGet]
        public IActionResult GetLesson(LessonDto lesson)
        {
            lesson.Title = "Math";
            lesson.StartDate = DateTime.MinValue;
            lesson.EndDate = DateTime.MaxValue;
            return Ok(lesson);
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status429TooManyRequests)]
        [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
        [HttpPost]
        public IActionResult CreateLesson(User teacher, User student, LessonDto dto)
        {
            var lesson = new Entities.Lesson(teacher, student, dto.StartDate, dto.EndDate, dto.Title);
            return Ok(lesson);
        }
    }
}