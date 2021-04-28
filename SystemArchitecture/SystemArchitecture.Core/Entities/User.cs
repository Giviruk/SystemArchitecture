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
        
        public Image Image { get; set; }

        public List<Competence> Competences { get; set; }

        protected User()
        {
        }

        public User(string email, int age, Genders gender, string phoneNumber, List<Competence> competences,string aboutMe, string userName)
        {
            Age = age;
            Gender = gender;
            AboutMe = aboutMe;
            
            Competences = competences;
            Email = email;
            UserName = userName;
            NormalizedUserName = UserName.Normalize();
            PhoneNumber = phoneNumber;
        }
        
        public User(string email, string phoneNumber, Genders gender,int age)
        {
            Age = age;
            Gender = gender;
            Email = email;
            UserName = UserName;
            PhoneNumber = phoneNumber;
        }
    }
}