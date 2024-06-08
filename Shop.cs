
namespace ConsoleApp31
{
    internal class Shop
    {
        public string name;
        public string adr;
        public string info;
        public string phone;
        public string email;
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetAdr(string adr)
        {
            this.adr = adr;
        }
        public string GetAdr()
        {
            return adr;
        }
        public void SetInfo(string info)
        {
            this.info = info;
        }
        public string GetInfo()
        {
            return info;
        }
        public void SetPhone(string phone)
        {
            this.phone = phone;
        }
        public string GetPhone()
        {
            return phone;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public string GetEmail()
        {
            return email;
        }
        public void InputData()
        {
            Console.WriteLine("Input: ");
            SetName(Console.ReadLine());
            Console.WriteLine("Input: ");
            SetAdr(Console.ReadLine());
            Console.WriteLine("Input: ");
            SetInfo(Console.ReadLine());
            Console.WriteLine("Input: ");
            SetPhone(Console.ReadLine());
            Console.WriteLine("Input: ");
            SetEmail(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine($"Name: {GetName()}");
            Console.WriteLine($"adr: {GetAdr()}");
            Console.WriteLine($"info: {GetInfo()}");
            Console.WriteLine($"phone: {GetPhone()}");
            Console.WriteLine($"email: {GetEmail()}");
        }
    }
}
