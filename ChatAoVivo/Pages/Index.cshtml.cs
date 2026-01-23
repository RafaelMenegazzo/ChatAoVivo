using ChatAoVivo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;


namespace RazorPages.Pages
{
    public class Login : PageModel
    {
        [BindProperty]
        public User Us { get; set; } = new User();
        public void OnGet()

        {
           
            
        }

        [ValidateAntiForgeryToken]
        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            TempData["UserName"] = Us.Nome;

            return RedirectToPage("Chat");
        }

        private byte[] ImgConversor()
        {
            return null;
        }
    }
}