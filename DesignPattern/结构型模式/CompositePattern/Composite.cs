namespace DesignPattern.CompositePattern
{
    /// <summary>
    /// 抽象合成类
    /// </summary>
    public abstract class Composite
    {
        /// <summary>
        /// 组件名
        /// </summary>
        public string Name;
        public Composite(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 增加子节点
        /// </summary>
        public abstract void Add(Composite composite);

        /// <summary>
        /// 删除子节点
        /// </summary>
        public abstract void Remove(Composite composite);

        /// <summary>
        /// 返回最终子节点数量
        /// </summary>
        public abstract int ShowCount();

        /// <summary>
        /// 节点展示深度
        /// </summary>
        /// <param name="depth"> - 的数量</param>
        public abstract void Depth(int depth);
    }
}
