using eshop_Entity.Contcrete;
using eshop_Shared.DTOs;
using eshop_Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Service.Abstract
{
    public interface IContactMessageService
    {
        Task<ResponseDTO<CreateContactMessageDto>> SendAsync(CreateContactMessageDto contactMessageDTO); //
        Task<ResponseDTO<NoContent>> Delete(int Id);
        Task<ResponseDTO<ContactMessageDTO>> Get(int Id); //
        Task<ResponseDTO<IEnumerable<ContactMessageDTO>>> GetAll(); // 
        Task<ResponseDTO<int>> Count();





    }
}
