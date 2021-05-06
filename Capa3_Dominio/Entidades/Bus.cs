using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    class Bus
    {
        private string idBus;
        private int modelo;
        private string placa;
        private int servicio;
        private int cantidadDeAsientos;

        public string IdBus { get => idBus; set => idBus = value; }
        public int Modelo { get => modelo; set => modelo = value; }
        public string Placa { get => placa; set => placa = value; }
        public int Servicio { get => servicio; set => servicio = value; }
        public int CantidadDeAsientos { get => cantidadDeAsientos; set => cantidadDeAsientos = value; }
    }
}
