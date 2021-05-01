using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    class Persona
    {
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string nombres;
        private string dni;
        private DateTime fechaNacimiento;
        private string idPersona;

        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Dni { get => dni; set => dni = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string IdPersona { get => idPersona; set => idPersona = value; }

        public int ObtenerEdad()
        {
            int edad = DateTime.Today.AddTicks(-fechaNacimiento.Ticks).Year - 1;
            return edad;
        }
    }
}
