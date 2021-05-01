using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    class Pasaje
    {
        private string idAsiento;
        private string idComprobante;
        private string idPasaje;
        private string idViaje;

        public string IdAsiento { get => idAsiento; set => idAsiento = value; }
        public string IdComprobante { get => idComprobante; set => idComprobante = value; }
        public string IdPasaje { get => idPasaje; set => idPasaje = value; }
        public string IdViaje { get => idViaje; set => idViaje = value; }
    }
}
