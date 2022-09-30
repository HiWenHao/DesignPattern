using DesignPattern.AbstractFactoryPattern;
using DesignPattern.AdapterPattern;
using DesignPattern.BridgePattern;
using DesignPattern.BuilderPattern;
using DesignPattern.ChainofResponsibilityPattern;
using DesignPattern.CommandPattern;
using DesignPattern.CompositePattern;
using DesignPattern.DecoratorPattern;
using DesignPattern.FacadePattern;
using DesignPattern.FactoryMethodPattern;
using DesignPattern.FlyweightPattern;
using DesignPattern.InterpreterPattern;
using DesignPattern.IteratorPatttern;
using DesignPattern.MediatorPattern;
using DesignPattern.MementoPattern;
using DesignPattern.ObserverPattern;
using DesignPattern.PrototypePattern;
using DesignPattern.ProxyPattern;
using DesignPattern.SingletonPattern;
using DesignPattern.StatePattern;
using DesignPattern.StrategyPattern;
using DesignPattern.TemplateMethodPattern;
using DesignPattern.VisitorPattern;
using System;
using System.Collections.Generic;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 创建型模式
            //SingletonHelper();
            //SimpleFactoryMethodHelper();
            //FactoryMethodModelHelper();
            //AbstractFactoryHelper();
            //OrderBuilderHelper();
            //DisorderBuilderHelper();
            //PrototypeHelper();
            #endregion

            #region 结构型模式
            //StaticProxyHelper();
            //DynamicProxyHelper();
            //FlyweightHelper();
            //FacadeHelper();
            //DecoratorHelper();
            //CompositeHelper();
            //BridgeHelper();
            //AdapterHelper();
            #endregion

            #region 行为型模式
            //TemplateMethodHelper();
            //StrategyHelper();
            //StateHelper();
            //VisitorHelper();
            //ChainofResponsibilityHelper();
            //ObserverHelper();
            //MementoHelper();
            //IteratorHelper();
            //InterpreterHelper();
            //MediatorHelper();
            //CommandHelper();
            #endregion
        }

        #region 创建型模式
        #region Pattern - Prototype
        static void PrototypeHelper()
        {
            ObjectProtoType _proto0 = new ObjectProtoType("Name_0");
            ObjectProtoType _proto1 = (ObjectProtoType)_proto0.Clone();
            ObjectProtoType _proto2 = (ObjectProtoType)_proto0.Copy();

            Console.WriteLine("最开始 _proto0.Clone出_proto1     _proto0.Copy出_proto2         _proto0 的属行和字段值:");
            Console.WriteLine($"Name = {_proto0.Name}    Number = {_proto0.Number}    aA.name = {_proto0.aA.name}");
            Console.WriteLine();


            _proto1.SetName("SetName_1");
            _proto2.SetNumber(2321312);
            _proto0.aA.name = "AAAAA";

            Console.WriteLine("_proto1 修改了 Name 为：SetName_1");
            Console.WriteLine("_proto2 修改了 Number 为：" + 2321312);
            Console.WriteLine("_proto0 修改了 aA.name 为：AAAAA");

            Console.WriteLine();
            Console.WriteLine("结束时 全部 _proto 的属行和字段值:");
            Console.WriteLine($"_proto0.Name = {_proto0.Name}\t\t\t_proto0.Number = {_proto0.Number}\t\t\t _proto0.aA.name = {_proto0.aA.name}");
            Console.WriteLine($"_proto1.Name = {_proto1.Name}\t\t_proto1.Number = {_proto1.Number}\t\t\t _proto1.aA.name = {_proto1.aA.name}");
            Console.WriteLine($"_proto2.Name = {_proto2.Name}\t\t\t_proto2.Number = {_proto2.Number}\t\t _proto2.aA.name = {_proto2.aA.name}");
            Console.ReadLine();
        }
        #endregion

        #region Pattern - Builder
        static void OrderBuilderHelper()
        {
            OrderBuilderDirector _director = new OrderBuilderDirector();
            _director.Build(new OrderBuilderWorker()).BuilderProductToString();

            Console.ReadLine();
        }

        static void DisorderBuilderHelper()
        {
            DisorderBuilderDirector _director = new DisorderBuilderDirector();

            //按照客户制定的来
            DisorderBuilderWorker _disorderworker = new DisorderBuilderWorker();
            _disorderworker.BuildD("444DDD").BuildB("222BBB");
            _director.Build(_disorderworker).BuilderProductToString();
            Console.WriteLine("=============分割线=============");

            //默认顺序
            DisorderBuilderWorker _orderWorker = new DisorderBuilderWorker();
            _director.Build(_orderWorker).BuilderProductToString();
            Console.WriteLine("=============分割线=============");

            //自己 换一个建造者 接着打造该产品
            _disorderworker = new DisorderBuilderWorker(_disorderworker.GetProduct());
            _disorderworker.BuildB("我又修改了");
            _director.Build(_disorderworker).BuilderProductToString();

            Console.ReadLine();
        }
        #endregion

        #region Pattern - AbstractFactory
        static void AbstractFactoryHelper()
        {
            XiaomiFactory xiaomiFactory = new XiaomiFactory();
            IPhoneProduct xiaomiPhone = xiaomiFactory.iphoneProduct();
            IRouterProduct xiaomiRouter = xiaomiFactory.routerProduct();
            xiaomiPhone.Start();
            xiaomiPhone.CallUp();
            xiaomiPhone.Shutdown();
            xiaomiPhone.SendSMS();
            xiaomiRouter.Start();
            xiaomiRouter.Setting();
            xiaomiRouter.OpenWife();
            xiaomiRouter.Shutdown();

            Console.WriteLine();

            HuaweiFactory huaweiFactory = new HuaweiFactory();
            IPhoneProduct huaweiPhone = huaweiFactory.iphoneProduct();
            IRouterProduct huaweiRouter = huaweiFactory.routerProduct();
            huaweiPhone.Start();
            huaweiPhone.CallUp();
            huaweiPhone.Shutdown();
            huaweiPhone.SendSMS();
            huaweiRouter.Start();
            huaweiRouter.Setting();
            huaweiRouter.OpenWife();
            huaweiRouter.Shutdown();

            Console.ReadLine();
        }
        #endregion

        #region Pattern - FactoryMethod
        static void SimpleFactoryMethodHelper()
        {
            Word a = SimpleFactoryMethod.GetWord("A");
            Word b = SimpleFactoryMethod.GetWord("B");
            Word c = SimpleFactoryMethod.GetWord("C");
            Word d = SimpleFactoryMethod.GetWord("De");
            a.Name();
            b.Name();
            c.Name();

            Console.ReadLine();
        }

        static void FactoryMethodModelHelper()
        {
            Word a = new AaFactory().GetWord();
            Word b = new BbFactory().GetWord();
            Word c = new CcFactory().GetWord();
            Word d = new DdFactory().GetWord();
            a.Name();
            b.Name();
            c.Name();
            d.Name();

            Console.ReadLine();
        }
        #endregion

        #region Pattern - Singleton
        static void SingletonHelper()
        {
            Console.WriteLine(SingletonL.Instance.Des);
            Console.WriteLine();
            Console.WriteLine(SingletonE.Instance.Des);
            Console.WriteLine();
            Console.WriteLine(SingletonJ.Instance.Des);
            Console.WriteLine();
            Console.WriteLine(SingletonA.Instance.Des);
            Console.WriteLine();
            Console.WriteLine(SingletonLazy.Instance.Des);

            Console.ReadLine();
        }
        #endregion
        #endregion

        #region 结构型模式
        #region Pattern - Proxy
        static void StaticProxyHelper()
        {
            Console.WriteLine("静态代理演示：");
            Console.WriteLine();
            RentStaticProxy proxy = new RentStaticProxy(new Landlord());
            proxy.Renting();

            Console.ReadLine();
        }
        static void DynamicProxyHelper()
        {
            Console.WriteLine("动态代理演示：");
            Console.WriteLine();

            IRent _rent = DynamicProxy<Landlord>.As<IRent>();
            _rent.Renting();

            Console.WriteLine();
            Console.WriteLine("动态代理 学的不好 还待完善 还望谅解.");
            Console.WriteLine("如果有大佬可以提出解决方案，还希望联系Xiaohei( 841298494@qq.com ).");
            Console.ReadLine();
        }
        #endregion

        #region Pattern - Flyweight
        static void FlyweightHelper()
        {
            LetterFlyWeight _letters = new LetterFlyWeight();
            Console.WriteLine("当前打印: " + _letters.Print("A"));
            Console.WriteLine("当前打印: " + _letters.Print("B"));
            Console.WriteLine("当前打印: " + _letters.Print("C"));
            Console.WriteLine("当前打印: " + _letters.Print("D"));
            Console.WriteLine("当前打印: " + _letters.Print("E"));
            Console.WriteLine("当前打印: " + _letters.Print("F"));
            Console.WriteLine();
            Console.WriteLine("---------" + _letters.Print("E") + _letters.Print("F") + _letters.Print("F") + _letters.Print("A") + _letters.Print("C") + _letters.Print("E"));

            Console.ReadLine();
        }
        #endregion

        #region Pattern - Facade
        static void FacadeHelper()
        {
            FacadeMode facade = new FacadeMode();

            facade.BackHome();
            facade.GoSleep();
            facade.GoWork();

            Console.ReadLine();
        }
        #endregion

        #region Pattern - Decorator
        static void DecoratorHelper()
        {
            DrinkDecorator _syrup = new Syrup();
            DrinkDecorator _coffee = new Coffee();
            DrinkDecorator _sodaWater = new SodaWater();
            
            _syrup = new Ice(_syrup);
            _coffee = new Sugar(_coffee);

            _sodaWater = new Mint(_sodaWater);
            _sodaWater = new Ice(_sodaWater);
            
            Console.WriteLine($"{_syrup.Des} {_syrup.Cost}");
            Console.WriteLine($"{_coffee.Des} {_coffee.Cost}");
            Console.WriteLine($"{_sodaWater.Des} {_sodaWater.Cost}");
            
            Console.ReadLine();
        }
        #endregion

        #region Pattern - Composite
        static void CompositeHelper()
        {
            Composite _root = new TreeLimb("小三门目录");

            Composite art = new TreeLimb("美术");
            Composite sports = new TreeLimb("体育");
            Composite music = new TreeLimb("音乐");
            _root.Add(art);
            _root.Add(sports);
            _root.Add(music);

            Composite painting = new TreeLimb("油画类");
            art.Add(painting);

            Composite running = new TreeLimb("跑步类");
            Composite swimming = new TreeLimb("游泳类");
            sports.Add(running);
            sports.Add(swimming);

            Composite soprano = new TreeLimb("高音类");
            Composite opera = new TreeLimb("戏曲类");
            Composite bass = new TreeLimb("低音类");
            music.Add(soprano);
            music.Add(opera);
            music.Add(bass);

            Composite painting1 = new Leaf("油画精选1");
            Composite painting2 = new Leaf("油画精选2");
            painting.Add(painting1);
            painting.Add(painting2);

            Composite opera1 = new TreeLimb("戏曲选集1");
            Composite opera2 = new TreeLimb("戏曲选集2");
            Composite opera3 = new TreeLimb("戏曲选集3");
            opera.Add(opera1);
            opera.Add(opera2);
            opera.Add(opera3);
            opera.Remove(opera2);

            Composite swimming1 = new Leaf("花样游泳");
            Composite swimming2 = new Leaf("200m游泳");
            Composite swimming3 = new Leaf("800m接力游泳");
            Composite swimming4 = new Leaf("1600m接力游泳");
            swimming.Add(swimming1);
            swimming.Add(swimming2);
            swimming.Add(swimming3);
            swimming.Add(swimming4);

            _root.Depth(0);
            Console.WriteLine();
            Console.WriteLine("文章数：" + _root.ShowCount());

            Console.ReadLine();
        }
        #endregion

        #region Pattern - Bridge
        static void BridgeHelper()
        {
            Goods huaweiIPad = new GoodIPad(new Huawei());
            huaweiIPad.Info();

            Goods lenovoPhone= new GoodPhone(new Lenovo());
            lenovoPhone.Info();

            Goods appleComputer = new GoodComputer(new Apple());
            appleComputer.Info();

            Console.ReadLine();
        }
        #endregion

        #region Pattern - Adapter
        static void AdapterHelper()
        {
            #region 类适配器, 会发现和网线没有任何关系。用的计较少
            Reticle reticle1 = new Reticle();

            Computer computer1 = new Computer();
            Adapter1 adapter1 = new Adapter1();
            computer1.Net(adapter1);
            #endregion

            #region 对象适配器, 比较常用
            Computer computer2 = new Computer();
            Reticle reticle2 = new Reticle();
            Adapter2 adapter2 = new Adapter2(reticle2);     //适配器链接网线
            computer2.Net(adapter2);    //电脑通过适配器使用网线上网
            #endregion

            Console.ReadLine();
        }
        #endregion
        #endregion

        #region 行为型模式
        #region Pattern - TemplateMethod
        static void TemplateMethodHelper()
        {
            TemplateMethod cola = new Cola();
            cola.HaveDrank();

            TemplateMethod juice = new Juice();
            juice.HaveDrank();

            Console.ReadLine();
        }
        #endregion

        #region Pattern - Strategy
        static void StrategyHelper()
        {
            AlgorithmExplain algorithmExplain = new AlgorithmExplain(new ExplainAlgorithmA(), new UseAlgorithmB());

            algorithmExplain.ExplainAlgorithm();
            algorithmExplain.UseAlgorithm();

            Console.WriteLine("\n--------------------\n");

            algorithmExplain.SetExplainer(new ExplainAlgorithmB());
            algorithmExplain.SetUser(new UseAlgorithmA());
            algorithmExplain.ExplainAlgorithm();
            algorithmExplain.UseAlgorithm();

            Console.ReadLine();
        }
        #endregion

        #region Pattern - State
        static void StateHelper()
        {
            StateModelA stateA = new StateModelA();
            StateModelB stateB = new StateModelB();
            StateController controller = new StateController(stateA);
            controller.Enter();
            controller.Change(stateB);
            controller.Exit();

            Console.ReadLine();
        }
        #endregion

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
        #endregion
    }
}
