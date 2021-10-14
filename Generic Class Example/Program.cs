using System;

namespace Generic_Class_Example
{
    class MyGenericClass<G,H>
    {
        public static bool EqualCheck(G a, H b)
        {
            bool c = a.Equals(b);
            return c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool result = MyGenericClass<int,string>.EqualCheck(10,"Hello");
            Console.WriteLine(result);
        }
    }
}
