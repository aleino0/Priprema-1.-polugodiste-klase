using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_klase1
{
    class Fruit
    {
        private string vrsta;
        private string boja;
        private bool jeLiSlatko;

        public Fruit(string vrsta)
        {
            this.vrsta = vrsta;
        }
        public Fruit(string vrsta, string boja, bool jeLiSlatko)
        {
            this.vrsta = vrsta;
            this.boja = boja;
            this.jeLiSlatko = jeLiSlatko;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit x = new Fruit("Jagoda", "Crvena", true);
            Fruit y = new Fruit("Limun", "Žuta", false);
            Fruit z = new Fruit("Avokado");

            Console.ReadKey();
        }
    }
}
