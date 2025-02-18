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
    public class ContactMessageService : IContactMessageService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<ContactMessage> _messageRepository;
        private readonly IMapper _mapper;

        public ContactMessageService(IUnitOfWork unitOfWork, IGenericRepository<ContactMessage> messageRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _messageRepository = messageRepository;
            _mapper = mapper;
        }

        public async Task<ResponseDTO<int>>Count()
        {
            var count = await _messageRepository.CountAsync();
            return ResponseDTO<int>.Success(count, 200);
        }

        public async Task<ResponseDTO<NoContent>> Delete(int id)
        {
            var message = await  _messageRepository.GetByIdAsync(id);
            if (message == null) 
            {
                return ResponseDTO<NoContent>.Fail("Mesaj Silme Hatası",404) ;
            }
            _messageRepository.Delete(message);
            var result = await _unitOfWork.SaveAsync();
            if (result <= 0)
            {
                return ResponseDTO<NoContent>.Fail("Bir Sorun Oluştu",404);
            }
            return ResponseDTO<NoContent>.Success(200) ;
        }

        public async Task<ResponseDTO<ContactMessageDTO>> Get(int Id)
        {
            var message = await _messageRepository.GetByIdAsync(Id);
            if (message == null) 
            {
                return ResponseDTO<ContactMessageDTO>.Fail("Mesaj Gelirken Sorun Oluştur", 404);
            }
            var messageDTO = _mapper.Map<ContactMessageDTO>(message);
            return ResponseDTO<ContactMessageDTO>.Success(messageDTO, 200);
        }

        public async Task<ResponseDTO<IEnumerable<ContactMessageDTO>>> GetAll()
        {
            var message = await _messageRepository.GetAllAsync();
            if(message == null)
            {
                return ResponseDTO<IEnumerable<ContactMessageDTO>>.Fail("mesajlar gelirken bir sorun oldu", 404);
            }
            if (!message.Any())
            {
                return ResponseDTO<IEnumerable<ContactMessageDTO>>.Fail("Hiç Mesaj Bulunamadı", 404);
            }
            var messageDTO = _mapper.Map<IEnumerable<ContactMessageDTO>>(message);
            return ResponseDTO<IEnumerable<ContactMessageDTO>>.Success(messageDTO, 200);
        }

        public async Task<ResponseDTO<CreateContactMessageDto>> SendAsync(CreateContactMessageDto contactMessageDTO)
        {
            
            var message = _mapper.Map<ContactMessage>(contactMessageDTO);
            await _messageRepository.AddAsync(message);
            var result = await _unitOfWork.SaveAsync();
            if (result <= 0)
            {
                return ResponseDTO<CreateContactMessageDto>.Fail("Mesaj eklenirken bir sorun oluştu", 404);
            }

            return ResponseDTO<CreateContactMessageDto>.Success(contactMessageDTO, 200);
        }

    }
}
