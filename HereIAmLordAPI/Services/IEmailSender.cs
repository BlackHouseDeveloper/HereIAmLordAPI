using System;
using System.Threading.Tasks;

namespace HereIAmLordAPIAccount.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
