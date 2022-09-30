using System;

namespace DesignPattern.StrategyPattern
{
    public interface ExplainAlgorithm { void Explain(); }
    public interface UseAlgorithm { void Use(); }

    public class AlgorithmExplain
    {
        ExplainAlgorithm m_Explain;
        UseAlgorithm m_Use;
        public AlgorithmExplain(ExplainAlgorithm explain, UseAlgorithm use)
        {
            m_Explain = explain;
            m_Use = use;
        }

        public void SetExplainer(ExplainAlgorithm explain)
        {
            Console.WriteLine("已更换讲解员");
            m_Explain = explain;
        }
        public void SetUser(UseAlgorithm use)
        {
            Console.WriteLine("已更换算法");
            m_Use = use;
        }
        public void ExplainAlgorithm()
        {
            //别的事情也可以写在这里
            m_Explain.Explain();
        }
        public void UseAlgorithm()
        {
            //别的事情也可以写在这里
            m_Use.Use();
        }
    }

    public class ExplainAlgorithmA : ExplainAlgorithm
    {
        public void Explain() { Console.WriteLine("这是 A 算法的讲解"); }
    }
    public class UseAlgorithmA : UseAlgorithm
    {
        public void Use() { Console.WriteLine("这是 A 算法的使用"); }
    }

    public class ExplainAlgorithmB : ExplainAlgorithm
    {
        public void Explain() { Console.WriteLine("这是 B 算法的讲解"); }
    }
    public class UseAlgorithmB : UseAlgorithm
    {
        public void Use() { Console.WriteLine("这是 B 算法的使用"); }
    }
}
