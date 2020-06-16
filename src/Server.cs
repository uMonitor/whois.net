namespace WhoIs
{
    public class Server
    {
        public string Hostname {get; private set;}
        public uint Port {get; set;}

        public Server(string hostname, uint port)
        {
            Hostname = hostname;
            Port = port;
        }

        public void Connect()
        {
            int timeout = 5000;
            
            using (var client = new TcpClient())
            using (var netstream = client.GetStream()) 
            using (var writer = new StreamWriter(netstream))
            using (var reader = new StreamReader(netstream)) 
            {
                await client.ConnectAsync(Hostname, Port);
                
                writer.AutoFlush = true;
                netstream.ReadTimeout = timeout;

    // Write a message over the TCP Connection
    string message = "Hello World!";
    await writer.WriteLineAsync(message);
    
    // Read server response
    string response = await reader.ReadLineAsync();
    Console.WriteLine(string.Format($"Server: {response}"));                

            }
{

        }
    }
}