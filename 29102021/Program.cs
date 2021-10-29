using System;

namespace _29102021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notebooklarin sayini daxil edin");
            string count = Console.ReadLine();
            int Count = Convert.ToInt32(count);
            Notebook[] notebooks = new Notebook[Count];
            for (int i = 0; i < notebooks.Length; i++)
            { 
                string model;
                do
                {
                    //Console.WriteLine("Modeli daxil edin");
                    model = Console.ReadLine();

                } while (model.Length !<3 && model.Length!>20 );
                

                string brand;
                
                do
                {
                    Console.WriteLine("Brand daxil edin");
                    brand = Console.ReadLine();

                } while (brand.Length < 3 && brand.Length > 20);
                int ram;
                do
                {
                    Console.WriteLine("ram daxil edin");
                    string rams = Console.ReadLine();
                    ram = Convert.ToInt32(rams);
                }
                while (ram < 0 && ram > 128);
                
                int price;
                do
                {
                    Console.WriteLine("Qiymeti daxil edin");
                    string prices = Console.ReadLine();
                    price = Convert.ToInt32(prices);
                } while (price<0);
            }
        }
    }
}
