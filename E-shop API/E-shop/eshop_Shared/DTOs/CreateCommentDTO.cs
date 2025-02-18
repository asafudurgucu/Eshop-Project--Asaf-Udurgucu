using System;

namespace eshop_Shared.DTOs;

public class CreateCommentDTO
{
        public int ProductId { get; set; }
        public string? ApplicationUserId { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }

}
