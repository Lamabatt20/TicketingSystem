using BusinessLogicLayer.Mapping;
using BusinessLogicLayer.Models;
using BusinessLogicLayer.Resoures;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Mappings
{
    public static class UserTicketMapping
    {
        public static UserTicket ToEntity(this UserTicketModel model) =>
            new UserTicket
            {
                Id = model.Id,
                TicketId = model.TicketId,
                UserId = model.UserId,
            };

        public static UserTicketModel ToModel(this UserTicket entity) =>
            new UserTicketModel
            {
                Id = entity.Id,
                TicketId = entity.TicketId,
                UserId = entity.UserId,

            };

        public static UserTicketResource ToResource(this UserTicket entity) =>
      new UserTicketResource
      {
          Id = entity.Id,
          User = entity.User.ToResource(),
          Ticket = entity.Ticket.ToResource()
      };




        public static IEnumerable<UserTicketResource> ToResource(this IEnumerable<UserTicket> entities) =>
            entities.Select(e => e.ToResource());
    }
}
