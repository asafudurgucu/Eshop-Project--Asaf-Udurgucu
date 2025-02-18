using AutoMapper;
using eshop_Data.Abstract;
using eshop_Entity.Contcrete;
using eshop_Service.Abstract;
using eshop_Shared.DTOs;
using eshop_Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Service.Concrete
{
    public class PaymentService : IPaymentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Payment> _genericRepository;

        public PaymentService(IUnitOfWork unitOfWork, IMapper mapper, IGenericRepository<Payment> genericRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _genericRepository = genericRepository;
        }

        public async Task<ResponseDTO<PaymentDTO>> AddAsync(PaymentDTO paymentDTO)
        {
            var card = _mapper.Map<Payment>(paymentDTO);
            await _genericRepository.AddAsync(card);
            var result = await _unitOfWork.SaveAsync();
            if(result <= 0)
            {
                return ResponseDTO<PaymentDTO>.Fail("Mesaj eklenirken bir sorun oluştu", 404);
            }
            return ResponseDTO<PaymentDTO>.Success(paymentDTO, 200);
        }

        public async Task<ResponseDTO<IEnumerable<PaymentDTO>>> GetAll()
        {
            var card = await _genericRepository.GetAllAsync();
            if (card == null)
            {
                return ResponseDTO<IEnumerable<PaymentDTO>>.Fail("Kartlar Gelirken Bir Sorun Oluştu", 404);
            }
            if (!card.Any())
            {
                return ResponseDTO<IEnumerable<PaymentDTO>>.Fail("Hiç Kart Bulunamadı", 404);
            }
            var cardDTO = _mapper.Map<IEnumerable<PaymentDTO>>(card);
            return ResponseDTO<IEnumerable<PaymentDTO>>.Success(cardDTO, 200);
        }

        public async Task<ResponseDTO<PaymentDTO>> GetPayment(int id)
        {
           var card = await _genericRepository.GetByIdAsync(id);
            if(card == null)
            {
                return ResponseDTO<PaymentDTO>.Fail("işlem başarısız", 404);
            }
            var carddto = _mapper.Map<PaymentDTO>(card);
            return ResponseDTO<PaymentDTO>.Success(carddto, 200);
        }
    }
}
