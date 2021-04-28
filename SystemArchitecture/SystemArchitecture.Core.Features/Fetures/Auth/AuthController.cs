using System.Threading.Tasks;
using SystemArchitecture.Core.Base;
using SystemArchitecture.Core.Dto;
using SystemArchitecture.Core.Entities;
using SystemArchitecture.Core.Features.Fetures.Auth.Queries;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace SystemArchitecture.Core.Features.Fetures.Auth
{
    public class AuthController : ApiControllerBase
    {
        private SignInManager<User> _signInManager;
        private readonly IMapper _mapper;
        private UserManager<User> _userManager;

        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper)
        {
            _signInManager = signInManager;
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromQuery] UserDto dto)
        {
            var user = new User(dto.Email, dto.Age, dto.Gender, dto.PhoneNumber, dto.Competences,
                dto.AbouteMe, dto.UserName);

            var createUserResult = await _userManager.CreateAsync(user, dto.Password);

            if (!createUserResult.Succeeded)
            {
                return UnprocessableEntity(createUserResult.Errors);
            }

            var signInResult = await _signInManager.CheckPasswordSignInAsync(user, dto.Password, false);
            return !signInResult.Succeeded ? UnprocessableEntity("Ошибка при авторизации") : Ok(dto);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromQuery] LoginQuery query)
        {
            var user = await _userManager.FindByEmailAsync(query.Email);
            var signInResult = await _signInManager.CheckPasswordSignInAsync(user, query.Password, false);
            
            if (!signInResult.Succeeded)
            {
                return UnprocessableEntity("Ошибка при авторизации");
            }

            return Ok(_mapper.Map<UserDto>(user));
        }
    }
}