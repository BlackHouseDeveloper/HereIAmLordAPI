using System.Collections.Generic;
using IdentityServer4;
using IdentityServer4.Models;

namespace HereIAmLordAPIAccount.Configuration
{
    public class Config
    {
        // ApiResources define the apis in your system
        public static IEnumerable<ApiResource> GetApis()
        {
            return new List<ApiResource>
            {

            };
        }

        // Identity resources are data like user ID, name, or email address of a user
        // see: http://docs.identityserver.io/en/release/configuration/resources.html
        public static IEnumerable<IdentityResource> GetResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };
        }

        // client want to access resources (aka scopes)
        public static IEnumerable<Client> GetClients(Dictionary<string, string> clientsUrl)
        {
            return new List<Client>
            {
                new Client
            {
                ClientId = "xamarin",
                ClientName = "eShop Xamarin OpenId Client",
                AllowedGrantTypes = GrantTypes.Implicit,
                AllowAccessTokensViaBrowser = true,
                RedirectUris = { clientsUrl["Xamarin"] },
                RequireConsent = false,
                PostLogoutRedirectUris = { "http://13.88.8.119:5105/Account/Redirecting", "http://10.6.1.234:5105/Account/Redirecting" },
                AllowedCorsOrigins = { "http://eshopxamarin" },
                AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile

                    }
            }

            };


        }
    }
}
