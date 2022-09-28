namespace DesignPattern.IteratorPatttern
{
    /// <summary>
    /// 迭代器
    /// </summary>
    public interface Iterator<T>
    {
        bool HasNext();
        T Next();
    }

    /// <summary>
    /// 容器集装箱
    /// </summary>
    public interface IContainer<T>
    {
        Iterator<T> GetIterator();
    }
}
