using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Generator
    {
        public static dynamic GetSurprize() {
            Random r = new Random();
            switch (r.Next(0, 3))
            {
                case 0: return "Hello World!";
                case 1: return new User() { Name = "John", albumIds = { 100500, 911, 42 } };
                case 2: return new { Id = 12, Name = "Bill", Details = new User() { Name = "Bill", albumIds = { 100500, 911, 42 } }, Smth = new { Id = 911 } };
                default: return new object();
            }
        }
    }
}
