using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TransportePublico> transporteL = new List<TransportePublico>();

            int ot = 0;
            while (ot < 5)
            {
                Omnibus omnibus = new Omnibus();

                int no = 0;

                Console.WriteLine("Introduzca la cantidad de pasajeros de Omnibus {0}:", ot + 1);

                omnibus.Pasajeros = int.Parse(Console.ReadLine());
                while (omnibus.Pasajeros <= 150 && no == 0)
                {
                    omnibus.ModeloTransportePublico = "Omnibus";
                    omnibus.NumeroTransporte = ot + 1;
                    transporteL.Add(omnibus);
                    no++;
                    ot++;
                }
            }

            int tt = 0;
            while (tt < 5)
            {
                Taxi taxi = new Taxi();

                int nt = 0;

                Console.WriteLine("Introduzca la cantidad de pasajeros de Taxi {0}:", tt + 1);

                taxi.Pasajeros = int.Parse(Console.ReadLine());
                while (taxi.Pasajeros <= 4 && nt == 0)
                {
                    taxi.ModeloTransportePublico = "Taxi";
                    taxi.NumeroTransporte = tt + 1;
                    transporteL.Add(taxi);
                    nt++;
                    tt++;
                }
            }

            foreach (TransportePublico transporteP in transporteL)
            {
                Console.WriteLine("Pasajeros de " + transporteP.ModeloTransportePublico + " " + transporteP.NumeroTransporte + " " + transporteP.Pasajeros.ToString());

            }

            Console.ReadLine();

        }
    }
    
}

