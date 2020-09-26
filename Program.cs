using System;

namespace _11._09._2020_practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Microsoft.NET Framework 2.0 Application Development Foundation";
            string[] sa = s.Split(" ");
            Array.Sort(sa);
            s = string.Join(" ", sa); Console.WriteLine(s);
           
        }
    }
}







//Упражнение 1
 /*SByte a = 0; Byte b = 0; Int16 c = 0; Int32 d = 0; int e = 0; string s = "";
             Exception ex = new Exception();

            object[] types = { a, b, c, d, e, s, ex };

            foreach(object o in types)
            {
                string type;
                if (o.GetType().IsValueType) type = "Value type";
                else
                    type = "Reference Type";
                Console.WriteLine("{0}: {1}", o.GetType(),type);*/