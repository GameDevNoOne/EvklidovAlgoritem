using System;

namespace EvklidovAlgoritem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the bigger number first(x)");
            Console.WriteLine("Type the smaller number second(y)");
            //Conversion iz string v int
            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());
            //Kliče funkcijo iz EvklidovAlgoritem.cs
            int nsd = EuclidsAlgorithm.EvklidovAlgoritem.NSDRecursive(x,y);
            Console.WriteLine("Največji skupni delitelj je {0}",nsd.ToString());

        }
    }
}
