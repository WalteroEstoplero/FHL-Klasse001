using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHL_Klasse001
{
    class CPerson
    {
        string name;
        int alter;

        public void Ausgabe(int intParam)
        {
            alter = intParam;
            Console.WriteLine(alter);
        }

        public void Ausgabe(string stringParam)
        {
            name = stringParam;
            Console.WriteLine(name);
        }

        public void Ausgabe(int intParam, string stringParam)
        {
            alter = intParam;
            name = stringParam;
            Console.WriteLine(name + " " + alter);
        }

        public void Ausgabe(string stringParam, int intParam)
        {
            alter = intParam;
            name = stringParam;
            Console.WriteLine(name + " " + alter);
        }

    }


    class Rennwagen
    {
        string name;
        string besitzer;
        string farbe;
        float leistung;
        float hubraum;

        public Rennwagen()
        {
            besitzer = "Tim Buktu";
        }

        ~Rennwagen()
        {
            Console.WriteLine("Der Destruktor von Rennwagen wurde aufgerufen.");
        }

        public void SetFarbe(string farbe)
        {
            this.farbe = farbe;
        }

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

    class CTest
    {
        public void Wertuebergabe(int param)
        {
            param = param + 10;
        }

        public void Referenzuebergabe(ref int param)
        {
            param = param + 10;
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

            CTest einTest = new CTest();
            int x = 5;
            einTest.Wertuebergabe(x);
            Console.WriteLine(x);

            int y = 0;
            einTest.Referenzuebergabe(ref y);
            Console.WriteLine(y);

            Rennwagen MyFlitzer = new Rennwagen();
            Console.WriteLine("MyFlitzer " + MyFlitzer.GibBesitzer());


            CPerson einePerson = new CPerson();
            einePerson.Ausgabe("Max Becks");
            einePerson.Ausgabe(34);
            einePerson.Ausgabe("Robert Rappert", 56);
            einePerson.Ausgabe(1, "Baby");



            Console.ReadKey();
        }
    }
}
