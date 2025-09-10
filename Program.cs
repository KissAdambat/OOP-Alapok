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
        /*public Szemely(string Nev, int Kor)
        {
            nev = Nev;
            kor = Kor;
        }
        public string Kiir()
        {
            return $"A tanulo neve: {nev} és {kor} éves";
        }*/
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tan1 = new Szemely();
            tan1.Nev = "Jani";
            Console.Write(tan1.Nev);
            tan1.Kor = 11;
            Console.Write(tan1.Kor);
            /*Szemely tan1 = new Szemely("Jani",55);
            Console.WriteLine(tan1.Kiir());
            Szemely tan2 = new Szemely("Peti",22);
            Console.WriteLine(tan2.Kiir());*/
        }
    }
}
