using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Animal> list = new List<Animal>();

            list.Add(new Persona(2));
            list.Add(new Gato(4));

            foreach (Animal item in list)
            {
                Console.WriteLine(item.Caminar());
            }

            Persona persona = new Persona(2);
            Console.WriteLine(persona.Saludo());

            Console.ReadLine();
        }
    }
}
