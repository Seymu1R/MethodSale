using System;
using System.Collections.Generic;
using System.Text;

namespace MethodSale.Models
{
    class Order
    {        
        public double Totalprice;
        public void Sale(Product product,int count) {
            
            double a =product.Price * count;
            Totalprice += a;            
            Console.WriteLine($"The product was added to the basket TOTAL- { Math.Round(Totalprice, 2)} AZN");
        }      

        public void Discount() {
            Predicate<double> nodiscount = Totalprice => Totalprice <= 100;
            Predicate<double> discount10 = Totalprice => Totalprice > 100 && Totalprice < 200;
            Predicate<double> discount20 = Totalprice => Totalprice >= 200;
            if (nodiscount(Totalprice))
            {
                Console.WriteLine($"Unfortunately, no discount -  {Math.Round(Totalprice, 2)} \nThank you for choosing us");
            }
            if (discount10(Totalprice))
            {
                Totalprice = Totalprice - Totalprice * 0.1;
                Console.WriteLine($" 10 percent discount -  {Math.Round(Totalprice, 2)} \nThank you for choosing us");
            }
            if (discount20(Totalprice))
            {
                Totalprice = Totalprice - Totalprice * 0.2;
                Console.WriteLine($" 20 percent discount -  {Math.Round(Totalprice, 2)} \nThank you for choosing us");
            }
            
        }

    }
}
