using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgysegtesztGalJozsef
{
    public class Rectangle
    {
        public int CalculateArea(int width,int height)
        {
            
            
            if (width < 0 || height < 0)
            {
                
                throw new ArgumentException("Nem lehet negatív szám");
                
            }
            return height * width;

        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int width, height;
            Console.WriteLine("A téglalap egyik oldala:");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine("A téglalap másik oldala:");
            width = int.Parse(Console.ReadLine());

            var terulet = new Rectangle();
            Console.WriteLine($"A téglalap területe:{terulet.CalculateArea(width, height)} ");

            Console.ReadKey();
        }
    }
}
