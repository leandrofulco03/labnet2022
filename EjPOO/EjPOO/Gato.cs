using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjPOO
{
    public class Gato : Animal
    {
        public Gato(int cantidadpatas) : base(cantidadpatas)
        {

        }
        public override string Caminar()
        {
            return $"Soy un gato y camino con mis {cantidadpatas} patas";
        }
    }
}
