using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifo_Atencion_de_Procesos
{
    class ColaQueue
    {
        ListaNodo listaProcesos;
        public int Count { get { return listaProcesos.Count; } }

        public ColaQueue()
        {
            listaProcesos = new ListaNodo();
        }

        public void Enqueue(Proceso nuevo)
        {
            listaProcesos.addPrimero(nuevo);
        }

        public Proceso Dequeue()
        {
            Proceso ultimo = listaProcesos.Ultimo;

            if (ultimo != null)
                listaProcesos.eliminarUltimo();

            return ultimo;
        }

        public Proceso Peek()
        {
            return listaProcesos.Ultimo;
        }

        public override string ToString()
        {
            return listaProcesos.ToString();
        }
    }
}
