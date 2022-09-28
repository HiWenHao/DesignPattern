using System;

namespace DesignPattern.ChainofResponsibilityPattern
{
    public abstract class ChainofResponsibility
    {
        public abstract string Name { get; }
        public ChainofResponsibility NextChain { get; protected set; }

        public abstract void SetNext(ChainofResponsibility nextChain);
        public abstract void DisposeHandler(int number);
    }

    public class ChainofResponsibilityItem1 : ChainofResponsibility
    {
        public override string Name => "我在责任链位置：1, 我处理的数为：";



        public override void DisposeHandler(int number)
        {
            if (number <= 10)
            {
                Console.WriteLine(Name + number);
            }
            else if(null != NextChain)
            {
                NextChain.DisposeHandler(number);
            }
            else
            {
                Console.WriteLine(Name + number + ", 但这个数字无法处理");
            }
        }

        public override void SetNext(ChainofResponsibility nextChain)
        {
            NextChain = nextChain;
        }
    }
    public class ChainofResponsibilityItem2 : ChainofResponsibility
    {
        public override string Name => "我在责任链位置：2, 我处理的数为：";

        public override void DisposeHandler(int number)
        {
            if (number <= 20)
            {
                Console.WriteLine(Name + number);
            }
            else if (null != NextChain)
            {
                NextChain.DisposeHandler(number);
            }
            else
            {
                Console.WriteLine(Name + number + ", 但这个数字无法处理");
            }
        }

        public override void SetNext(ChainofResponsibility nextChain)
        {
            NextChain = nextChain;
        }
    }
    public class ChainofResponsibilityItem3 : ChainofResponsibility
    {
        public override string Name => "我在责任链位置：3, 我处理的数为：";

        public override void DisposeHandler(int number)
        {
            if (number <= 30)
            {
                Console.WriteLine(Name + number);
            }
            else if (null != NextChain)
            {
                NextChain.DisposeHandler(number);
            }
            else
            {
                Console.WriteLine(Name + number + ", 但这个数字无法处理");
            }
        }

        public override void SetNext(ChainofResponsibility nextChain)
        {
            NextChain = nextChain;
        }
    }
}
