using System.Collections.Generic;

namespace DesignPattern.IteratorPatttern
{
    /// <summary>
    /// 对象库
    /// </summary>
    public class ObjectRepository<T> : IContainer<T>
    {
        ObjectIterator<T> m_ObjectIterator;

        public ObjectRepository()
        {
            m_ObjectIterator = new ObjectIterator<T>();
        }
        public Iterator<T> GetIterator()
        {
            return m_ObjectIterator;
        }

        public void AddObject(T obj)
        {
            m_ObjectIterator.m_ObjectRepository.Add(obj);
        }



        /// <summary>
        /// 对象迭代器
        /// </summary>
        class ObjectIterator<Tobjcet> : Iterator<Tobjcet>
        {
            public ObjectIterator()
            {
                m_ObjectRepository = new List<Tobjcet>();
            }

            int index;
            public List<Tobjcet> m_ObjectRepository;

            public bool HasNext()
            {
                if (index < m_ObjectRepository.Count)
                {
                    return true;
                }
                return false;
            }

            Tobjcet Iterator<Tobjcet>.Next()
            {
                if (HasNext())
                {
                    return m_ObjectRepository[index++];
                }
                return default;
            }
        }
    }
}
