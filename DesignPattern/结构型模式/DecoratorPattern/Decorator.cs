namespace DesignPattern.DecoratorPattern
{
    /// <summary>
    /// 抽象饮品装饰者类
    /// </summary>
    public abstract class DrinkDecorator
    {
        /// <summary>
        /// 名字
        /// </summary>
        protected string Name { get; set; }

        /// <summary>
        /// 售价
        /// </summary>
        protected int Price { get; set; }

        /// <summary>
        /// 介绍:名字
        /// </summary>
        public abstract string Des { get; }

        /// <summary>
        /// 售价
        /// </summary>
        public abstract int Cost { get; }
    }

    /// <summary>
    /// 汽水
    /// </summary>
    public class SodaWater : DrinkDecorator
    {
        public SodaWater()
        {
            Name = "汽水";
            Price = 8;
        }

        public override string Des => this.Name;
        public override int Cost => this.Price;
    }

    /// <summary>
    /// 咖啡
    /// </summary>
    public class Coffee : DrinkDecorator
    {
        public Coffee()
        {
            Name = "咖啡";
            Price = 15;
        }

        public override string Des => this.Name;
        public override int Cost => this.Price;
    }

    /// <summary>
    /// 果汁
    /// </summary>
    public class Syrup: DrinkDecorator
    {
        public Syrup()
        {
            Name = "果汁";
            Price = 12;
        }

        public override string Des => this.Name;
        public override int Cost => this.Price;
    }
}
