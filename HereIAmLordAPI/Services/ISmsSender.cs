using System.Threading.Tasks;

namespace HereIAmLordAPIAccount.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
