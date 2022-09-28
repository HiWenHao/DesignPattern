using System;

namespace DesignPattern.ObserverPattern
{
    public abstract class Observer
    {
        public abstract void BeNotified();
    }

    public class ObserverItem1 : Observer
    {
        SubjectItem1 subjectItem;
        public ObserverItem1(Subject subject)
        {
            subjectItem = (SubjectItem1)subject;
        }
        public override void BeNotified()
        {
            Console.WriteLine("观察者 1 收到了消息,确认信息为：" + subjectItem.Age);
        }
    }
    public class ObserverItem2 : Observer
    {
        SubjectItem1 subjectItem;
        public ObserverItem2(Subject subject)
        {
            subjectItem = (SubjectItem1)subject;
        }
        public override void BeNotified()
        {
            Console.WriteLine("观察者 2 收到了消息,确认信息为：" + subjectItem.Age);
        }
    }
    public class ObserverItem3 : Observer
    {
        SubjectItem1 subjectItem;
        public ObserverItem3(Subject subject)
        {
            subjectItem = (SubjectItem1)subject;
        }
        public override void BeNotified()
        {
            Console.WriteLine("观察者 3 收到了消息,确认信息为：" + subjectItem.Age);
        }
    }
}
