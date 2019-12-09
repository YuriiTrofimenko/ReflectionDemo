using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DeepClone
{
    class Program
    {
        static void Main(string[] args)
        {
            User u1 = new User() { Name = "John", albumIds = { 100500, 911, 42 } };
            //User u2 = Cloner.DeepClone(u1);
            User u2 = (User)u1.Clone();
            u2.albumIds[0] = 0;
            Console.WriteLine(u1.albumIds[0]);
            Console.WriteLine(u2.albumIds[0]);
        }
    }
}
