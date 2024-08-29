

namespace BusinessLogicLayer.Resoures
{
    public class CommentResource
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public string CommentText { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}

