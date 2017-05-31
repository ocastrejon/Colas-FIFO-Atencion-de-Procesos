using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifo_Atencion_de_Procesos
{
    class ListaNodo
    {
        private Proceso _inicio;
        public Proceso Inicio { get { return _inicio; } }

        private Proceso _ultimo;
        public Proceso Ultimo { get { return _ultimo; } }

        private int _count;
        public int Count { get { return _count; } }

        public ListaNodo()
        {
            this._inicio = null;
            this._ultimo = null;
            this._count = 0;
        }

        public void addPrimero(Proceso nuevo)
        {
            Proceso temp = _inicio;

            _inicio = nuevo;
            _inicio.Siguiente = temp;

            if (temp == null)
                _ultimo = _inicio;
            else
                temp.Anterior = _inicio;

            _count++;
        }

        public void eliminarUltimo()
        {
            Proceso temp = _ultimo.Anterior;

            if (_count != 0)
            {
                if (_count == 1)
                {
                    _inicio = null;
                    _ultimo = null;
                }
                else
                {
                    _ultimo = temp;
                    _ultimo.Siguiente = null;
                }
                _count--;
            }
        }

        public override string ToString()
        {
            string cadena = string.Empty;
            int i = 1;

            Proceso temp = Ultimo;

            while (temp != null)
            {
                cadena += "Numero de proceso: " + i + Environment.NewLine
                        + temp.ToString();

                temp = temp.Anterior;
            }
            return cadena;
        }
    }
}
