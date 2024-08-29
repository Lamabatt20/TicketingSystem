using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        [Required]
        public int CompanyId { get; set; }
        public bool IsActive { get; set; }

    }
}
