namespace DesignPattern.CommandPattern
{
    /// <summary>
    /// 调用命令者，绑定一个命令，并执行该命令。
    /// </summary>
    internal class Invoker
    {
        private ICommand m_command;

        public void SetCommand(ICommand command)
        {
            this.m_command = command;
        }

        public void ExecuteCommand()
        {
            m_command.Exrcute();
        }
    }
}
