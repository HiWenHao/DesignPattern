using System;

namespace DesignPattern.FactoryMethodPattern
{
    public class SimpleFactoryMethod
    {
        public static Word GetWord(string wordName)
        {
            switch (wordName)
            {
                case "A":
                    return new A();
                case "B":
                    return new B();
                case "C":
                    return new C();
                default:
                    Console.WriteLine($"没有当前类：{wordName}");
                    return null;
            }
        }
    }

    public abstract class Word { public abstract void Name(); }

    public class A : Word { public override void Name() { Console.WriteLine("我是class A"); } }
    public class B : Word { public override void Name() { Console.WriteLine("我是class B"); } }
    public class C : Word { public override void Name() { Console.WriteLine("我是class C"); } }
}
