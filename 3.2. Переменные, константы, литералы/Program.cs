using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2.Переменные__константы__литералы
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.Write("My name is\t");
            //string MYName = Console.ReadLine();
           
            //Console.Write("My age is\t");
            //string MyAge = Console.ReadLine();
            
            //Console.Write("Do i have a pet\t");
            //string MyPet = Console.ReadLine();
            
            //Console.WriteLine("My shoe size is\t");
            //string MySizeShoue = Console.ReadLine();

            string MyName = "Roman";
            byte MyAge = 39;
            bool HaveIApet = true;
            double MyShoeSize = 45;

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("MyAge " + MyAge);
            Console.WriteLine("Do I have a pet? " + HaveIApet);
            Console.WriteLine("My shoe size is " + MyShoeSize);


            Console.ReadKey();
        }
    }
}
