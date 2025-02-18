using eshop_Shared.DTOs;
using eshop_Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Service.Abstract
{
    public interface IPaymentService
    {
        Task<ResponseDTO<PaymentDTO>> GetPayment(int id);
        Task<ResponseDTO<PaymentDTO>> AddAsync(PaymentDTO paymentDTO);
        Task<ResponseDTO<IEnumerable<PaymentDTO>>> GetAll();

    }

}
