namespace DesignPattern.MementoPattern
{
    /// <summary>
    /// 发起人，可以是被存储对象，也可以是被存储对象的class.
    /// 创建 Memento 并在被创建的 Memento 对象中存储 该被存储的内容
    /// </summary>
    public class Originator
    {
        private string m_name;
        private int m_age;

        public void SetInfo(string name, int age)
        {
            this.m_name = name;
            this.m_age = age;
        }

        public string GetName()
        {
            return m_name;
        }
        public int GetAge()
        {
            return m_age;
        }

        public Memento SaveInfoToMemento()
        {
            return new Memento(m_name, m_age);
        }

        public void GetInfoFromMemento(Memento Memento)
        {
            m_name = Memento.GetName();
            m_age = Memento.GetAge();
        }
    }
}
