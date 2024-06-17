using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class SpotController : ControllerBase
    {
        
        private DatabaseInterface _data;
        public SpotController(DatabaseInterface data)
        {
            _data = data;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Spot>> Spots()
        {
            return Ok(_data.GetSpots());
        }

        [HttpGet("{id}")]
        public ActionResult<User> User(int id)
        {
            return Ok(_data.GetSpotById(id));
        }
        [HttpGet("{checkIn}/{checkOut}/{city}")]
        public ActionResult<IEnumerable<Spot>> SearchSpot(DateTime checkIn, DateTime checkOut, string city)
        {
            var spots = _data.GetSearchSpot(checkIn, checkOut, city);
            return Ok(spots);
        }


        [HttpPost]
        public ActionResult Post([FromBody] Spot spot)
        {
            _data.AddSpot(spot);
            return Ok((spot));

        }

        //[HttpPost]

        //public ActionResult Delete([FromBody] Spot spot)
        //{
        //    _data.DeleteSpot(spot);
        //    return Ok((spot));

        //}
    }

}
