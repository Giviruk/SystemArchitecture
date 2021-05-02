using SystemArchitecture.Core.Base;
using Microsoft.AspNetCore.Mvc;

namespace SystemArchitecture.Core.Features.Fetures.Timetable
{
    public class TimetableController : ApiControllerBase
    {
        public TimetableController()
        {
            
        }

        [HttpGet]
        public IActionResult GetLessons()
        {
            return Ok("Ok");
        }
    }
}
