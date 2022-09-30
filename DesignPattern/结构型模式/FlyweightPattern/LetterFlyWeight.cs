using System;
using System.Collections.Generic;
using System.Reflection;

namespace DesignPattern.FlyweightPattern
{
    public class LetterFlyWeight
    {
        public LetterFlyWeight() { }

        private Dictionary<string, Letter> dic = new Dictionary<string, Letter>();

        public string Print(string letterName)
        {
            string _name = "Letter" + letterName;
            if (dic.ContainsKey(_name))
            {
                Console.WriteLine("开始重复使用：" + letterName);
                return dic[_name].Print();
            }
            else
            {
                Type[] types = Assembly.GetAssembly(typeof(Letter)).GetTypes();
                foreach (var item in types)
                {
                    if (item.Name == _name)
                    {
                        Letter letter = (Letter)Activator.CreateInstance(item);
                        dic.Add(_name, letter);
                        return letter.Print();
                    }
                }
            }
            return null;
        }
    }
}
