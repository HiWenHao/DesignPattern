using System.Collections.Generic;

namespace DesignPattern.MementoPattern
{
    /// <summary>
    /// 管理人
    /// 负责从 Memento 列表中恢复 Memento 存储对象到某一状态。
    /// </summary>
    public class CareTaker
    {
        public CareTaker()
        {
            m_mementoList = new List<Memento>();
        }

        private List<Memento> m_mementoList;

        public void Add(Memento state)
        {
            m_mementoList.Add(state);
        }

        public Memento Get(int index)
        {
            return m_mementoList[index];
        }
    }
}
