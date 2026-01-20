using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ChatAoVivo.Models;
using Microsoft.AspNetCore.Mvc;
using System;


namespace RazorPages.Pages
{ 

    public class Chat: PageModel
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

