using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjPOO
{
    public class Persona : Animal, IDialogos
    {
        public Persona(int cantidadpatas) : base(cantidadpatas)
        {

        }
        public override string Caminar()
        {
            return string.Format("Hola soy una persona y camino con mis {0} pies", cantidadpatas);
        }

        public string Saludo()
        {
            return $"Hola Soy Leandro";
        }
    }
}
