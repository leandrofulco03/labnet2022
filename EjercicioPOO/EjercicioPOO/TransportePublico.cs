using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    public abstract class TransportePublico
    {
        public TransportePublico()
        {

        }

        private int pasajeros;

        public int Pasajeros
        {
            get 
            { 
                return pasajeros; 
            }
            set 
            { 
                pasajeros = value; 
            }
        }

        private string modeloTrasnportePublico;

        public string ModeloTransportePublico
        {
            get 
            { 
                return modeloTrasnportePublico; 
            }
            set 
            {
                modeloTrasnportePublico = value; 
            }
        }

        private int numeroTransporte;

        public int NumeroTransporte
        {
            get 
            { 
                return numeroTransporte; 
            }
            set 
            { 
                numeroTransporte = value; 
            }
        }

        public abstract int Avanzar();
        public abstract int Detenerse();
    }
}
