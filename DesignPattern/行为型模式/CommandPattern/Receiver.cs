using System;

namespace DesignPattern.CommandPattern
{
    /// <summary>
    /// 命令接收者、执行者。  任何类都可以成为接收者
    /// </summary>
    internal class Receiver
    {
        public void Function()
        {
            Console.WriteLine("接收者接到命令，并且执行了");
        }
    }
}
