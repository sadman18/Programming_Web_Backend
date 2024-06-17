namespace WebApplication1.Models
{
    public class Booking
    {
        public int Id { get; private set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int UserId { get; set; }
        public int SpotId { get; set; }
        public int Guest {  get; set; }
    }
}
