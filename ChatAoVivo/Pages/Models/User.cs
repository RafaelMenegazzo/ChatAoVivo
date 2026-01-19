using System;


namespace ChatAoVivo.Models
{
    public class User
    {
        public string? nome{get; set;}
        public IFormFile profileImage { get; set; }
        public byte[]? profilePhoto{get; set;}
    }
}