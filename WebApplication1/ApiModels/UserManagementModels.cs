using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ApiModels
{
    public static class UserRoles
    {
        public const string Admin = "Admin";
        public const string User = "User";
    }
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
    public class Response
    {
        public string? Status { get; set; }
        public string? Message { get; set; }
    }

}
