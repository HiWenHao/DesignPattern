using System;

namespace DesignPattern.CompositePattern
{
    /// <summary>
    /// 子节点
    /// </summary>
    public class Leaf : Composite
    {
        public Leaf(string name) : base(name)
        {
            Name = name;
        }
        public override void Add(Composite composite)
        {
            throw new InvalidOperationException("叶子节点不能添加元素");
        }

        public override void Depth(int depth)
        {
            Console.WriteLine(new string('-', depth * 2) + Name);
        }

        public override void Remove(Composite composite)
        {
            throw new InvalidOperationException("叶子节点不能删除元素");
        }

        public override int ShowCount()
        {
            return 1;
        }
    }
}
