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
        public User? user{get;set;}
        public void OnGet()
        {

            
        }

        public IActionResult OnPost()
        {
            

            return RedirectToPage("Message");
        }

        private byte[] ImgConversor()
        {
            return null;
        }
    }
}