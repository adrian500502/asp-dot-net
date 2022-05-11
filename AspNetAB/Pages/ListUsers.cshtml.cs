using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetAB.Pages
{
    [Authorize(Roles = "admin,developer")]
    public class ListUsersModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
