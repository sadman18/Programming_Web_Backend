using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
   
        [Route("api/[controller]")]
        [ApiController]
        public class CommentController : ControllerBase
        {
            private DatabaseInterface _data;
            public CommentController(DatabaseInterface data)
            {
                _data = data;
            }
            [HttpGet]
            public ActionResult<IEnumerable<Comment>> Get()
            {
                return Ok(_data.GetComments());
            }
        [HttpGet("{id}")]
        public ActionResult<Comment> comment(int id)
        {
            return Ok(_data.GetCommentBySpotId(id));
        }
        [HttpPost]
            public ActionResult Post([FromBody] Comment comment)
            {
                _data.AddComment(comment);
                return Ok((new { message = "a comment added" }));

            }
        }
    }


