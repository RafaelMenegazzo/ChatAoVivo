using ChatAoVivo.Pages.Models;
using System;


namespace ChatAoVivo.Pages.Models
{
    public class User
    {
        public string Nome {get; set;}
        public Imagem img {get; set;} = new Imagem();

        public User()
        {
            Nome = null;

        }

    }

}