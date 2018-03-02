using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCS
{
    class Program
    {
        static void Main(string[] args) //notice we're calling an array here
        {
            int n1, n2, n3, n4, n5, sum, avg; //naming integers
            Console.WriteLine("Enter number");
            n1 = Convert.ToInt32(Console.ReadLine()); //have to convert to int32 because standard ReadLine is string
            Console.WriteLine("Enter number");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number");
            n4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number");
            n5 = Convert.ToInt32(Console.ReadLine());
            sum = n1 + n2 + n3 + n4 + n5;
            avg = sum / 5;
            Console.WriteLine("Sum is: {0}", sum);
            Console.WriteLine("Average is: {0}", avg);
            Console.ReadLine();
        }
    }
}
