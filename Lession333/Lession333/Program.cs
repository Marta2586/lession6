using System;

namespace Lession333
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public bool Love6(int a, int b)
    {
        if (a == 6 || b == 6 || a + b == 6 || Math.Abs(a - b) == 6)
        {
            return true;
        }


        //return false;

        //////
        ///
        public int TeenSum(int a, int b)
        {
            if (a >= 13 && a <= 19)
            {
                return 19;
            }

            if (b >= 13 && b <= 19)
            {
                return 19;
            }

            return a + b;
        }
