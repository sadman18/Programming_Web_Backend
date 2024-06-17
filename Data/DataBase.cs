using LiteDB;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DataBase : DatabaseInterface

    {
        LiteDatabase db = new LiteDatabase(@"data.db");

        public IEnumerable<User> GetUsers()
        {
            return db.GetCollection<User>("Users").FindAll();
        }
        public IEnumerable<Booking> GetBookings()
        {
            return db.GetCollection<Booking>("Booking").FindAll();
        } 
        public IEnumerable<Comment> GetComments()
        {
            return db.GetCollection<Comment>("Comment").FindAll();
        }
        public User GetUserById(int id)
        {
            return db.GetCollection<User>("Users").FindById(id);
        }

        public void AddUser(User user)
        {
            db.GetCollection<User>("Users").Insert(user);
        }
        public void AddBooking(Booking booking)
        {
            db.GetCollection<Booking>("Booking").Insert(booking);
        }
        public void AddComment(Comment comment)
        {
            db.GetCollection<Comment>("Comment").Insert(comment);
        }

        //public void DeleteUser(User user,int id)
        //{
        //    user.Id = id;
        //    db.GetCollection<User>("users").Delete(id);
        //}

        public IEnumerable<Spot> GetSpots()
        {

            return db.GetCollection<Spot>("Spots").FindAll();
         }
        public Spot GetSpotById(int id)
        {
            return db.GetCollection<Spot>("Spots").FindById(id);
        }
        public IEnumerable<Comment> GetCommentBySpotId(int id)
        {
            return db.GetCollection<Comment>("Comment").Find(spot => spot.SpotID == id);
        }
        IEnumerable<Spot> GetSearchSpot(DateTime checkIn, DateTime checkOut, string city)
        {
            return db.GetCollection<Spot>("Spots").Find( spot =>(spot.CheckIn==checkIn)&&(spot.CheckOut==checkOut) && (spot.City==city));
        }

        //post
        public void AddSpot(Spot spot)
        {
            db.GetCollection<Spot>("Spots").Insert(spot); 
        }

        IEnumerable<Spot> DatabaseInterface.GetSearchSpot(DateTime checkIn, DateTime checkOut, string city)
        {
            return db.GetCollection<Spot>("Spots").Find(spot => (spot.CheckIn <= checkIn) && (spot.CheckOut >= checkOut) && (spot.City == city));
        }

        public IEnumerable<Comment> GetCommentById(int id)
        {
            return db.GetCollection<Comment>("Comment").Find(spot => spot.SpotID == id);
        }





        //public void DeleteSpot(int id)
        //{
        //    db.GetCollection<Spot>("Spots").Delete(id);

        //}


    }
}
