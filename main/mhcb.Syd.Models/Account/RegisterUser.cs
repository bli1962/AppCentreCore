using System.ComponentModel.DataAnnotations;

namespace mhcb.Syd.Models.Account
{
    public class RegisterUser //: IdentityUser
    {
        [Required]
        public virtual  string UserName { get; set; }

        [Required]
        public virtual string Email { get; set; }

        [Required]
        public virtual string Password { get; set; }
    }
}
