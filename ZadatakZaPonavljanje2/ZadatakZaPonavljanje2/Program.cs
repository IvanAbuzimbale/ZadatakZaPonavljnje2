using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakZaPonavljanje2
{
    class Program
    {
        static void Main(string[] args)
        {
            int iznos;
            Console.Write("Upišite vrijednost u sekundama: ");
            iznos = Convert.ToInt32(Console.ReadLine());
            TimeSpan t = TimeSpan.FromSeconds(iznos);
            Console.WriteLine("Vaša vrijednost u sekundama je jednaka kao: ");
            Console.Write(t.Minutes + " minuta i " + t.Seconds + " sekundi.");
            Console.ReadKey();
            
        }
    }
}
