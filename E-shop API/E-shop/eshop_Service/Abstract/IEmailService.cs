using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_Service.Abstract
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
