using System;

namespace DesignPattern.AbstractFactoryPattern
{
    public interface IPhoneProduct
    {
        void Start();
        void Shutdown();
        void CallUp();
        void SendSMS();
    }

    public class XiaomiPhone : IPhoneProduct
    {
        public void CallUp() { Console.WriteLine("Xiaomi CallUp"); }
        public void SendSMS() { Console.WriteLine("Xiaomi SendSMS"); }
        public void Shutdown() { Console.WriteLine("Xiaomi Shutdown"); }
        public void Start() { Console.WriteLine("Xiaomi Start"); }
    }

    public class HuaweiPhone : IPhoneProduct
    {
        public void CallUp() { Console.WriteLine("Huawei CallUp"); }
        public void SendSMS() { Console.WriteLine("Huawei SendSMS"); }
        public void Shutdown() { Console.WriteLine("Huawei Shutdown"); }
        public void Start() { Console.WriteLine("Huawei Start"); }
    }
}
