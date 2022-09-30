using System;

namespace DesignPattern.AdapterPattern
{
    /// <summary>
    /// 用USB上网接口
    /// </summary>
    public interface INetToUsb
    {
        void HandleRequest();
    }

    //类适配器
    public class Adapter1 : Reticle, INetToUsb
    {
        public void HandleRequest()
        {
            base.Request();
            Console.WriteLine("已经可以上网了1111111");
        }
    }

    //对象适配器
    public class Adapter2 : INetToUsb
    {
        private Reticle reticle;
        public Adapter2(Reticle reticle)
        {
            this.reticle = reticle;
        }
        public void HandleRequest()
        {
            reticle.Request();
            Console.WriteLine("已经可以上网了2222222");
        }
    }

    /// <summary>
    /// 电脑
    /// </summary>
    public class Computer
    {
        /// <summary>
        /// 上网
        /// </summary>
        /// <param name="adapter">USB适配器</param>
        public void Net(INetToUsb adapter)
        {
            adapter.HandleRequest();
        }
    }

    /// <summary>
    /// 网线
    /// </summary>
    public class Reticle
    {
        public void Request()
        {
            Console.WriteLine("用网线上网");
        }
    }
}
