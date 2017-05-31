using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fifo_Atencion_de_Procesos
{
    public partial class Form1 : Form
    {
        ColaQueue cola;
        private static Random porcent = new Random(5);
        private static Random alea = new Random(5);
        private int _ciclosOcio;
        private int _porcentaje;
        private string _reporte;

        public Form1()
        {
            InitializeComponent();

            _ciclosOcio = 0;
            _porcentaje = 0;
            _reporte = string.Empty;
            bttonMostrarProcesos.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttonComenzar_Click(object sender, EventArgs e)
        {
            cola = new ColaQueue();
            
            txtReporte.Text = string.Empty;
            txtNumProFaltantes.Text = string.Empty;
            txtListaProFaltantes.Text = string.Empty;
            txtCiclosOcio.Text = string.Empty;
            
            bttonMostrarProcesos.Enabled = false;

            Comenzar();

            bttonMostrarProcesos.Enabled = true;
        }

        private void bttonMostrarProcesos_Click(object sender, EventArgs e)
        {
            txtReporte.Text = _reporte;
            txtNumProFaltantes.Text = Convert.ToString(cola.Count);
            txtListaProFaltantes.Text = cola.ToString();
            txtCiclosOcio.Text = Convert.ToString(_ciclosOcio);
        }

        private void Comenzar()
        {
            int numProceso = 1;
            _ciclosOcio = 0;
            _reporte = string.Empty;
            _porcentaje = porcent.Next(1, 10);

            for (int i = 1; i <= 200; i++)
            {
                _reporte += "=================" + Environment.NewLine
                          + "Ciclo:  " + i + Environment.NewLine;
                
                if (_porcentaje >= 1 && _porcentaje <= 3)
                {
                    int _vidaCiclo = alea.Next(4, 14);
                    Proceso proceso = new Proceso(_vidaCiclo, numProceso++);

                    cola.Enqueue(proceso);   
                }

                if (cola.Peek() != null)
                {
                    if (cola.Peek().VidaProceso == 0)
                    {
                        cola.Dequeue();

                        _reporte += "Proceso: Sin proceso" + Environment.NewLine
                                        + "Ciclos originales: Null" + Environment.NewLine
                                        + "Ciclos restantes:  Null" + Environment.NewLine;
                        _ciclosOcio++; 
                    }
                    else
                    {
                        if (cola.Peek().VidaProceso > 0)
                        {
                            cola.Peek().VidaProceso -= 1;
                            _reporte += cola.Peek().ToString();
                        }
                    }
                }
                else
                {
                    _reporte += "Proceso: Sin proceso" + Environment.NewLine
                                    + "Ciclos originales:  Null" + Environment.NewLine
                                    + "Ciclos restabtes:   Null" + Environment.NewLine;
                    _ciclosOcio++;
                }

                _porcentaje = porcent.Next(1, 10);
            }
        }

        private void txtReporte_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
