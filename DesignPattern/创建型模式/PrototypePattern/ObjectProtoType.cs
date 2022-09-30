using System;

namespace DesignPattern.PrototypePattern
{
    [Serializable]
    public class ObjectProtoType : ProtoType
    {
        public ObjectProtoType(string name)
        {
            Name = name;
        }
        public string Name;
        public int Number = 0;
        public AA aA = new AA("-----------aaa");


        public void SetName(string name)
        {
            Name = name;
        }
        public void SetNumber(int number)
        {
            this.Number = number;
        }
    }

    [Serializable]
    public class AA
    {
        public string name;
        public AA(string name)
        {
            this.name = name;
        }
    }
}
