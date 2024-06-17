using System.Security.Principal;

namespace WebApplication1.Models
{
    public class User
    {
        public int Id { get; private set; } // User ID
        public string UserName { get; set; } // User's username
        public string Password { get; set; } // User's password
        public string Name { get; set; } // User's name
        public string Email { get; set; } // User's email address
        public string Address { get; set; } // User's address
        public string Gender { get; set; } // User's gender
        public string Phone { get; set; } // User's phone number
       
    }
}

