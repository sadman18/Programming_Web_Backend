namespace WebApplication1.Models
{
    public class Comment
    {
        public int Id { get; private set; }
        public int UserID { get; set; }
        public int SpotID { get; set; }
        public string CommentText { get; set; }
        public int Rating { get; set; }

    }
}
