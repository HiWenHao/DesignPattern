using System;

namespace DesignPattern.BuilderPattern
{
    /// <summary>
    /// 有序工作服务者
    /// </summary>
    public class OrderBuilderWorker : OrderBuilder
    {
        private BuilderProduct m_product;

        public OrderBuilderWorker() { m_product = new BuilderProduct(); }

        public override void BuildA()
        {
            m_product.SetBuildA("Bulider_AA");
            Console.WriteLine("有序工作者 Bulider_A 被执行");
        }

        public override void BuildB()
        {
            m_product.SetBuildB("Bulider_BB");
            Console.WriteLine("有序工作者 Bulider_B 被执行");
        }

        public override void BuildC()
        {
            m_product.SetBuildC("Bulider_CC");
            Console.WriteLine("有序工作者 Bulider_C 被执行");
        }

        public override void BuildD()
        {
            m_product.SetBuildD("Bulider_DD");
            Console.WriteLine("有序工作者 Bulider_D 被执行");
        }

        public override BuilderProduct GetProduct() { return m_product; }
    }

    /// <summary>
    /// 无序工作服务者
    /// </summary>
    public class DisorderBuilderWorker : DisorderBuilder
    {
        private BuilderProduct m_product;

        public DisorderBuilderWorker() { m_product = new BuilderProduct(); }
        public DisorderBuilderWorker(BuilderProduct product) { m_product = product; }
        public override DisorderBuilder BuildA(string builderMsg)
        {
            m_product.SetBuildA(builderMsg);
            Console.WriteLine($"无序工作者 BuildA 做出更改{builderMsg}");
            return this;
        }

        public override DisorderBuilder BuildB(string builderMsg)
        {
            m_product.SetBuildB(builderMsg);
            Console.WriteLine($"无序工作者 BuildB 做出更改{builderMsg}");
            return this;
        }

        public override DisorderBuilder BuildC(string builderMsg)
        {
            m_product.SetBuildC(builderMsg);
            Console.WriteLine($"无序工作者 BuildC 做出更改{builderMsg}");
            return this;
        }

        public override DisorderBuilder BuildD(string builderMsg)
        {
            m_product.SetBuildD(builderMsg);
            Console.WriteLine($"无序工作者 BuildD 做出更改{builderMsg}");
            return this;
        }

        public override BuilderProduct GetProduct() { return m_product; }
    }
}
