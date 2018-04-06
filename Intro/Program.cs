using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej NG18!");

            string name = Ui.Ask("Vad heter du?");
            Console.WriteLine($"Nämen hej \"{name}\"!");
            
            int age = Ui.AskForInt("Hur gammal är du? ");
            if (age < 20)
            {
                Console.WriteLine("Du får inte ännu handla på Systemet.");
            }
            else
            {
                Console.WriteLine("Plockar du upp en flaska Gnarly Head på vägen hem?");
            }
        }

       
    }
}
