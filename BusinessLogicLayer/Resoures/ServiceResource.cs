
namespace BusinessLogicLayer.Resoures
{
    public class ServiceResource
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompanyId { get; set; }
        public CompanyResource Company { get; set; }

       
    }
}

