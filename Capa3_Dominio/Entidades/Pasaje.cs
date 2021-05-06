using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    public class Pasaje
    {
        private string idPasaje;
        private Cliente cliente;
        private Viaje viaje;
        private DateTime fecha;
        private int numeroDeAsiento;

        public string IdPasaje { get => idPasaje; set => idPasaje = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int NumeroDeAsiento { get => numeroDeAsiento; set => numeroDeAsiento = value; }
        public Viaje Viaje { get => viaje; set => viaje = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }

        public double CalcularDescuento()
        {
            return 0.0;
        }

        public double CalcularPrecio()
        {
            return 0.0;
        }
    }
}
