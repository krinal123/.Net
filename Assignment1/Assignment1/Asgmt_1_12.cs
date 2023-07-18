using System;

namespace Assignment1
{
    internal class Asgmt_1_12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the URL : ");
            string url = Console.ReadLine();
            string protocol = "http";
            string server = url;

            int protocolIndex = url.IndexOf("://");
            if (protocolIndex != -1)
            {
                protocol = url.Substring(0, protocolIndex);
                server = url.Substring(protocolIndex + 3);
            }

            int slashIndex = server.IndexOf('/');
            string resource = "/";
            if (slashIndex != -1)
            {
                resource = server.Substring(slashIndex);
                server = server.Substring(0, slashIndex);
            }

            Console.WriteLine($"[protocol] = {protocol}");
            Console.WriteLine($"[server] = {server}");
            Console.WriteLine($"[resource] = {resource}");

            Console.Read();
        }
    }
}
