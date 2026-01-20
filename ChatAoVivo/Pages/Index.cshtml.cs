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

        [ValidateAntiForgeryToken]
        public IActionResult OnPost()
        {
            Console.WriteLine("Nome: " + user?.nome);
             
            return RedirectToPage("Chat");
        }

        private byte[] ImgConversor()
        {
            return null;
        }
    }
}