using System;
using Microsoft.AspNetCore.Mvc;

namespace ChatAoVivo.Controllers
{
    
    public class MessageController : Controller{


        public IActionResult ShowMessages()
        {
            return View();
        }
        
    }


}