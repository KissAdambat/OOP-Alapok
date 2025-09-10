using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPgyak
{
    public class Szemely
    {
        public string Nev ="Peti";
        public int Kor= 21;
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tan1 = new Szemely();
            Console.WriteLine($"A tanulo neve: {tan1.Nev} és {tan1.Kor} éves");
        }
    }
}
