using Microsoft.AspNetCore.Components.Web.Virtualization;

namespace WebApplication1.Models
{
    public class Spot
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int Price { get; set; }
        public List<string> Services { get; set; }
        public string ImageUrl { get; set; }
    }
}
