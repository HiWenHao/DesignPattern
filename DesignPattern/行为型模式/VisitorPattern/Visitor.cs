using System;

namespace DesignPattern.VisitorPattern
{
    internal abstract class Visitor        //访问者类抽象
    {
        public abstract void Chinesechef(Cooker cookers);    //抽象出  中国厨师怎么做自己
        public abstract void Westernchef(Cooker cookers);    //抽象出  西方厨师怎么做自己
    }

    internal class MeatVisitor : Visitor
    {
        public override void Chinesechef(Cooker cookers)
        {
            Console.WriteLine($"{cookers.Name}认为，肉 要煮的吃");
        }

        public override void Westernchef(Cooker cookers)
        {
            Console.WriteLine($"{cookers.Name}认为，肉 要煎的吃");
        }
    }

    internal class GetOilVisitor : Visitor
    {
        public override void Chinesechef(Cooker cookers)
        {
            Console.WriteLine($"{cookers.Name}认为，油 可以通过肉炼出来");
        }

        public override void Westernchef(Cooker cookers)
        {
            Console.WriteLine($"{cookers.Name}认为，油 应该去超市买");
        }
    }
}
