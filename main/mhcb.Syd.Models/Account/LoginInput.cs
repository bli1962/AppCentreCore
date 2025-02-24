using System.ComponentModel.DataAnnotations;
  
namespace mhcb.Syd.Models.Account
{
    public class LoginInput : LoginUser
    {
        [Required]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "AppCenter ID must be {2} characters at least and at max {1}.")]
        [Display(Name = "AppCenter ID")]
        public override string UserName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.")]
        [DataType(DataType.Password)]
        [Display(Name = "AppCenter password")]
        public override string Password { get; set; }


        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

        //public bool isPersistent { get; set; }
        public bool lockoutOnFailure { get; set; }

        //public string FirstName { get; set; }
        //public string MiddleName { get; set; }
        //public string LastName { get; set; }
        //public string REC_STATUS { get; set; }

        //public string AccessToken { get; set; }
        //public string RefreshToken { get; set; }

        ////public Role Role { get; set; }
        //public virtual ICollection<Role> UserRoles { get; set; }

    }
}
