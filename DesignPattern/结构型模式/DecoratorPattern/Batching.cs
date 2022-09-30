namespace DesignPattern.DecoratorPattern
{
    /// <summary>
    /// 配料
    /// </summary>
    public abstract class Batching : DrinkDecorator
    {
        protected readonly DrinkDecorator m_drink;
        public Batching(DrinkDecorator drink)
        {
            m_drink = drink;
        }
        public override string Des => $"{m_drink.Des} + {this.Name}";
        public override int Cost => m_drink.Cost + Price;
    }
    public class Sugar : Batching
    {
        public Sugar(DrinkDecorator drink) : base(drink)
        {
            Name = "糖";
            Price = 2;
        }
    }
    public class Ice : Batching
    {
        public Ice(DrinkDecorator drink) : base(drink)
        {
            Name = "冰块";
            Price = 1;
        }
    }

    public class Mint : Batching
    {
        public Mint(DrinkDecorator drink) : base(drink)
        {
            Name = "薄荷";
            Price = 3;
        }
    }
}
