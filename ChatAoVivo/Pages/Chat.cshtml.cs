using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ChatAoVivo.Pages.Models;
using Newtonsoft.Json;
using System;
using System.Text.Json;


namespace RazorPages.Pages
{

    public class Chat : PageModel
    {
        List<Message> mensagens = new List<Message>();
        public void OnGet()
        {


        }



        public IActionResult OnPost()
        {
            Message msg = new Message();

            msg.Msg = Request.Form["msg"];
            msg.user.Nome = (string)TempData["username"];
            msg.user.img.ImageName = (string)TempData["userimg"];
            msg.SendDate = DateTime.Now;

            mensagens.Add(msg);

            TempData["Mensagens"] = JsonConvert.SerializeObject(mensagens);

            return RedirectToPage("Chat");
        }

    }


}

