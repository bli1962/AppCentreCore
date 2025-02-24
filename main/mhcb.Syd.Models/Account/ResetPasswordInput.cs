using mhcb.Syd.Models.CustomValidators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mhcb.Syd.Models.Account
{
    public class ResetPasswordInput
    {
        [Required]
        [Display(Name = "MIZUHO email address only")]
        [EmailAddress]
        [EmailDomainValidator(AllowedDomain = "mizuho-cb.com", ErrorMessage = "Only mizuho-cm is allowed")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Id { get; set; }
        public string Code { get; set; }
    }
}
