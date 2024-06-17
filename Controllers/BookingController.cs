using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private DatabaseInterface _data;
        public BookingController(DatabaseInterface data)
        {
            _data = data;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Booking>> Bookings()
        {
            return Ok(_data.GetBookings());
        }
        [HttpPost]
        public ActionResult Post([FromBody] Booking booking)
        {
            _data.AddBooking(booking);
            return Ok((new {message="a booking added"}));

        }

    }
}
