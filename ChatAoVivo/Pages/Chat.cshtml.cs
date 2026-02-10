using ChatAoVivo.Pages.Models;
using ChatAoVivo.Pages.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;
using System.Text.Json;


namespace RazorPages.Pages
{

    public class Chat : PageModel
    {

        public void OnGet()
        {
            ServerConect.Conectar();

        }


        public void salvarMensagens()
        {
            Message msg = new Message();

            msg.Msg = Request.Form["message"];
            msg.user.Nome = (string)TempData["UserName"];
            msg.user.img.ImageName = (string)TempData["UserImg"];
            msg.SendDate = DateTime.Now;

            System.Diagnostics.Debug.WriteLine("Mensagem recebida: " + msg.Msg +"//" + msg.user.Nome);

            ListaSingleton lista = ListaSingleton.getInstance();
            lista.mensagens.Add(msg);


            TempData["Mensagens"] = JsonConvert.SerializeObject(lista.mensagens);
        }


        public IActionResult OnPost()
        {

            salvarMensagens();

            return RedirectToPage("Chat");
        }

    }


}

