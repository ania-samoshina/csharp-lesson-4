using System;

namespace Course3
{
    class Program
    {
        static void Main(string[] args)
        {
            Print.Class1.PrintName("Ann Samoshina");
            Console.WriteLine("Enter your task: ");
            int caseSwitch = Convert.ToInt32(Console.ReadLine());
            switch (caseSwitch)
            {
                case 1:
                    Task1.Program.Main1();
                    break;
                case 2:
                    Task2.MainClass.Main();
                    break;
                case 3:
                    Task3.Task2.Start();
                    break;
                
            }
            Console.ReadKey();

        }
    }
}
