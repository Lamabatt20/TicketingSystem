
using BusinessLogicLayer.Resoures;

namespace BusinessLogicLayer.Models
{
    public class TicketModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int StatusId { get; set; }

        public int PriorityId { get; set; }

        public int CompanyId { get; set; }

        public int TicketTypeId { get; set; }

        public int ServiceId { get; set; }

        public DateTime Deadline { get; set; }
        public int UpdatedBy { get; set; }
        public List<int> TicketUserIds { get; set; }
    }
}
