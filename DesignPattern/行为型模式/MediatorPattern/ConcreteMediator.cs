using System;
using System.Collections.Generic;

namespace DesignPattern.MediatorPattern
{
    /// <summary>
    /// 具体的中介者， eg: ChangedMediator
    /// </summary>
    public class ConcreteMediator : Mediator
    {
        private List<Colleague> colleagues;
        public ConcreteMediator()
        {
            colleagues = new List<Colleague>();
        }
        ~ConcreteMediator()
        {
            while (colleagues.Count > 0)
            {
                colleagues.RemoveAt(0);
            }
            colleagues.Clear();
            colleagues = null;
        }


        public void AddColleague(Colleague colleague)
        {
            if (colleagues.Contains(colleague))
            {
                Console.WriteLine($"中介者已经知道当前同事{colleague.Name}了，不要重复介绍.");
                return;
            }

            colleagues.Add(colleague);
        }


        public override void Send(string message, Colleague colleague)
        {
            for (int i = 0; i < colleagues.Count; i++)
            {
                if (colleagues[i] == colleague)
                {
                    //自己不能给自己发送消息
                    continue;
                }
                colleagues[i].Notify(message);
            }
        }
    }
}
