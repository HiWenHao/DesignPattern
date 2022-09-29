namespace DesignPattern.CommandPattern
{
    /// <summary>
    /// 一个具体的命令
    /// </summary>
    internal class ConcreteCommand : ICommand
    {
        Receiver m_receiver;
        /// <summary>
        /// 一个具体的命令，将一个接收者绑定，调用接收者相应的操作，以实现执行命令。
        /// </summary>
        public ConcreteCommand(Receiver receiver)
        {
            this.m_receiver = receiver;
        }

        public void Exrcute()
        {
            m_receiver.Function();
        }
    }
}
