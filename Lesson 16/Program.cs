using System;

namespace Lesson_16
{
    class Program
    {
        private static void Method1(int i)
        {
            Console.WriteLine(i+i);
        }
        private static void Method2(int i)
        {
            Console.WriteLine(i-i);
        }
        private static void Method3(int i)
        {
            Console.WriteLine(i*i);
        }
        private delegate void MyDelegate(int i);
        static void Main(string[] args)
        {
            MyDelegate Math1 = Method1;
            MyDelegate Math2 = Method2;
            MyDelegate Math3 = Method3;
            MyDelegate AllMath = Math1 + Math2 + Math3;
            AllMath(10);
        }
    }
}
