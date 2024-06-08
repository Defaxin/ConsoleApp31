
namespace ConsoleApp31
{
    internal class Magazine
    {
        public string name;
        public string date;
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
        public void SetDate(string date)
        {
            this.date = date;
        }
        public string GetDate()
        {
            return date;
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
            SetDate(Console.ReadLine());
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
            Console.WriteLine($"Date: {GetDate()}");
            Console.WriteLine($"Info: {GetInfo()}");
            Console.WriteLine($"Phone: {GetPhone()}");
            Console.WriteLine($"Email: {GetEmail()}");
        }
    }
}
