using System;

namespace ChatAoVivo.Pages.Models
{
    public class ImageAnalyzer
    {

        public string upload(IFormFile file)
        {

            //Extension validation for image files
            List<string> validExtensions = new List<string>() {".png", ".gif", ".jpg"};
            string extension = Path.GetExtension(file.FileName);

            if (!validExtensions.Contains(extension))
            {
                return $"The extension is not valid. The valid ones are ({string.Join(',', validExtensions)})"; 
            }

            //file size Validation
            long size = file.Length;

            if(size > (5 *1024 * 1024))
            {
                return "The file size must be below 5MB";
            }

            //name changing for safety

            string fileName = Guid.NewGuid().ToString() + extension;
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot","Images");


            //using will close the FileStream Automatically


            using FileStream stream = new FileStream(Path.Combine(path,fileName), FileMode.Create);
            file.CopyTo(stream);



            return fileName;


        }
    }
}
