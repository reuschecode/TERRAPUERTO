using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    class Tripulacion
    {
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string nombres;
        private string dni;
        private DateTime fechaInicioTrabajo;
        private DateTime fechaNacimiento;
        private string idTripulante;
        private int cargo;

        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Dni { get => dni; set => dni = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string IdTripulante { get => idTripulante; set => idTripulante = value; }
        public int Cargo { get => cargo; set => cargo = value; }
        public DateTime FechaInicioTrabajo { get => fechaInicioTrabajo; set => fechaInicioTrabajo = value; }
    }
}
