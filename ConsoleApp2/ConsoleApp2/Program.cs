using System;

namespace ConsoleApp2
{
    class Program
    {
        private const char V = 'Yes';

        static void Main(string[] args)
        {
            Phone phone = new Phone("NoName");

            Phone phone2 = phone;

            phone.Brand = "Nokia";
            phone.Size = 15;
            phone.Function = true;
            phone.Call = 154.58;
            phone.FunctionSendSMS = V;

            phone2.Size = 26;


            internal string greeting = phone.GetFunction("call");
        private static object phone;

        Console.WriteLine(GetFunction);


        }

    }
}
