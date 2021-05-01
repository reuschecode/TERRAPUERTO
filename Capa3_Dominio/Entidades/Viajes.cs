using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    class Viajes
    {
        private string ciudadDesembarque;
        private string ciudadEmbarque;
        private DateTime fechaLlegada;
        private DateTime fechaSalida;
        private string idBus;
        private string idViaje;
        private double precio;

        public string CiudadDesembarque { get => ciudadDesembarque; set => ciudadDesembarque = value; }
        public string CiudadEmbarque { get => ciudadEmbarque; set => ciudadEmbarque = value; }
        public DateTime FechaLlegada { get => fechaLlegada; set => fechaLlegada = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public string IdBus { get => idBus; set => idBus = value; }
        public string IdViaje { get => idViaje; set => idViaje = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
