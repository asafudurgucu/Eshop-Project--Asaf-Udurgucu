using eshop_Shared.ResponseDTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Shared.Helpers
{
    public class CustomControllerBase:ControllerBase
    {
        public static IActionResult CreateResponse<T>(ResponseDTO<T> responseDTO)
        {
            return new ObjectResult(responseDTO)
            {
                StatusCode = responseDTO.StatusCode
            };
        }
    }
}
