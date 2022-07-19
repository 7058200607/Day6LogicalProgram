using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day6LogicalPrograms
{

    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("0.Calculate Fibonacci series");
            Console.WriteLine("1.Calulate Perfect Number");
            Console.WriteLine("2.Calculate Prime Number");
            Console.WriteLine("3.Calculate Reverse Number");
            Console.Write("Enter A Choice :");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Fibonacci_Series.AFibonacciseries();
                    break;
                case 1:
                    PerfectNumber.AperfectNumber();
                    break;
                case 2:
                    PrimeNumber.APrimeNumber();
                    break;
                case 3:
                    ReverseNumber.AReverseNumber();
                    break;
            }
        }
    }
}
