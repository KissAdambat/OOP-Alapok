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

        public override string ToString()
        {
            return $"A tanuló neve: {nev} és életkora {kor} eves";
        }
    }
    public class Hallgato : Szemely
    {
        private int npetunkod;
        public int Npetunkod
        {
            get { return npetunkod; }
            set {
                if (value > 6) {
                    Console.WriteLine("Nem lehet 6-nál nagyobb a neptunkód");
                }
                else
                { 
                    npetunkod = value; 
                }
            }

        }

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

            Bankszamla szamla1 = new Bankszamla();
            szamla1.Egyenleg = 1000;
            Console.WriteLine(szamla1.Egyenleg);
        }
    }
}
