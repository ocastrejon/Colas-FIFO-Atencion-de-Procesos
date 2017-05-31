using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas_FIFO_Atencion_de_Procesos
{
    public partial class Form1 : Form
    {
        Queue <Proceso> miFifo = new Queue <Proceso>();
        Random pro = new Random();
        int proter = 0;
        int provac = 0;

        public Form1()
        {
            InitializeComponent();
        }
        //Primero que llega se atiende hasta 0 y cambiamos de proceso
        //implementar nuestra propia clase Queue
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttnComenzar_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 200; i++)
            {
                txtBxProcesos.Text += Environment.NewLine + "Ciclo: " + i.ToString();
                if (pro.Next(1, 4) == 3)
                {
                    Proceso p = new Proceso();
                    p.tiempo = pro.Next(4, 14);
                    miFifo.Enqueue(p);
                    txtBxProcesos.Text += miFifo.Peek() + "  ".ToString();
                }
                if (miFifo.Peek() != null)//count mayor que 0 para que entre esta condicion porque tiene exepciones
                    miFifo.Peek().tiempo--;
                if (miFifo.Peek().tiempo == 0)
                {
                    proter++;
                    miFifo.Dequeue();
                }
                else
                    provac++;
            }
        }
    }
}
