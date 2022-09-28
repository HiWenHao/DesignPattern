namespace DesignPattern.MementoPattern
{
    /// <summary>
    /// 备忘录
    /// 包含了要被恢复的对象的状态
    /// </summary>
    public class Memento
    {
        //也可以为别的内容，eg: 一个class
        private string m_name;
        private int m_age;

        public Memento(string name, int age)
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
    }
}
