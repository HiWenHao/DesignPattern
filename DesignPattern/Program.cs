using DesignPattern.ChainofResponsibilityPattern;
using DesignPattern.CommandPattern;
using DesignPattern.InterpreterPattern;
using DesignPattern.IteratorPatttern;
using DesignPattern.MediatorPattern;
using DesignPattern.MementoPattern;
using DesignPattern.ObserverPattern;
using DesignPattern.VisitorPattern;
using System;
using System.Collections.Generic;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VisitorHelper();
            //ChainofResponsibilityHelper();
            //ObserverHelper();
            //MementoHelper();
            //IteratorHelper();
            //InterpreterHelper();
            //MediatorHelper();
            CommandHelper();
        }


        #region Pattern - Visitor
        static void VisitorHelper()
        {
            List<Cooker> cookers = new List<Cooker>()
            {
                new ChineseChef(),
                new WesternChef(),
            };


            Visitor meat = new MeatVisitor();
            Visitor oil = new GetOilVisitor();

            for (int i = cookers.Count - 1; i >= 0; i--)
            {
                cookers[i].Cooking(meat);
                cookers[i].Cooking(oil);
            }
            Console.ReadLine();
        }
        #endregion

        #region Pattern - ChainofResponsibility
        static void ChainofResponsibilityHelper()
        {
            int[] _arr_Numbers = new int[] { 27, 18, 14, 4, -7, 99, 0 };
            ChainofResponsibility item1 = new ChainofResponsibilityItem1();
            ChainofResponsibility item2 = new ChainofResponsibilityItem2();
            ChainofResponsibility item3 = new ChainofResponsibilityItem3();
            item1.SetNext(item2);
            item2.SetNext(item3);

            for (int i = _arr_Numbers.Length - 1; i >= 0; i--)
            {
                item1.DisposeHandler(_arr_Numbers[i]);
            }

            Console.ReadLine();
        }
        #endregion

        #region Pattern - Observer
        static void ObserverHelper()
        {
            SubjectItem1 subject = new SubjectItem1();
            subject.AddObserver(new ObserverItem1(subject));
            subject.AddObserver(new ObserverItem2(subject));
            subject.AddObserver(new ObserverItem3(subject));

            subject.Age = 23;
            subject.Notify();
            Console.ReadLine();
        }
        #endregion

        #region Pattern - Memento
        static void MementoHelper()
        {
            Originator _originator = new Originator();
            CareTaker _careTaker = new CareTaker();
            _originator.SetInfo("Name 1", 10);
            _careTaker.Add(_originator.SaveInfoToMemento());
            _originator.SetInfo("Name 2", 18);
            _originator.SetInfo("Name 3", 25);
            _careTaker.Add(_originator.SaveInfoToMemento());
            _originator.SetInfo("Name 4", 80);

            Console.WriteLine("当前信息为: name = " + _originator.GetName() + ", age = " + _originator.GetAge());
            _originator.GetInfoFromMemento(_careTaker.Get(0));
            Console.WriteLine("第一次保存信息为: name = " + _originator.GetName() + ", age = " + _originator.GetAge());
            _originator.GetInfoFromMemento(_careTaker.Get(1));
            Console.WriteLine("第二次保存信息为: name = " + _originator.GetName() + ", age = " + _originator.GetAge());
            Console.ReadLine();
        }
        #endregion

        #region Pattern - Iterator
        static void IteratorHelper()
        {
            ObjectRepository<string> _stringRepository = new ObjectRepository<string>();
            _stringRepository.AddObject("A");
            _stringRepository.AddObject("B");
            _stringRepository.AddObject("C");
            _stringRepository.AddObject(11.ToString());

            ObjectRepository<int> _intRepository = new ObjectRepository<int>();
            _intRepository.AddObject(-1);
            _intRepository.AddObject(10);
            _intRepository.AddObject(20);
            _intRepository.AddObject(30);


            for (Iterator<string> _iterator = _stringRepository.GetIterator(); _iterator.HasNext();)
            {
                Console.WriteLine("Object is: " + _iterator.Next());
            }

            Console.WriteLine("===================================================================");

            for (Iterator<int> _iterator = _intRepository.GetIterator(); _iterator.HasNext();)
            {
                Console.WriteLine("Object is: " + _iterator.Next());
            }
            Console.ReadLine();
        }
        #endregion

        #region Pattern - Interpreter
        static void InterpreterHelper()
        {
            Interpreter _root1 = new CheckContentsExistence("Root1");
            Interpreter _root2 = new CheckContentsExistence("Root1");
            Interpreter _orExpr1 = new OrExpression(_root1, _root2);
            Console.WriteLine($"root 存在么：{_orExpr1.Interpret("root")}");

            Console.WriteLine();

            Interpreter _shanshan = new CheckContentsExistence("Shanshan");
            Interpreter _pig = new CheckContentsExistence("pig");
            Interpreter _isExpr2 = new AndExpression(_shanshan, _pig);
            Console.WriteLine($"Shanshan is a little pig? {_isExpr2.Interpret("pig Shanshan")}");
            Console.ReadLine();
        }
        #endregion

        #region Pattern - Mediator
        static void MediatorHelper()
        {
            ConcreteMediator m = new ConcreteMediator();

            //让 具体同事类 认识 中介者对象 
            ConcreteColleague c1 = new ConcreteColleague("c1", m);
            ConcreteColleague c2 = new ConcreteColleague("c2", m);
            ConcreteColleague c3 = new ConcreteColleague("c3", m);
            ConcreteColleague c4 = new ConcreteColleague("c4", m);
            
            //让 中介者 认识各个 具体同事类对象
            m.AddColleague(c1); 
            m.AddColleague(c1);
            m.AddColleague(c2);
            m.AddColleague(c3);
            m.AddColleague(c4);

            c1.Send("c1: 大家加班到这么晚，都吃过了吗？");
            Console.WriteLine();
            c2.Send("c2: 没有呢，c1你打算请客不?");
            Console.WriteLine();
            c3.Send("c3: 什么? c1打算请客么?");
            Console.WriteLine();
            c4.Send("c4: 大家AA吧，挣钱都不容易的.");
            Console.WriteLine();
            c1.Send("c1: 还是c4好,去吃饭吧。");

            Console.ReadLine();
        }
        #endregion

        #region Pattern - Command
        static void CommandHelper()
        {
            Invoker _invoker = new Invoker();
            Receiver _receiver = new Receiver();
            ICommand _concreteCommand = new ConcreteCommand(_receiver);

            _invoker.SetCommand(_concreteCommand);
            _invoker.ExecuteCommand();

            Console.ReadLine();
        }
        #endregion
    }
}
