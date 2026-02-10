using System;
using System.Net;
using System.Net.Sockets;

namespace ChatAoVivo.Pages.Server
{
    public static class ServerConect
    {
       
        public static void Conectar()
        {
            TcpListener server = new TcpListener(IPAddress.Parse("127.0.0.1"), 7001);
            server.Start();

            System.Diagnostics.Debug.WriteLine("Servidor iniciado. Aguardando conexões...");
           

        }


    }
}
