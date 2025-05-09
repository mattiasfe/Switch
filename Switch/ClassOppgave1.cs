using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class ClassOppgave1
    {
        int dag1 = 1;

        public void Run()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hvilken dag er det?");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Mandag");
                        break;
                    case "2": 
                        Console.WriteLine("Det er trisdag");
                        break;
                    case "3":
                        Console.WriteLine("Det er onsdag");
                        break;
                    case "4":
                        Console.WriteLine("Det er torsdag");
                        break;
                    case "5":
                        Console.WriteLine("Det er fredag");
                        break;
                    case "6":
                        Console.WriteLine("Det er laurdag");
                        break;
                    case "7":
                        Console.WriteLine("Det er søndag");
                        break;
                } 
            }

        }
    }
}
