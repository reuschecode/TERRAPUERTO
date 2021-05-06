using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    public class Viaje
    {
        private string ciudadDesembarque;
        private string ciudadEmbarque;
        private DateTime fechaLlegada;
        private DateTime fechaSalida;
        private Bus bus;
        private int idViaje;
        private double precio;
        private int asientosOcupados;

        public string CiudadDesembarque { get => ciudadDesembarque; set => ciudadDesembarque = value; }
        public string CiudadEmbarque { get => ciudadEmbarque; set => ciudadEmbarque = value; }
        public DateTime FechaLlegada { get => fechaLlegada; set => fechaLlegada = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        internal Bus Bus { get => bus; set => bus = value; }
        public int IdViaje { get => idViaje; set => idViaje = value; }
        public double Precio { get => precio; set => precio = value; }

        public int AsientosDisponibles()
        {
            //return Bus.CantidadDeAsientos - asientosOcupados;
            return 10;
        }

    }
}
