using System;

namespace DesignPattern.MediatorPattern
{
    /// <summary>
    /// 具体同事类
    /// </summary>
    public class ConcreteColleague : Colleague
    {
        public ConcreteColleague(string name, Mediator mediator) : base(mediator, name)
        {

        }

        public override void Send(string message)
        {
            m_mediator.Send(message, this);
        }

        public override void Notify(string message)
        {
            Console.WriteLine($"同事 {m_name} 得到信息：{message}");
        }
    }
}
