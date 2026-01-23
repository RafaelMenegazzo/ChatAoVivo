using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace RazorPages.Pages
{

    public class Chat : PageModel
    {
        public void OnGet()
        {


        }

      

        public IActionResult OnPost()
        {


            return RedirectToPage("Chat");
        }

    }


}

