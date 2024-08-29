using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.Models
{
    public class CommentModel
    {
        public int Id { get; set; }
        [Required]
        public int TicketId { get; set; }
        public string CommentText { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}