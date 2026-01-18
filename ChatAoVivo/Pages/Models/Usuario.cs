using System;

namespace models
{
    public class Usuario
    {
        
        private string UserName{ get; set;}
        private byte[]? ImageBytes{get; set;}

        public Usuario(string nome, byte[] imagem){
            UserName = "";
            ImageBytes = imagem;
        }




    }
}