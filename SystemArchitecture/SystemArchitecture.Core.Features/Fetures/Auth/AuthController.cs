using SystemArchitecture.Core.Base;
using SystemArchitecture.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace SystemArchitecture.Core.Features.Fetures.Auth
{
    public class AuthController : ApiControllerBase
    {
        private UserManager<User> _userManager;

        public AuthController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        /// <summary>
        /// Пример написания документации к методу
        /// </summary>
        /// <returns>Что возвращает метод</returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status429TooManyRequests)]
        [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Ok");
        }
    }
}