using System;
using System.Net;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Collections.Generic;

namespace Network_Programming
{
    class Network_Programming_Fundamentals
    {
        public static void SocketDemo()
        {
			/* socket programming using Telnet*/

            Socket ls = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress iPAddress = IPAddress.Any;
            IPEndPoint ipep = new IPEndPoint(iPAddress, 23000);

            ls.Bind(ipep);
            ls.Listen(5);
            ls.Accept();
        }
        public static void ConfigurationDemo()
        {
			log4net.ILog log = log4net.LogManager.GetLogger(typeof(Network_Programming_Fundamentals));

            /* How to find IP Address & LoopBack in network programming  */

            IPAddress ipa = IPAddress.Parse("192.168.1.10");

            log.Info("IP address is=" + ipa.ToString());
            log.Info("IP address is=" + IPAddress.Loopback.ToString());
            log.Info("Broadcast address is=" + IPAddress.Broadcast.ToString());
        }
	
		/* HTTP Get and Post request using HttpClient */

		async static void getRequestData(string url)
		{
			using (HttpClient myClient = new HttpClient())
			{
				using (HttpResponseMessage response = await myClient.GetAsync(url)) // Get Request
				{
					using (HttpContent content = response.Content)
					{
						log4net.ILog log = log4net.LogManager.GetLogger(typeof(Network_Programming_Fundamentals));

						string mycontent = await content.ReadAsStringAsync();
						log.Info(mycontent);
						
						// HttpContentHeaders headers = content.Headers; // with the help of we can find only header content 
						// log.Info(headers);
					}

				}
			}
		}
		async static void PostRequestData(string url)
		{
			IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
			{
				new KeyValuePair<string,string> ("query1","jay"),
				new KeyValuePair<string,string> ("query2","ajay")
			};

			HttpContent httpcontent = new FormUrlEncodedContent(queries);

			using (HttpClient myClient = new HttpClient())
			{
				using (HttpResponseMessage response = await myClient.PostAsync(url, httpcontent)) // POST Request
				{
					using (HttpContent content = response.Content)
					{
						log4net.ILog log = log4net.LogManager.GetLogger(typeof(Network_Programming_Fundamentals));

						string mycontent = await content.ReadAsStringAsync();
						log.Info(mycontent);
					}
				}
			}
		}
		static void Main(string[] args)
		{
			log4net.Config.BasicConfigurator.Configure();

			SocketDemo();

			ConfigurationDemo();
			
			Network_Programming_Fundamentals.getRequestData("https://www.google.co.in");
		   
			Network_Programming_Fundamentals.PostRequestData("http://php.net/manual/en/language.types.array.php");

			Console.ReadKey();
		}
	}
}

/* How to send data from Client to Server */

ClientDemo1.cs

namespace ClientApplication1
{
    class ClientDemo1
    {
        static Socket skt;

        static void Main(string[] args)
        {
            skt = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);// it used for connection
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"),1234);

            try
            {
                skt.Connect(ipep);
            }
            catch
            {
                Console.WriteLine("enable to connet EndPoint");
                Main(args);
            }

            Console.Write("Enter the Text :->");
            
			string text = Console.ReadLine();
            byte[] data = Encoding.ASCII.GetBytes(text);
            skt.Send(data);
            
			Console.WriteLine("data has been sent");
            skt.Close();
            
			Console.ReadKey();
        }
    }
}

ServerDemo1.cs

namespace ServerApplication
{
    class ServerDemo1
    {
        static byte[] buffer { get; set; }
        static Socket skt;

        static void Main(string[] args)
        {
            skt = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);

            skt.Bind(ipep);
            skt.Listen(100);
            
			Socket accepted = skt.Accept();
            buffer = new byte[accepted.SendBufferSize];
            
			int bytesread = accepted.Receive(buffer);
            byte[] formated = new byte[bytesread];
            
			for (int i = 0; i < bytesread; i++)
            {
                formated[i] = buffer[i];
            }
            
			string strdata = Encoding.ASCII.GetString(formated);
            
			Console.WriteLine(strdata );
            
			skt.Close();
            accepted.Close();

            Console.ReadKey();
        }
    }
}

/* How to send data from Client to Server and How server response to particular Client Request */

ClientDemo2.cs

namespace ClientApplication2
{
    class ClientDemo2
    {
	    static void Main(string[] args)
        {
            Socket skt = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1994); // it is combination of IP + Port address 

            skt.Connect(ipep); // once a socket is connected to an end point, sending data initiates a message that the other point is then able to receive.
            Console.Write("Enter the MSg:->");
            
			string msg = Console.ReadLine();
            byte[] msgbuffer = Encoding.Default.GetBytes(msg);

            skt.Send(msgbuffer, 0, msgbuffer.Length, 0);// once a socket is connected to an end point, sending data initiates a message that the other point is then able to receive.
            
			byte [] buffer = new byte[255];
            int rec = skt.Receive(buffer, 0, buffer.Length, 0);
            Array.Resize(ref buffer, rec);
            
			Console.WriteLine("recived {0}", Encoding.Default.GetString(buffer));
            
			skt.Close();

            Console.ReadKey();
        }
    }
}

ServerDemo2.cs

namespace ServerApplication2
{
    class ServerDemo2
    {
        static void Main(string[] args)
        {
            Socket skt = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            skt.Bind(new IPEndPoint(0, 1994)); // Servers must bind a socket to an address to establish a local name

            skt.Listen(0); // 
            Socket accept = skt.Accept(); // A socket accepts an incoming request by leaving a new socket, that can be used to read and write to the client.
            
			byte[] buffer = Encoding.Default.GetBytes("Hie client");
            accept.Send(buffer, 0, buffer.Length, 0);
            
			buffer = new byte[255];
            int rec = accept.Receive(buffer, 0, buffer.Length, 0);
			Array.Resize(ref buffer, rec);
            
			Console.WriteLine("recived :->", Encoding.Default.GetString(buffer));
            skt.Close();
            accept.Close();// when a connection has finished its session, a socket must be closed that releases all the resources held by the socket.
            
			Console.ReadKey();
        }
    }
}