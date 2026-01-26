using ChatAoVivo.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;


namespace RazorPages.Pages
{
    public class Login : PageModel
    {

        private ILogger<Login> _logger;
        [BindProperty]
        public User Us { get; set; } = new User();


        public Login(ILogger<Login> logger)
        {
            _logger = logger;
        }
        public void OnGet()

        {
           
            
        }

        [ValidateAntiForgeryToken]
        public IActionResult OnPost()
        {
            //This command will upload the image and return the name of the image inside the object User.img
            Us.img.ImageName = new ImageAnalyzer().upload(Us.img.ImageFile);
            TempData["UserName"] = Us.img.ImageName;

            return RedirectToPage("Chat");
        }

        private byte[] ImgConversor()
        {
            return null;
        }
    }
}