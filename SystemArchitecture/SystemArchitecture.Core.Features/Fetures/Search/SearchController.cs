using System.Collections.Generic;
using SystemArchitecture.Core.Base;
using SystemArchitecture.Core.Entities;
using SystemArchitecture.Core.Features.Fetures.Search.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SystemArchitecture.Core.Features.Fetures.Search
{
    public class SearchController : ApiControllerBase
    {
        public SearchController()
        {
            
        }
        
        [HttpGet]
        public IActionResult GetTeachers(string requiredCompetence, [FromQuery] SearchQuery query)
        {
            List<User> teachers = query.Teachers;
            List<User> suitableTeachers = new List<User>();
            
            foreach (var teacher in teachers)
            {
                foreach (var competence in teacher.Competences)
                {
                    if (competence.Title == requiredCompetence)
                        suitableTeachers.Add(teacher);
                }
            }

            return Ok(suitableTeachers);
        }
    }
}
