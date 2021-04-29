using IdentityServer4;
using IdentityServer4.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;


namespace EcommerceWebsite.Backend.IdentityServer
{
    public static class IdentityServerConfig
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
           new List<IdentityResource>
           {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
           };

        public static IEnumerable<ApiScope> ApiScopes =>
             new ApiScope[]
             {
                  new ApiScope("ecommercewebsite.api", "Ecommerce Website API")
             };

        public static IEnumerable<Client> Clients(Dictionary<string, string> ConfigUrl) =>
           new[]
            {
                // machine to machine client
                new Client
                {
                    ClientId = "client",
                    ClientSecrets = { new Secret("secret".Sha256()) },

                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    // scopes that client has access to
                    AllowedScopes = { "ecommercewebsite.api" }
                },

                // interactive ASP.NET Core MVC client
                new Client
                {
                    ClientId = "mvc",
                    ClientSecrets = { new Secret("secret".Sha256()) },

                    AllowedGrantTypes = GrantTypes.Code,

                    RedirectUris = { $"{ConfigUrl["Mvc"]}/signin-oidc" },

                    PostLogoutRedirectUris = { $"{ConfigUrl["Mvc"]}/signout-callback-oidc" },

                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "ecommercewebsite.api"
                    }
                },              

                new Client
                  {
                    ClientName = "react_admin",
                    ClientId = "react_admin",
                    ClientSecrets = { new Secret("secret".Sha256()) },
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,


                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "ecommercewebsite.api"
                    },

                    AccessTokenLifetime = 86400,
                    AllowOfflineAccess = true,
                },

                new Client
                {
                    ClientId = "swagger",
                    ClientSecrets = { new Secret("secret".Sha256()) },
                    AllowedGrantTypes = GrantTypes.Code,

                    RequireConsent = false,
                    RequirePkce = true,

                    RedirectUris =           { $"{ConfigUrl["Backend"]}/swagger/oauth2-redirect.html" },
                    PostLogoutRedirectUris = { $"{ConfigUrl["Backend"]}/swagger/oauth2-redirect.html" },
                    AllowedCorsOrigins =     { $"{ConfigUrl["Backend"]}" },

                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "ecommercewebsite.api"
                    }
                },
            };
    }
}
