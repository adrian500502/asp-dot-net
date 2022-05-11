using AspNetAB.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace AspNetAB.Pages
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> signInManager;

        [BindProperty]
        public Login Model { get; set; }

        public LoginModel(SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(/*string returnUrl = null*/)
        {
            if (ModelState.IsValid)
            {
                var identityResult = await signInManager.PasswordSignInAsync(Model.Email, Model.Password, Model.RememberMe, false);
                if (identityResult.Succeeded)
                {
                    return RedirectToPage("/Movies/Index");
                    //if (returnUrl == null || returnUrl == "/")
                    //{
                    //    return RedirectToPage("/Movies/Index");
                    //}
                    //else
                    //{
                    //    return RedirectToPage(returnUrl);
                    //}
                }

                ModelState.AddModelError("", "Nazwa u�ytkownika albo has�o s� niepoprawne!");
            }

            return Page();
        }
    }
}
