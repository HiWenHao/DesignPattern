namespace DesignPattern.MediatorPattern
{
    /// <summary>
    /// 抽象中介者
    /// </summary>
    public abstract class Mediator
    {
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="colleague">给谁发</param>
        public abstract void Send(string message, Colleague colleague);
    }

    /// <summary>
    /// 抽象同事类
    /// </summary>
    public abstract class Colleague
    {
        //中介者
        protected Mediator m_mediator;
        protected string m_name;

        public Colleague(Mediator mediator, string name)
        {
            this.m_mediator = mediator;
            m_name = name;
        }

        public string Name => m_name;

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="message">消息内容</param>
        public abstract void Send(string message);
        /// <summary>
        /// 接受消息
        /// </summary>
        /// <param name="message">消息内容</param>
        public abstract void Notify(string message);
    }
}
