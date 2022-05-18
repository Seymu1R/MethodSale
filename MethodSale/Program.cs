using MethodSale.Models;
using System;

namespace MethodSale
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Product pro2 = new Product("Tea", 3.2, 200);
            Product pro3 = new Product("Flour", 10.5, 400);
            Product pro1 = new Product("Sugar", 5.6, 500);
            Console.WriteLine("Welcome to Market");
            Console.WriteLine("Please try to fill the basket");
            Order or = new Order();
            int selection;
            int selection2;
            do
            {
                Console.WriteLine("Please choose selection");
                Console.WriteLine("1 - Sugar");
                Console.WriteLine("2 - Tea");
                Console.WriteLine("3 - Flour");
                Console.WriteLine("4 - Shoping end");
                selection = int.Parse(Console.ReadLine());              

                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Please include product count");
                        selection2 = int.Parse(Console.ReadLine());
                        or.Sale(pro1, selection2);                        
                        break;
                    case 2:
                        Console.WriteLine("Please include product count");
                        selection2 = int.Parse(Console.ReadLine());
                        or.Sale(pro2, selection2);
                        break;
                    case 3:
                        Console.WriteLine("Please include product count");
                        selection2 = int.Parse(Console.ReadLine());
                        or.Sale(pro3,selection2);
                        break;
                    case 4:
                        or.Discount();
                        break;                   

                        
                    default:
                        break;
                }


            } while (selection > 0 && selection<4);        

            
            
                       

            
           
        }
    }
}
