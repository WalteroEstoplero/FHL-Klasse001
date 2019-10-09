using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHL_Klasse001
{
    class Rennwagen
    {
        string name;
        string besitzer;
        string farbe;
        float leistung;
        float hubraum;

        public void InitBesitzer()
        {
            besitzer = "Flora Soft";
        }

        public void Name(string andererName)
        {
            besitzer = andererName;
        }

        public string GibBesitzer()
        {
            return besitzer;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Rennwagen rennwagen = new Rennwagen();
            rennwagen.InitBesitzer();

            rennwagen.Name("Herr Hermann Mann");

            // Console.WriteLine(rennwagen.name);
            Console.WriteLine(rennwagen.GibBesitzer());

            Console.ReadKey();
        }
    }
}
