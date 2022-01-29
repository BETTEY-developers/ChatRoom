using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Text;
using System.Diagnostics;

namespace Server
{ 
    public class UserInfo
    {
        public string Name { get; set; }
        public string Guid { get; set; }
        public string IP { get; set; }
    }

    public class Message
    {
        public string Guid { get; set; }
        public string Msg { get; set; }
        public string IsFile { get; set; }
    }
    public class Server
    {
        Socket cs = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        List<UserInfo> userInfos = new List<UserInfo>();
        List<Socket> sockets = new List<Socket>();

        public Server()
        {

        }

        public void Start()
        {
            cs.Bind(new IPEndPoint(IPAddress.Any, 13002));
            cs.Listen(10);

            Thread thr = new Thread(Acc);
            thr.IsBackground = false;
            thr.Start();
        }

        private void Acc()
        {
            try
            {
                Socket acc = cs.Accept();
                byte[] msg = new byte[1024 * 500];
                int len = acc.Receive(msg);
                string str = Encoding.Default.GetString(msg, 0, len);
                userInfos.Add((UserInfo)JsonSerializer.Deserialize(str, typeof(UserInfo)));
                sockets.Add(acc);
                Console.WriteLine($"[{Now()}] {userInfos[userInfos.Count - 1].Name} 进入聊天室");
                BoradClient(userInfos[userInfos.Count - 1].Name + " 进入聊天室");
                Thread rcMsg = new Thread(ReceMsg);
                rcMsg.IsBackground = false;
                rcMsg.Start(acc);
            }
            catch { }
            Acc();
        }
        public string Now()
        {
            return DateTime.Now.ToString();
        }
        private void ReceMsg(object objects)
        {
            try
            {
                Socket socket = objects as Socket;
                byte[] msg = new byte[0x7FFF];
                int len = socket.Receive(msg);
                string str = Encoding.Default.GetString(msg, 0, len);
                string fm = "";
                if (!str.StartsWith("Exit:"))
                {
                    Message msgs = (Message)JsonSerializer.Deserialize(str, typeof(Message));
                    foreach (UserInfo info in userInfos)
                    {
                        if (info.Guid == msgs.Guid)
                        {
                            Console.WriteLine("[" + Now() + "]" + info.Name + ":" + msgs.Msg);
                            fm = info.Name + ":" + msgs.Msg;
                        }
                    }
                }
                else
                {
                    UserInfo reinfo = new();
                    foreach (UserInfo info in userInfos)
                    {
                        if (info.Guid == str.Replace("Exit:",""))
                        {
                            Console.WriteLine("[" + Now() + "] " + info.Name + " 退出聊天室");
                            fm = info.Name + " 退出聊天室";
                            reinfo = info;
                        }
                    }
                    userInfos.Remove(reinfo);
                    sockets.Remove(socket);
                    socket.Close();
                    BoradClient(fm);
                    return;
                }
                BoradClient(fm);
                ReceMsg(socket);
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Error] " + ex.Message);
                Process.GetCurrentProcess().Kill();
            }

        }

        private void BoradClient(string str)
        {
            foreach(Socket socket in sockets)
            {
                socket.Send(Encoding.UTF8.GetBytes(str));
            }
        }
    }
    public class Program
    {
        static public void Main()
        {
            try
            {
                Server server = new Server();
                server.Start();
            }
            catch (SocketException ex)
            {
                Console.WriteLine("[Error]:" + ex.Message + "\n" + ex.StackTrace + "\n" + ex.ErrorCode);
                Console.ReadLine();
            }
        }
    }
}