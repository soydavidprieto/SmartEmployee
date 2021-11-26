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
        public string userFirstName { get; set; }

        [Required]
        [Display(Name ="Last name")]
        [MaxLength(150, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string userLastName { get; set; }

        

        [DataType(DataType.Password)]
        public string temPasswordUser { get; set; }

        

        [Display(Name = "Image")]
        public string userImageUrl { get; set; }


        public string ImageFullPath => string.IsNullOrEmpty(userImageUrl)
            ? null
            : $"https://TDB.azurewebsites.net{userImageUrl.Substring(1)}";

        public string FullName => $"{userFirstName} {userLastName}";

        
    }
}
