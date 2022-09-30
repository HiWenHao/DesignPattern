namespace DesignPattern.BuilderPattern
{
    /// <summary>
    /// 有序工作服务者基类，客服按步骤流程来
    /// </summary>
    public abstract class OrderBuilder
    {
        /// <summary>
        /// 执行步骤A
        /// </summary>
        public abstract void BuildA();
        /// <summary>
        /// 执行步骤B
        /// </summary>
        public abstract void BuildB();
        /// <summary>
        /// 执行步骤C
        /// </summary>
        public abstract void BuildC();
        /// <summary>
        /// 执行步骤D
        /// </summary>
        public abstract void BuildD();

        /// <summary>
        /// 获取产品
        /// </summary>
        public abstract BuilderProduct GetProduct();
    }

    /// <summary>
    /// 无序工作服务者基类，按照客户要求来
    /// </summary>
    public abstract class DisorderBuilder
    {
        /// <summary>
        /// 修改步骤A
        /// </summary>
        /// <param name="builderMsg">要修改为</param>
        /// <returns>返回自身</returns>
        public abstract DisorderBuilder BuildA(string builderMsg);
        /// <summary>
        /// 修改步骤B
        /// </summary>
        /// <param name="builderMsg">要修改为</param>
        /// <returns>返回自身</returns>
        public abstract DisorderBuilder BuildB(string builderMsg);
        /// <summary>
        /// 修改步骤C
        /// </summary>
        /// <param name="builderMsg">要修改为</param>
        /// <returns>返回自身</returns>
        public abstract DisorderBuilder BuildC(string builderMsg);
        /// <summary>
        /// 修改步骤D
        /// </summary>
        /// <param name="builderMsg">要修改为</param>
        /// <returns>返回自身</returns>
        public abstract DisorderBuilder BuildD(string builderMsg);

        /// <summary>
        /// 获取产品
        /// </summary>
        public abstract BuilderProduct GetProduct();
    }
}
