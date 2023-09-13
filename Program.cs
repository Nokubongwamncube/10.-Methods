using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi();
            AddNumbers();

            //frezze console
            Console.Read();
        }

        static void SayHi() 
        {
            Console.WriteLine("Hi Nokubongwa, Say Hi is running");
            Console.WriteLine("Your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
            Console.WriteLine("Hi Nokubongwa,  Say is done");

        }
        static void AddNumbers()
        {
            Console.WriteLine("Hi Nokubongwa, Add Number is running");
            Console.WriteLine("Enter first number ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            Console.WriteLine("Hi Nokubongwa, Add Number is done, now you get the result and out to next line in main ");

        }
            

        


        






    }
}
