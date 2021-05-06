using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Capa2_Aplicacion.Servicios;
using Capa3_Dominio.Entidades;

namespace Capa1_Presentacion.WinForms
{
    public partial class FormProcesoVentaPasaje : Form
    {
        private ProcesarVentaPasajeServicio procesarVentaPasajeServicio;
        private Cliente cliente;
        public FormProcesoVentaPasaje()
        {
            InitializeComponent();
            IniciarProcesoVentaPasaje();
        }

        private void IniciarProcesoVentaPasaje()
        {
            cliente = null;
            procesarVentaPasajeServicio = new ProcesarVentaPasajeServicio();
        }

        private void AgregarColumnas()
        {
            dgvViajes.Columns.Add("ID", "ID");
            dgvViajes.Columns.Add("Ciudad Embarque", "Ciudad Embarque");
            dgvViajes.Columns.Add("Ciudad Desembarque", "Ciudad Desembarque");
            dgvViajes.Columns.Add("Fecha Salida", "Fecha Salida");
            dgvViajes.Columns.Add("Fecha Llegada", "Fecha Llegada");
            dgvViajes.Columns.Add("Asientos Disponibles", "Asientos Disponibles");
        }

        private void FormProcesoVentaPasaje_Load(object sender, EventArgs e)
        {
            try
            {
                List<Viaje> listaDeViajes = procesarVentaPasajeServicio.BuscarTodosViajes();
                dgvViajes.Rows.Clear();
                AgregarColumnas();
                foreach (Viaje viaje in listaDeViajes)
                {
                    object[] filaProducto = { viaje.IdViaje, viaje.CiudadEmbarque, viaje.CiudadDesembarque, viaje.FechaSalida, viaje.FechaLlegada, viaje.AsientosDisponibles() };
                    dgvViajes.Rows.Add(filaProducto);
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema Terrapuerto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = dtpIda.Value != dtpRetorno.Value;
            try
            {
                List<Viaje> listaDeViajes = flag ? 
                    procesarVentaPasajeServicio.BuscarViajesEntreCiudades(comboBoxEmbarque.Text, comboBoxDesembarque.Text) : 
                    procesarVentaPasajeServicio.BuscarViajesEntreCiudadesYFechas(comboBoxEmbarque.Text, comboBoxDesembarque.Text, dtpIda.Value);
                dgvViajes.Rows.Clear();
                foreach (Viaje viaje in listaDeViajes)
                {
                    object[] filaProducto = { viaje.IdViaje, viaje.CiudadEmbarque, viaje.CiudadDesembarque, viaje.FechaSalida, viaje.FechaLlegada, viaje.AsientosDisponibles() };
                    dgvViajes.Rows.Add(filaProducto);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.InnerException.Message, "Sistema Terrapuerto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvViajes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvViajes[0, e.RowIndex].Value.ToString();
        }
    }
}
