using System;

namespace SALARYApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            float gs;
            float salary;
            float tax;
            float rssb;
            float ins;
            Console.WriteLine("Enter Gloss Salary");
            gs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("choose 1 for Monthly Employee");
            Console.WriteLine("choose 2 for Hourly Employee");
            Console.WriteLine("choose 3 for One-time Employee");
            Console.WriteLine("\n");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    tax = gs * 30 / 100;
                    rssb = gs * 5 / 100;
                    ins = gs * 3 / 100;
                    salary = gs - tax - ins - rssb;
                    Console.WriteLine("\n");
                    Console.WriteLine(" Gloss Salary is : " + gs);
                    Console.WriteLine(" tax 30% is : " + tax);
                    Console.WriteLine(" Rssb is : "  + rssb);
                    Console.WriteLine(" Insurence is : " + ins);
                    Console.WriteLine(" Salary is : " + salary);
                    
                    break;
                case 2:
                  
                    rssb = gs * 5 / 100;
                    ins = gs * 3 / 100;
                    salary = gs - ins - rssb;
                    Console.WriteLine("\n");
                    Console.WriteLine(" Gloss Salary is : " + gs);
                    Console.WriteLine(" Rssb is : "  + rssb);
                    Console.WriteLine(" Insurence is : " + ins);
                    Console.WriteLine(" Salary is : " + salary);
                    
                    break;
                case 3:
                    tax = gs * 30 / 100;
                    salary = gs - tax;
                    Console.WriteLine("\n");
                    Console.WriteLine(" Gloss Salary is : " + gs);
                    Console.WriteLine(" tax 30% is : " + tax);
                    Console.WriteLine(" Salary is : " + salary);
                    
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
        }
    }
}
