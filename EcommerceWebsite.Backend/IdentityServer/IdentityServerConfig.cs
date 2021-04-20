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

        public static IEnumerable<Client> Clients =>
            new List<Client>
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

                    RedirectUris = { "https://vtpshop-client.azurewebsites.net/signin-oidc" },

                    PostLogoutRedirectUris = { "https://vtpshop-client.azurewebsites.net/signout-callback-oidc" },

                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "ecommercewebsite.api"
                    }
                },

                new Client
                {
                    ClientName = "react_client",
                    ClientId = "react_client",
                    AllowedGrantTypes = GrantTypes.Code,
                    AllowAccessTokensViaBrowser = true,

                    RequireClientSecret = false,
                    RequireConsent = false,
                    RequirePkce = true,

                    RedirectUris = new List<string>
                    {
                        $"http://localhost:3000/authentication/login-callback",
                        $"http://localhost:3000/silent-renew.html",
                        $"http://localhost:3000"
                    },
                    PostLogoutRedirectUris = new List<string>
                    {
                        $"http://localhost:3000/unauthorized",
                        $"http://localhost:3000/authentication/logout-callback",
                        $"http://localhost:3000"
                    },
                    AllowedCorsOrigins = new List<string>
                    {
                        $"http://localhost:3000"
                    },
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

                    RedirectUris =           { $"https://vtpshop.azurewebsites.net/swagger/oauth2-redirect.html" },
                    PostLogoutRedirectUris = { $"https://vtpshop.azurewebsites.net/swagger/oauth2-redirect.html" },
                    AllowedCorsOrigins =     { $"https://vtpshop.azurewebsites.net/" },

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
