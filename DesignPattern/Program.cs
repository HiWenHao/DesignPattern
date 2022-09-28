using DesignPattern.ChainofResponsibilityPattern;
using DesignPattern.IteratorPatttern;
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




    }
}
