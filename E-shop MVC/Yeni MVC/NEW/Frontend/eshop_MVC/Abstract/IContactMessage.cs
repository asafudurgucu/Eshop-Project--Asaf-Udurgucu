using eshop_MVC.Models;

namespace eshop_MVC.Abstract
{
    public interface IContactMessage
    {
        Task<ContactMessageModel> SendAsync(ContactMessageModel contactMessageModel);
        Task<bool> Delete(int Id);
        Task<GetContactMessageModel> Get(int Id);
        Task<IEnumerable<GetContactMessageModel>> GetAll();
        Task<int> CountAsync();
    }
}
