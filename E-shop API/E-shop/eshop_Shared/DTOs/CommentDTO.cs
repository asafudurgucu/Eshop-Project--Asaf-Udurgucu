using System;

namespace eshop_Shared.DTOs;

public class CommentDTO
{
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ApplicationUserId { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; } 
        public string LastName { get; set; }  
        public string ProfileImageUrl { get; set; }

}
