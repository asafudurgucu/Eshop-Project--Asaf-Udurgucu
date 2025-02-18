namespace eshop_MVC.Models
{
    public class CommentWithProductViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } // Ürün ismini alıyoruz
        public string ApplicationUserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ProfileImageUrl { get; set; }
    }
}
