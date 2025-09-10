using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPgyak
{
    public class Szemely
    {
        private string nev;
        private int kor;
        
        public Szemely(string Nev, int Kor)
        {
            nev = Nev;
            kor = Kor;
        }
        public string Kiir()
        {
            return $"A tanulo neve: {nev} és {kor} éves";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tan1 = new Szemely("Jani",55);
            Console.WriteLine(tan1.Kiir());
            Szemely tan2 = new Szemely("Peti",22);
            Console.WriteLine(tan2.Kiir());
        }
    }
}
