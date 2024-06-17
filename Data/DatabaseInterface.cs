using LiteDB;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public interface DatabaseInterface
    {
        //User
        //Get
        IEnumerable<User> GetUsers();
        IEnumerable<Booking> GetBookings();
        IEnumerable<Comment> GetComments();
        User GetUserById(int id);
        IEnumerable<Spot> GetSearchSpot(DateTime checkIn, DateTime checkOut, string city);
        void AddUser(User user); //post
                                 //void DeleteUser(User user);

        //void DeleteUser(User user,int id);

        void AddBooking(Booking booking);
        void AddComment(Comment comment);
        //Spot
        //Get
        IEnumerable<Spot> GetSpots();
        Spot GetSpotById(int id);
        IEnumerable<Comment> GetCommentBySpotId(int id);
        void AddSpot(Spot spot);

        //void DeleteSpot(Spot spot);
    }
}
