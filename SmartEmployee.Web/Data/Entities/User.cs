using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace SmartEmployee.Web.Data.Entities
{
    public class User : IdentityUser
    {


        [Required]
        [Display(Name = "Firt name")]
        [MaxLength(150, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string firstName { get; set; }

        [Required]
        [Display(Name = "Surname")]
        [MaxLength(80, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string surname { get; set; }

        [Required]
        [Display(Name = "Second surname")]
        [MaxLength(80, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string secondSurname { get; set; }


        //[Display(Name = "Image")]
        //public string userImageUrl { get; set; }

        public ICollection<Employee> Employees { get; set; }


        //public string imageFullPath => string.IsNullOrEmpty(userImageUrl)
        //    ? null
        //    : $"https://TDB.azurewebsites.net{userImageUrl.Substring(1)}";

        public string FullName => $"{firstName} {surname} {secondSurname}";

        
    }
}
