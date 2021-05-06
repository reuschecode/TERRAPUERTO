using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa1_Presentacion.WinForms
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ventaPasajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProcesoVentaPasaje formProcesarVentaPasaje = new FormProcesoVentaPasaje();
            formProcesarVentaPasaje.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
