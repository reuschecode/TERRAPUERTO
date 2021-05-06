using System;

namespace Capa3_Dominio.Entidades
{
    public class Cliente
    {
        private string tipoDocumento;
        private string codigoDocumento;
        private string nombres;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private DateTime fechaNacimiento;

        public string Nombres { get => nombres; set => nombres = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string TipoDocumento { get => tipoDocumento; set => tipoDocumento = value; }
        public string CodigoDocumento { get => codigoDocumento; set => codigoDocumento = value; }

        public bool ValidarDocumento()
        {
            switch (tipoDocumento)
            {
                case "DNI":
                    return codigoDocumento.Length == 8;
                case "Carné de Extranjería":
                    return codigoDocumento.Length == 12;
                case "Pasaporte":
                    return codigoDocumento.Length == 12;
                default:
                    return false;
            }
        }

        public int ObtenerEdad()
        {
            return DateTime.Today.AddTicks(-fechaNacimiento.Ticks).Year - 1;
        }
    }
}
