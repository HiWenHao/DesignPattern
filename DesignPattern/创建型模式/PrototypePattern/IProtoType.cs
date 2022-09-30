using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPattern.PrototypePattern
{
    public interface IProtoType
    {
        object Copy();
        object Clone();
    }

    [Serializable]
    public class ProtoType : IProtoType
    {
        public object Clone() => MemberwiseClone();

        public object Copy()
        {
            using (var ms = new MemoryStream())
            {
                BinaryFormatter binaryFormatte = new BinaryFormatter();
                binaryFormatte.Serialize(ms, this);
                ms.Seek(0, SeekOrigin.Begin);
                return binaryFormatte.Deserialize(ms);
            }
        }
    }
}
