using System;

namespace AutoInspection
{
    class Program
    {
        static void Main()
        {

            Pc[] pcs = new Pc[6];
            pcs[0] = new Pc(0,"AMD", 8, "RTX 3060", true);
            pcs[1] = new Pc(1,"Intel", 4, "GTX 750Ti", false);
            pcs[2] = new Pc(2,"Intel", 32, "RTX 4090", true);
            pcs[3] = new Pc(3,"AMD", 16, "Onboard HD Graphics", false);
            pcs[4] = new Pc(4,"AMD", 64, "RTX 4090Ti", true);
            pcs[5] = new Pc(5,"Intel", 2, "Intel Onboard OHD", false);

            Console.WriteLine("Which CPU-Type should be searched for:");

            string searchTerm = Console.ReadLine();
            Console.WriteLine("Entered CPU: " + searchTerm);
            int noMatchCounter = 0;

            for (int i = 0; i < pcs.Length; i++)
            {

                if (searchTerm == null) { return; }
                
                if (pcs[i].cpuType.Contains(searchTerm))
                {
                    Console.WriteLine("PC Number " + pcs[i].id + " has an " + pcs[i].cpuType + " CPU and a " + pcs[i].gpu + " GPU.");

                } else
                {
                    noMatchCounter = noMatchCounter + 1;
                }

                if(noMatchCounter == pcs.Length)
                {
                    Console.WriteLine("Kein Auto gefunden!");
                }
            }

            Console.ReadKey();
            Console.Clear();
            Main();

        }
    }
}