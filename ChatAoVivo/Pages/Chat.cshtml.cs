using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace RazorPages.Pages
{

    public class Chat : PageModel
    {
        public void OnGet()
        {

            Htmlget();

        }

        [HttpGet]
        private IActionResult Htmlget()
        {
            string str = "<html><body><h1>Olá, Mundo!</h1></body></html>\"";
            return Content(str, "text/html");

        }

        public IActionResult OnPost()
        {


            return RedirectToPage("Chat");
        }

    }


}

