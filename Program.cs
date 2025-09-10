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
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tan1 = new Szemely();
            tan1.Nev = "Jani";
            tan1.Kor = 11;
            Console.WriteLine(tan1);
        }
    }
}
