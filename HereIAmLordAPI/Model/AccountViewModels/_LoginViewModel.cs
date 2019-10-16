
using System.Collections.Generic;

namespace HereIAmLordAPIAccount.Model.AccountViewModels
{
    public class _LoginViewModel :LoginViewModel
    {
        
            public bool EnableLocalLogin { get; set; }
            public IEnumerable<ExternalProvider> ExternalProviders { get; set; }
    }


    public class ExternalProvider
        {
            public string DisplayName { get; set; }
            public string AuthenticationScheme { get; set; }
        }
    
}
