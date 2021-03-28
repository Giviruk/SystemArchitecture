using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace SystemArchitecture.Core.Entities
{
    public class User: IdentityUser<Guid>
    {
        public string AboutMe { get; protected set; }
        
        [Range(0,100)]
        public int Age { get; protected set; }
        
        public Genders Gender { get; protected set; }
        
        public string ImageUrl { get; set; }
        
        
        public List<Competence> Competences { get; set; }

        protected User()
        {
        }

        public User(string email, int age, Genders gender, string phoneNumber, string imageUrl)
        {
            Age = age;
            Gender = gender;
            ImageUrl = imageUrl;
            Email = email;
            UserName = email.Split("@").FirstOrDefault();
            NormalizedUserName = UserName.Normalize();
            PhoneNumber = phoneNumber;
        }
        
        public User(string email, int age, Genders gender, string phoneNumber, string imageUrl, List<Competence> competences)
        {
            Age = age;
            Gender = gender;
            ImageUrl = imageUrl;
            Competences = competences;
            Email = email;
            UserName = email.Split("@").FirstOrDefault();
            NormalizedUserName = UserName.Normalize();
            PhoneNumber = phoneNumber;
        }
    }
}