using System;

namespace DateYesterday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program calculates what date was yesterday");

            Console.WriteLine("Today is: {0}", DateTime.Today.ToString("d"));

            DateTime yesterday = YdCounter.GetYesterday();

            Console.WriteLine("Yesterday was : {0}", yesterday.ToString("d"));

            Console.ReadKey();
        }
    }
}
