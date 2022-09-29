namespace DesignPattern.CommandPattern
{
    /// <summary>
    /// 命令，需要执行的所有命令都在这里声明。
    /// </summary>
    internal interface ICommand
    {
        /// <summary>
        /// 发布命令
        /// </summary>
        void Exrcute();
    }
}
