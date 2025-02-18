using eshop_MVC.Models;

namespace eshop_MVC.Abstract
{
    public interface IPaymentService
    {

        Task<PaymentModel> CreatePaymentAsync(PaymentModel payment);
        Task<IEnumerable<PaymentModel>> GetAllPaymentsAsync();
        Task<PaymentModel> GetPaymentByIdAsync(int id);
    }
}
