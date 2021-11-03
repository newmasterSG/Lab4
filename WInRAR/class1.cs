using System;
using System.Diagnostics;

namespace WInRAR
{
    class class1
    {
        public int A { get; set; }
        public int B { get; set; }
        public class1 (int a, int b)
        {
            this.A = a;
            this.B = b;
            Debug.Indent();
            Debug.WriteLine($"a =" + a.ToString());
            Debug.WriteLine($"b =" + b.ToString());
            Console.WriteLine($"a ={a} , b = {b}");
            Console.ReadKey();
        }


    }
    [DebuggerTypeProxy(typeof(heir))]
    class heir : class1
    {
        public heir(int a, int b) : base(a,b)
        {
            a = 9;
            b = 1;
        }


    }
}
