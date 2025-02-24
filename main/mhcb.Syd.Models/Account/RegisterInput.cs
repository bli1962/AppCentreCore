using mhcb.Syd.Models.CustomValidators;
using System.ComponentModel.DataAnnotations;

namespace mhcb.Syd.Models.Account
{
    public class RegisterInput : RegisterUser
    {
        [Required]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "AppCenter ID must be {2} characters at least and at max {1}.")]
        [Display(Name = "AppCenter ID")]
        public override string UserName { get; set; }

        [Required]
        [Display(Name = "MIZUHO email address")]
        [EmailAddress]
        [EmailDomainValidator(AllowedDomain = "mizuho-cb.com", ErrorMessage = "Only mizuho-cm is allowed")]
        public override string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public override string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
