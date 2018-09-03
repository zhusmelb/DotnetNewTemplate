using System;

namespace ZhusLib
{
    public class Class1
    {
#if (IsExe)
        public static void Main(string[] args) {
            Console.WriteLine("Hellow World!");
        }
#endif
    }
}
