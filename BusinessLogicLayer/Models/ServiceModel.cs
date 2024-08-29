

using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.Models
{
    public class ServiceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public int CompanyId { get; set; }
        public CompanyModel Company { get; set; }




    }
}
