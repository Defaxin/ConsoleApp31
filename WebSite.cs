
namespace ConsoleApp31
{
    internal class WebSite
    {
        public string name;
        public string url;
        public string descr;
        public string ip;
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetUrl(string url)
        {
            this.url = url;
        }
        public string GetUrl()
        {
            return url;
        }
        public void SetDescr(string description)
        {
            this.descr = description;
        }
        public string GetDescr()
        {
            return descr;
        }
        public void SetIp(string ipAddress)
        {
            this.ip = ipAddress;
        }
        public string GetIp()
        {
            return ip;
        }
        public void InputData()
        {
            Console.WriteLine("Input: ");
            SetName(Console.ReadLine());
            Console.WriteLine("Input: ");
            SetUrl(Console.ReadLine());
            Console.WriteLine("Input: ");
            SetDescr(Console.ReadLine());
            Console.WriteLine("Input: ");
            SetIp(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine($"Name: {GetName()}");
            Console.WriteLine($"URL: {GetUrl()}");
            Console.WriteLine($"Discrip: {GetDescr()}");
            Console.WriteLine($"IP: {GetIp()}");
        }
    }
}
