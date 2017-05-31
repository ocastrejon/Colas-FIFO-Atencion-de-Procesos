using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_FIFO_Atencion_de_Procesos
{
    class Proceso
    {
        private int _tiempo;
        public int tiempo { get { return _tiempo; } set { _tiempo = value; } }

        public Proceso()
        {
            _tiempo = 0;
        }

        public override string ToString()
        {
            return tiempo.ToString();
        }
    }
}
