namespace DesignPattern.BuilderPattern
{
    /// <summary>
    /// 有序指挥官
    /// </summary>
    public class OrderBuilderDirector
    {
        public BuilderProduct Build(OrderBuilder builder)
        {
            builder.BuildA();
            builder.BuildB();
            builder.BuildC();
            builder.BuildD();
            return builder.GetProduct();
        }
    }

    /// <summary>
    /// 无序指挥官
    /// </summary>
    public class DisorderBuilderDirector
    {
        /// <summary>
        /// 获取构建产品
        /// </summary>
        /// <param name="builder">无序工作服务者</param>
        public BuilderProduct Build(DisorderBuilder builder)
        {
            return builder.GetProduct();
        }
    }
}
