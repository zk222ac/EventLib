using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using EventLib.model.Account;

namespace EventAPP.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public LoginInfo? UserInfo { get; set; }
        public void OnGet()
        {
            //this.UserInfo = new LoginInfo { UserName = "admin" };
        }
        public void OnPost()
        {

        }
    }
}
