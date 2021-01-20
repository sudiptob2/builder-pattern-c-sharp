using System;

namespace Evatix
{
    class Phone
    {
        public int battery;
        public int screenSize;
        public string os;

        public string GetSpec()
        {
            return "Battery : " + battery.ToString() + "\nScreen : " + screenSize.ToString() + "\nOperating System : " + os;
        }


    }
    class PhoneBuilder
    {
        Phone phone;

        public PhoneBuilder(Phone phone)
        {
            this.phone = phone;
        }
        public PhoneBuilder SetBattery(int capacity)
        {
            phone.battery = capacity;
            return this;
        }
        public PhoneBuilder SetOS(string os)
        {
            phone.os = os;
            return this;
        }
        public PhoneBuilder SetSceenSize(int screenSize)
        {
            phone.battery = screenSize;
            return this;
        }
        public Phone GetPhone()
        {
            return phone;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBuilder pb = new PhoneBuilder(new Phone());
            Phone myPhone = pb.SetBattery(2000).SetSceenSize(5).SetOS("Android").GetPhone();
            Console.WriteLine(myPhone.GetSpec());
        }
    }
}
