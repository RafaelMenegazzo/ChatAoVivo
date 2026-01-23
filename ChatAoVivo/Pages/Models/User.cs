using System;


namespace ChatAoVivo.Models
{
    public class User
    {
        public string Nome{get; set;}
        public IFormFile ProfileImage { get; set; }
        public byte[]? ProfilePhoto{get; set;}
    }
}