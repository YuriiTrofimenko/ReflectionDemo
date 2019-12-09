using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DeepClone
{
    class Cloner
    {
        public static T DeepClone<T>(T source) where T : class
        {
            using (MemoryStream ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, source);
                ms.Position = 0;
                return (T)formatter.Deserialize(ms);
            }
        }
    }
}
