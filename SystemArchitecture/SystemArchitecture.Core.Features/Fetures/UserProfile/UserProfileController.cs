using SystemArchitecture.Core.Base;
using Microsoft.AspNetCore.Mvc;

namespace SystemArchitecture.Core.Features.Fetures.UserProfile
{
    public class UserProfileController : ApiControllerBase
    {
        public UserProfileController()
        {
            
        }

        [HttpGet]
        public IActionResult GetProfile(int id)
        {
            return Ok("Ok");
        }

        [HttpGet]
        public IActionResult LoadProfilePicture()
        {
            return Ok("Ok");
        }

        [HttpPost]
        public IActionResult EditProfile()
        {
            return Ok("Ok");
        }

        [HttpPost]
        public IActionResult DeleteProfile()
        {
            return Ok("Ok");
        }

        [HttpPost]
        public IActionResult FollowProfile()
        {
            return Ok("Ok");
        }
    }
}
