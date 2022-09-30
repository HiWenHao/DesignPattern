using System;

namespace DesignPattern.BridgePattern
{
    /// <summary>
    /// 产品抽象类
    /// </summary>
    public abstract class Goods
    {
        protected BridgeBrand brand;

        public Goods(BridgeBrand brand)
        {
            this.brand = brand;
        }

        /// <summary>
        /// 产品信息
        /// </summary>
        public abstract void Info();
    }

    public class GoodIPad : Goods
    {
        public GoodIPad(BridgeBrand brand) : base(brand)
        {
            this.brand = brand;
        }
        public override void Info()
        {
            Console.WriteLine($"这是 {brand.BrandInfo} 家的 - iPad");
        }
    }
    public class GoodComputer : Goods
    {
        public GoodComputer(BridgeBrand brand) : base(brand)
        {
            this.brand = brand;
        }
        public override void Info()
        {
            Console.WriteLine($"这是 {brand.BrandInfo} 家的 - Computer");
        }
    }
    public class GoodPhone : Goods
    {
        public GoodPhone(BridgeBrand brand) : base(brand)
        {
            this.brand = brand;
        }
        public override void Info()
        {
            Console.WriteLine($"这是 {brand.BrandInfo} 家的 - Phone");
        }
    }
}
