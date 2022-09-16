using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjPOO
{
    public abstract class Animal
    {
        public Animal(int cantidadpatas)
        {
            this.cantidadpatas = cantidadpatas;
        }

        public int cantidadpatas { get; }

        public abstract string Caminar();
    }
}
