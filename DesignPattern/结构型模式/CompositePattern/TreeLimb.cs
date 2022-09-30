using System;
using System.Collections.Generic;

namespace DesignPattern.CompositePattern
{
    /// <summary>
    /// 枝干节点
    /// </summary>
    public class TreeLimb : Composite
    {
        private List<Composite> m_Composite = new List<Composite>();

        public TreeLimb(string name) : base(name)
        {
            Name = name;
        }
        public override void Add(Composite component)
        {
            m_Composite.Add(component);
        }

        public override void Depth(int depth)
        {
            Console.WriteLine(new string('-', depth * 2) + Name);
            foreach (Composite item in m_Composite)
            {
                item.Depth(depth + 1);
            }
        }

        public override void Remove(Composite component)
        {
            m_Composite.Remove(component);
        }

        public override int ShowCount()
        {
            int count = 0;
            foreach (var item in m_Composite)
            {
                count += item.ShowCount();
            }
            return count;
        }
    }
}
