namespace DesignPattern.VisitorPattern
{
    internal abstract class Cooker        //厨师抽象类
    {
        public string Name;     //厨师
        public abstract void Cooking(Visitor visitors);    //抽象出做东西    参数：做的内容（访问者）
    }

    internal class ChineseChef : Cooker
    {
        public override void Cooking(Visitor visitors)
        {
            Name = "中国厨师";
            visitors.Chinesechef(this);
        }
    }

    internal class WesternChef : Cooker
    {
        public override void Cooking(Visitor visitors)
        {
            Name = "西方厨师";
            visitors.Westernchef(this);
        }
    }
}
