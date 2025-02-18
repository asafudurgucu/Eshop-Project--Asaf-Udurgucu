using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Shared.DTOs
{
   public class ApplicationUserProfilePictureDTO
    {
        public IFormFile ProfilePictureUrl { get; set; }
    }
}
