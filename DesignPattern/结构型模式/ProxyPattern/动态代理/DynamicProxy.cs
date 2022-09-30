using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace DesignPattern.ProxyPattern
{
    public class DynamicProxy<T> : DynamicObject where T : class, new()
    {
        private readonly T subject;
        private Dictionary<string, int> m_methodCallCount = new Dictionary<string, int>();

        public string Info
        {
            get
            {
                var sb = new StringBuilder();
                foreach (var item in m_methodCallCount)
                {
                    sb.AppendLine($"{item.Key} called {item.Value} time(s)");
                }
                return sb.ToString();
            }
        }

        public DynamicProxy(T subject)
        {
            this.subject = subject;
        }

        public static I As<I>() where I : class
        {
            if (!typeof(I).IsInterface)
                throw new ArgumentException("I must be an interface type!");

            //Console.WriteLine(typeof(T));
            DynamicProxy<T> inter = new DynamicProxy<T>(new T());
            return inter.subject as I;
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            try
            {
                Console.WriteLine($"Invoking{subject.GetType().Name}.{binder.Name} with arguments [{string.Join(".", args)}]");

                if (m_methodCallCount.ContainsKey(binder.Name))
                    m_methodCallCount[binder.Name]++;
                else
                    m_methodCallCount.Add(binder.Name, 1);

                result = subject.GetType().GetMethod(binder.Name).Invoke(subject, args);
                return true;
            }
            catch (Exception e)
            {
                result = null;
                return false;
            }
        }
    }
}
