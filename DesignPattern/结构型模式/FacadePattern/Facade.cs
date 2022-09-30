using System;

namespace DesignPattern.FacadePattern
{
    /// <summary>
    /// 外观接口
    /// </summary>
    internal interface IFacade
    {
        /// <summary>
        /// 打开
        /// </summary>
        void Open();

        /// <summary>
        /// 关闭
        /// </summary>
        void Close();
    }

    /// <summary>
    /// 窗户
    /// </summary>
    public class Window : IFacade
    {
        public void Close()
        {
            Console.WriteLine("关闭窗户");
        }

        public void Open()
        {
            Console.WriteLine("打开窗户");
        }
    }

    /// <summary>
    /// 无线网络
    /// </summary>
    public class Wifi : IFacade
    {
        public void Close()
        {
            Console.WriteLine("关闭Wifi");
        }

        public void Open()
        {
            Console.WriteLine("打开Wifi");
        }
    }

    /// <summary>
    /// 闹钟
    /// </summary>
    public class Alarm : IFacade
    {
        public void Close()
        {
            Console.WriteLine("关闭闹铃");
        }

        public void Open()
        {
            Console.WriteLine("打开闹铃");
        }
    }
}