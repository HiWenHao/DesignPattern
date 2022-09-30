using System;

namespace DesignPattern.TemplateMethodPattern
{
    public abstract class TemplateMethod
    {
        public void HaveDrank()
        {
            By();
            OpenBottleCap();
            Drinking();
            CloseBottleCap();

        }
        protected abstract void By();

        private void OpenBottleCap()
        {
            Console.WriteLine("打开瓶盖.");
        }

        private void Drinking()
        {
            Console.WriteLine("喝一口.");
        }

        private void CloseBottleCap()
        {
            Console.WriteLine("合上瓶盖.");
        }
    }

    public class Cola : TemplateMethod
    {
        protected override void By()
        {
            Console.WriteLine("买一瓶可乐.");
        }
    }
    public class Juice : TemplateMethod
    {
        protected override void By()
        {
            Console.WriteLine("买一瓶果汁.");
        }
    }
}
