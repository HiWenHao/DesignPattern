using System;

namespace DesignPattern.AbstractFactoryPattern
{
    public interface IRouterProduct
    {
        void Start();
        void Shutdown();
        void OpenWife();
        void Setting();
    }

    public class XiaomiRouter : IRouterProduct
    {
        public void OpenWife() { Console.WriteLine("Xiaomi OpenWife"); }
        public void Setting() { Console.WriteLine("Xiaomi Setting"); }
        public void Shutdown() { Console.WriteLine("Xiaomi Shutdown"); }
        public void Start() { Console.WriteLine("Xiaomi Start"); }
    }

    public class HuaweiRouter : IRouterProduct
    {
        public void OpenWife() { Console.WriteLine("Huawei OpenWife"); }
        public void Setting() { Console.WriteLine("Huawei Setting"); }
        public void Shutdown() { Console.WriteLine("Huawei Shutdown"); }
        public void Start() { Console.WriteLine("Huawei Start"); }
    }
}
