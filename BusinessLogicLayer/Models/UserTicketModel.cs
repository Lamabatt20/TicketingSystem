
using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.Models
{
    public class UserTicketModel
    {
        public int Id { get; set; }
        [Required]
        public int TicketId { get; set; }

        [Required]
        public int UserId { get; set; }

    }
}


