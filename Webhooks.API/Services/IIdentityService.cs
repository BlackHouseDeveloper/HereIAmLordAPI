using System;
using System.Threading.Tasks;

namespace Webhooks.API.Services
{
    public interface IIdentityService
    {
        string GetUserIdentity();
        
    }
}
