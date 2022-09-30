using System;

namespace DesignPattern.ProxyPattern
{
    /// <summary>
    /// 出租的静态代理
    /// </summary>
    public class RentStaticProxy : IRent
    {
        private Landlord landlord;

        public RentStaticProxy(Landlord landlord)
        {
            this.landlord = landlord;
        }

        public void Renting()
        {
            GetRentInfo();
            landlord.Renting();
            SeeHouse();
            SetCntract();
            GetFare();
        }

        public void GetRentInfo()
        {
            Console.WriteLine("中介得到你需要租房。并开始搜寻已代理的房源信息");
        }
        public void SeeHouse()
        {
            Console.WriteLine("中介带你看这个房子");
        }

        public void SetCntract()
        {
            Console.WriteLine("签租赁合同");
        }
        public void GetFare()
        {
            Console.WriteLine("中介收中介费");
        }
    }
}
