using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatAoVivo.Pages.Models
{
    public class Imagem
    {

        public string ImageName { get; set; }
        public IFormFile ImageFile { get; set; }

        public Imagem()
        {
            ImageName = null;
            ImageFile = null;
        }
    }
}
