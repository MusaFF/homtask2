using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Praduct praduct = new Praduct();
            praduct.Name = "Coca-cola";
            praduct.Pirce = "1.80";
            praduct.volume = "2L";
            praduct.count = "15";
            //Coca=Cola mehsulu

            Console.WriteLine($"Mehsulun adi: {praduct.Name}\nQiymet: {praduct.Pirce}\nTutum Hecim: {praduct.volume}\nSayi: {praduct.count}\n");
            {
                Praduct praduc = new Praduct();
                praduct.Name = "Bizon";
                praduct.Pirce = "1";
                praduct.volume = "350ml";
                praduct.count = "20";
                //Bizon Mehsulu

                Console.WriteLine($"Mehsulun adi: {praduct.Name}\nQiymet: {praduct.Pirce}\nTutum Hecim: {praduct.volume}\nSayi: {praduct.count}\n");
            }
            {
                Praduct pradduct = new Praduct();
                praduct.Name = "RedBUll";
                praduct.Pirce = "3.50";
                praduct.volume = "450ml";
                praduct.count = "10";
                //Coca=Cola mehsulu

                Console.WriteLine($"Mehsulun adi: {praduct.Name}\nQiymet: {praduct.Pirce}\nTutum Hecim: {praduct.volume}\nSayi: {praduct.count}\n");
            }
            {
                Praduct prraduct = new Praduct();
                praduct.Name = "Milk";
                praduct.Pirce = "1.50";
                praduct.volume = "2L";
                praduct.count = "8";
                //Coca=Cola mehsulu

                Console.WriteLine($"Mehsulun adi: {praduct.Name}\nQiymet: {praduct.Pirce}\nTutum Hecim: {praduct.volume}\nSayi: {praduct.count}\n");
            }
        }
    }
}
