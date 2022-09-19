using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioUnidad2
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Introduza 1 para ejercicio 1\nIntroduza 2 para ejercicio 2\nIntroduza 3 para ejercicio 3\nIntroduza 0 para salir");
                Console.WriteLine("");
                int seleccion = int.Parse(Console.ReadLine());
                do
                {
                    switch (seleccion)
                    {
                        case 1:
                            DivisorPorCero.DivisorCero(0);
                            break;

                        case 2:
                            Divisor.Division(0, 0);
                            break;

                        case 3:
                            try
                            {
                                Console.Write("Ingresa un numero: ");
                                int num = int.Parse(Console.ReadLine());
                                Logic.EsPar(num);

                            }
                            catch (NoEsParException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            Console.WriteLine("");
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("Introduza 1 para ejercicio 1\nIntroduza 2 para ejercicio 2\nIntroduza 3 para ejercicio 3\nIntroduza 0 para salir");
                    seleccion = int.Parse(Console.ReadLine());

                }

                while (seleccion != 0);
            }

            catch (FormatException)
            {
                Console.WriteLine("Ingresa solo 1, 2 y 3 y 0 para salir");
            }

            Console.Read();
        }
    }
}

