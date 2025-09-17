using OOPgyak;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPgyak
{
    public class Szemely
    {
        protected string nev;
        private int kor;
        
        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        public int Kor
        {
            get { return kor; }
            set { kor = value; }
        }

        public override string ToString()
        {
            return $"A tanuló neve: {nev} és életkora {kor} eves";
        }
    }
    public class Hallgato : Szemely
    {
        private string npetunkod;
        public string Npetunkod
        {
            get { return npetunkod; }
            set
            {
                if (value.Length <= 6)
                {
                    npetunkod = value;
                }
                else { Console.WriteLine("Nem lehet 6-nál nagyobb a neptunkód"); }
            }
        }  
            public void Kiir()
            {
                nev = string.Empty;
            }
        }
    }
    
    public class Dolgozo : Szemely
    {
        private int ber;

    }
    public class Bankszamla {         
        private int egyenleg;
        public int Egyenleg
        {
            get { return egyenleg; }
            set
            {
                if (value >= 0)
                {
                    egyenleg = value;
                }
                else
                {
                    Console.WriteLine("Nem lehet negativ az egyenleg");
                }
                
            }
        }
        public void betesz()
        {
            
        }
        public void kivesz()
        {

        }   
    }
internal class Program
{
      static void Main(string[] args)
      {
             Szemely tan1 = new Szemely();
             tan1.Nev = "Jani";
             tan1.Kor = 11;
             Console.WriteLine(tan1);
             Console.WriteLine("---------------------------------");
             Bankszamla szamla1 = new Bankszamla();
             szamla1.Egyenleg = 1000;
             Console.WriteLine(szamla1.Egyenleg);
             Console.WriteLine("---------------------------------");
             Hallgato hallgato1 = new Hallgato();
             hallgato1.Npetunkod = "123456";
             Console.WriteLine(hallgato1.Npetunkod);
             Console.WriteLine("---------------------------------");
             List<Hallgato> hallgatok = new List<Hallgato>();

             for (int i = 0; i < 2; i++)
             {
                Hallgato hallgato = new Hallgato();
                Console.Write($"Kérem a(z) {i+1} hallgató nevét");
                hallgato.Nev = Console.ReadLine();
                Console.Write($"Kérem a(z) {i+1} hallgató életkorát");
                hallgato.Kor = int.Parse(Console.ReadLine());
                Console.Write($"Kérem a(z) {i+1} hallgató neptunkódját");
                hallgato.Npetunkod = Console.ReadLine();
                hallgatok.Add(hallgato);
             }

             foreach (var item in hallgatok)
             {
                    Console.WriteLine($"A hallgatók neve: {item.Nev}");
             }
      }
}