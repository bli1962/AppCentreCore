using System.ComponentModel.DataAnnotations;

namespace mhcb.Syd.Models.Account
{
    public class LoginUser  
    {
        [Required]
        public virtual string UserName { get; set; }

        [Required]
        public virtual string Password { get; set; }

        public virtual string Email { get; set; }
    }
}
