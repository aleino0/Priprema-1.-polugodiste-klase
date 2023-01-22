using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_kalse2
{
    class GeometrijskiLik
    {
        public int brojStranica;
        double[] stranice = new double[10];

        public void UcitajStranice()
        {
            for (int i = 0; i < brojStranica; i++)
            {
                Console.WriteLine("Upišite duljinu {0}. stranice", i + 1);
                string duljina = Console.ReadLine();
                stranice[i] = Convert.ToDouble(duljina);
            }
        }

        public double Opseg()
        {
            double opseg=0;
            for (int i = 0; i < brojStranica; i++)
            {
                opseg += stranice[i];
            }
            return opseg;
        } 
    }

    class Trokut : GeometrijskiLik
    {
        public Trokut()
        {
            brojStranica = 3;
        }
    }

    class Cetverokut : GeometrijskiLik 
    {
        public Cetverokut() 
        {
            brojStranica = 4;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Trokut trokut = new Trokut();
            trokut.UcitajStranice();
            Console.WriteLine("Opseg trokuta je {0}", trokut.Opseg());
            Cetverokut cetverokut = new Cetverokut();
            cetverokut.UcitajStranice();
            Console.WriteLine("Opseg četverokuta je {0}", cetverokut.Opseg());

            Console.ReadKey();
        }
    }
}
