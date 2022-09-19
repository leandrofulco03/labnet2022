using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioUnidad2
{
        public class DivisorPorCero
        {
            public static void DivisorCero(int y)
            {
                try
                {
                    Console.Write("Introduzca un numero: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine(num1 / 0);

                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("finalizado");
                }
                Console.WriteLine("");
            }

        }
    }
