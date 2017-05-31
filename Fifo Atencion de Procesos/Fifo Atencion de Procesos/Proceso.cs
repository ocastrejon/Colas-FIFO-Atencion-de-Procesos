using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifo_Atencion_de_Procesos
{
    class Proceso
    {
        private int _numProceso;
        public int NumeroProceso { get { return _numProceso; } }

        private int _vidaProceso;
        public int VidaProceso { get { return _vidaProceso; } set { _vidaProceso = value; } }

        private int _vidaComenzo;
        public int VidaComenzo { get { return _vidaComenzo; } }

        private Proceso _siguiente;
        public Proceso Siguiente { get { return _siguiente; } set { _siguiente = value; } }

        private Proceso _anterior;
        public Proceso Anterior { get { return _anterior; } set { _anterior = value; } }


        public Proceso(int ciclos, int numProceso)
        {
            this._vidaProceso = ciclos;
            this._vidaComenzo = ciclos;
            this._siguiente = null;
            this._anterior = null;
            this._numProceso = numProceso;
        }

        public override string ToString()
        {

            return "Proceso: " + _numProceso + Environment.NewLine
                 + "Ciclos originales:  " + _vidaComenzo + Environment.NewLine
                 + "Ciclos restantes:   " + _vidaProceso + Environment.NewLine
                 + "-----------------------------" + Environment.NewLine;
        }
    }
}
