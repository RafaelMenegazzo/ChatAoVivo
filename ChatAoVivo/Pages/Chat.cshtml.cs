using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ChatAoVivo.Pages.Models;
using System.Text.Json;


namespace RazorPages.Pages
{

    public class Chat : PageModel
    {
        List<Message> mensagens = new List<Message>();
        public void OnGet()
        {

        }


        public void salvarMensagens()
        {
            Message msg = new Message();

            msg.Msg = Request.Form["message"];
            msg.user.Nome = (string)TempData["UserName"];
            msg.user.img.ImageName = (string)TempData["UserImg"];
            msg.SendDate = DateTime.Now;

            System.Diagnostics.Debug.WriteLine("Mensagem recebida: " + msg.Msg +"//" + msg.user.Nome);


            mensagens.Add(msg);

            TempData["Mensagens"] = JsonSerializer.Serialize<Message>(msg);
        }


        public IActionResult OnPost()
        {

            salvarMensagens();
            return RedirectToPage("Chat");
        }

    }


}

