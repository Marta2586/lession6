using System;

namespace ScopeLession
{
    public class Program
    {
        private static int sumOfMin;

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            sumOfMin = 14;

            DateTime currentDate = DateTime.UtcNow;

            int sum = 48;

            if (true)
            {
                sum++; 
            }
            else
            {
                sum--;
            } 

            sum = 43;



        } 
        public void Sum()
        {

        Console.WriteLine("Can I sum here?");


            //TEEEEEEEEEEEEE

            StaticSum();  
        }

        private void StaticSum()
        {
            throw new NotImplementedException();
        }
    }

}

