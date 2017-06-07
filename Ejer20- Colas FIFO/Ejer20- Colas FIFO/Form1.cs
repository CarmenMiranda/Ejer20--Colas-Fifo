using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer20__Colas_FIFO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Procesador procesador = new Procesador();
            procesador.atencion();
            txtCiclosColaVacía.Text = Convert.ToString(procesador.colaVacía);
            txtProcesosPendientes.Text = Convert.ToString(procesador.procesosPendientes);
            txtSumaCiclos.Text = Convert.ToString(procesador.sumaCiclosPendientes);
            
        }
    }
}
