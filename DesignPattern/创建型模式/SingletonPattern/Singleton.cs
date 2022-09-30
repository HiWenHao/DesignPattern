using System;

namespace DesignPattern.SingletonPattern
{
    #region 单例基类，防多线程问题
    /// <summary>
    /// 单例基类，防多线程问题
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Singleton<T> where T : class
    {
        protected Singleton() { }
        public static readonly T Instance = new Lazy<T>(() => (T)Activator.CreateInstance(typeof(T), true)).Value;
    }
    #endregion

    #region 懒汉模式
    /// <summary>
    /// 懒汉模式
    /// </summary>
    public class SingletonL
    {
        private SingletonL() { }
        static SingletonL instance;
        public static SingletonL Instance
        {
            get
            {
                if (null == instance)
                    instance = new SingletonL();
                return instance;
            }
        }
        public string Des = "这是懒汉模式，当被调用时才会创建自身并传递出去。";
    }
    #endregion

    #region 饿汉模式  
    /// <summary>
    /// 饿汉模式
    /// </summary>
    public class SingletonE
    { 
        private SingletonE() { }
        static SingletonE instance = new SingletonE();
        public static SingletonE Instance => instance;
        public string Des = "这是饿汉模式，当项编译后直接创建自身，再被调用时传递出去。";
    }
    #endregion

    #region 内部静态类       //个人觉得没啥卵用
    /// <summary>
    /// 内部静态模式
    /// </summary>
    public class SingletonJ
    {
        private SingletonJ() { }
        public static SingletonJ Instance => InnerClass.instance;

        public static class InnerClass
        {
            public static readonly SingletonJ instance = new SingletonJ();
        }
        public string Des = "这是内部静态类模式，编译后直接创建自身，再被调用时传递出去。";
    }
    #endregion

    #region 多线程安全的单例模式
    //========================================多地方吃亏而得.==================================
    /// <summary>
    /// 多线程安全的单例模式
    /// </summary>
    public class SingletonA
    {
        private SingletonA() { }
        private volatile static SingletonA m_instance;
        public static SingletonA Instance
        {
            get
            {
                if (null == m_instance)
                {
                    lock (new object())
                    {
                        if (null == m_instance)
                        {
                            m_instance = new SingletonA();
                        }
                    }
                }
                return m_instance;
            }
        }

        public string Des = "这是防多线程安全的单例模式，在被调用时创建自身后传递出去。\n" +
            "---- volatile 关键字指示一个字段可以由多个同时执行的线程修改。 \n" +
            "---- 出于性能原因，编译器，运行时系统甚至硬件都可能重新排列对存储器位置的读取和写入。 \n" +
            "---- 声明为 volatile 的字段将从某些类型的优化中排除。 \n" +
            "---- 不确保从所有执行线程整体来看时所有易失性写入操作均按执行顺序排序";
    }
    #endregion

    #region 系统懒加载式创建
    /// <summary>
    /// 系统懒加载式创建
    /// </summary>
    public class SingletonLazy
    {
        private SingletonLazy() { }
        public static readonly SingletonLazy Instance =
            new Lazy<SingletonLazy>(
                new Func<SingletonLazy>(() => new SingletonLazy())
            ).Value;

        public string Des = "这是系统懒加载式创建模式，使用框架自带的Lazy类创建自身后传递出去，也防止多线程创建。";
    }
    #endregion
}