using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioUnidad2
{
    internal class Divisor
    {
        public static void Division(double y, double x)
        {
            try
            {
                Console.Write("Ingrese un divisor: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese un dividendo: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (num2 == 0)
                {
                    int num1Int = (int)Math.Floor(num1);
                    int num2Int = (int)Math.Floor(num2);
                    Console.WriteLine(num1Int / num2Int);
                }
                else
                {
                    Console.WriteLine(num1 / num2);
                }
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("¿Intentaste dividir por 0? Solo Chuck Norris puede hacerlo!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Creo que las letras no se pueden dividir :(");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("¿Pudo finalizar exitosamente?");
            }

            Console.WriteLine("");
        }
    }
}

