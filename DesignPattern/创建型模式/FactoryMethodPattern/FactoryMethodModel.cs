using System;

namespace DesignPattern.FactoryMethodPattern
{
    public interface IName
    {
        Word GetWord();
    }
    public class AaFactory : IName
    {
        public Word GetWord()
        {
            return new Aa();
        }
    }
    public class BbFactory : IName
    {
        public Word GetWord()
        {
            return new Bb();
        }
    }
    public class CcFactory : IName
    {
        public Word GetWord()
        {
            return new Cc();
        }
    }
    public class DdFactory : IName
    {
        public Word GetWord()
        {
            return new Dd();
        }
    }

    public class Aa : Word { public override void Name() { Console.WriteLine("我是Aa"); } }
    public class Bb : Word { public override void Name() { Console.WriteLine("我是Bb"); } }
    public class Cc : Word { public override void Name() { Console.WriteLine("我是Cc"); } }
    public class Dd : Word { public override void Name() { Console.WriteLine("我是Dd"); } }
}
