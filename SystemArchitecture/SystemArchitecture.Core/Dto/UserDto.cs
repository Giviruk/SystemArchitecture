using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SystemArchitecture.Core.Entities;

namespace SystemArchitecture.Core.Dto
{
    public class UserDto
    {
        [Required] public string Email { get; set; }

        [Required] public string Password { get; set; }

        [Required] public string UserName { get; set; }

        public string AbouteMe { get; set; }

        [Required] public Genders Gender { get; set; }

        public List<Competence> Competences { get; set; }

        [Required] [Range(0, 100)] public int Age { get; set; }

        [Required] public string PhoneNumber { get; set; }
    }
}