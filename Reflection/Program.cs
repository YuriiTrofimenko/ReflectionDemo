using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // var result = Generator.GetSurprize();
            // dynamic result = Generator.GetSurprize();
            // object result = Generator.GetSurprize();
            // Type resultType = result.GetType();

            var result = Generator.GetSurprize();
            Type resultType = result.GetType();

            FieldInfo[] fields = resultType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            MethodInfo[] methods = resultType.GetMethods();
            PropertyInfo[] props = resultType.GetProperties();

            // Console.WriteLine(result);

            /* if (fields.Count() != 0 && methods.Count() != 0 && props.Count() != 0)
            {
                Console.WriteLine(result);
            } */
            Console.WriteLine(resultType);
            foreach (var fieldInfo in fields)
            {
                // Console.WriteLine(fieldInfo);
                if (fieldInfo.Name == "id")
                {
                    fieldInfo.SetValue(result, 100);
                }
                Console.WriteLine(fieldInfo.Name + " : " + fieldInfo.GetValue(result));
            }
        }
    }
}
