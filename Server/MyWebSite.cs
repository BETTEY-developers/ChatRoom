using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
namespace Server
{
    class MyWebSite
    {
        public static void SendFile(Socket sock)
        {
            
            Stream stream = File.OpenRead("WebSiteFile-Index.html");
            byte[] head = Encoding.UTF8.GetBytes($"\"Size\":{stream.Length}");
            Thread.Sleep(1000);
            sock.Send(head, head.Length, SocketFlags.None);
            int tolSize = 0;
            while (true)
            {
                byte[] buffer = new byte[1024*8];

                tolSize += stream.Read(buffer, 0, buffer.Length);
                sock.Send(buffer, buffer.Length, SocketFlags.None);
                if (tolSize == stream.Length)
                {
                    break;
                }
                
            }
            stream.Close();
        }
    }
}
