using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using EcommerceWebsite.Backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using IdentityServer4.Services;

namespace EcommerceWebsite.Backend.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LogoutModel : PageModel
    {
        private readonly IIdentityServerInteractionService _interaction; //*Add
        private readonly SignInManager<User> _signInManager;
        private readonly ILogger<LogoutModel> _logger;

        public LogoutModel(SignInManager<User> signInManager, ILogger<LogoutModel> logger, IIdentityServerInteractionService interaction)
        {
            _interaction = interaction;
            _signInManager = signInManager;
            _logger = logger;
        }


        [BindProperty] //*Add
        public InputModel Input { get; set; }

        public class InputModel //*Add
        {
            [Required]
            public string LogoutId { get; set; }           
        }

        public void OnGet(string logoutid) //*Modified
        {
            Input = new InputModel { LogoutId = logoutid };
        }

        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
            var logout = await _interaction.GetLogoutContextAsync(Input.LogoutId);

            if(logout!=null && !string.IsNullOrWhiteSpace(logout.PostLogoutRedirectUri))
            {
                return Redirect(logout.PostLogoutRedirectUri);
            }
            if (returnUrl != null)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}
