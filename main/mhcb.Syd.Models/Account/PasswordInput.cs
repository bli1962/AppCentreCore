using mhcb.Syd.Models.CustomValidators;
using System.ComponentModel.DataAnnotations;

namespace mhcb.Syd.Models.Account
{
    public class PasswordInput
    {
        [Required]
        [Display(Name = "MIZUHO email address only")]
        [EmailAddress]
        [EmailDomainValidator(AllowedDomain = "mizuho-cb.com", ErrorMessage = "Only mizuho-cm is allowed")]
        public string Email { get; set; }

        public string Id { get; set; }
    }
}
