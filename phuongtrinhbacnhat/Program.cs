using System;

namespace phuongtrinhbacnhat
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("phuong trinh bac nhat dang: 'a * x + b = 0'");

            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a != 0)
            {
                double solution = -b / a;
                Console.Write("phuong trinh co nghiem duy nhat: {0}", solution);
            }
            else
            {
                if (b == 0)
                {
                    Console.Write("Phuong trinh vo so nghiem");
                }
                else
                {
                    Console.Write("Phuong trinh vo nghiem");
                  
                }
            }
            Console.ReadKey();
        }
    }
}
