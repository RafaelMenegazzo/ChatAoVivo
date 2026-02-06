namespace ChatAoVivo.Pages.Models
{
    public class ListaSingleton
    {

        public static ListaSingleton instancia = null;

        public List<Message> mensagens = new List<Message>();

        public static ListaSingleton getInstance()
        {
            if(instancia == null)
            {
                instancia = new ListaSingleton();
            }
            return instancia;
        }





    }
}
