using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPgyak
{
    class Szemely
    {
        public string Nev { get; set; }
        public int Kor { get; set; }
        public Szemely(string nev, int kor)
        {
            Nev = nev;
            Kor = kor;
        }
        public void Koszones()
        {
            Console.WriteLine($"Szia, {Nev} vagyok, {Kor} eves.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
