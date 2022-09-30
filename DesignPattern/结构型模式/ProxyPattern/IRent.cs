using System;

namespace DesignPattern.ProxyPattern
{
    /// <summary>
    /// 出租接口
    /// </summary>
    internal interface IRent
    {
        /// <summary>
        /// 出租房子
        /// </summary>
        void Renting();
    }

    /// <summary>
    /// 房东
    /// </summary>
    public class Landlord : IRent
    {
        public void Renting()
        {
            Console.WriteLine("我是房东，要出租房子。我已经把钥匙交给了中介。");
        }
    }
}
