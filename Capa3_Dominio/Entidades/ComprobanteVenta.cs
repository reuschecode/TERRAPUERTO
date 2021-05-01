using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    class ComprobanteVenta
    {
        private string idComprobante;
        private int tipo;

        public string IdComprobante { get => idComprobante; set => idComprobante = value; }
        public int Tipo { get => tipo; set => tipo = value; }
    }
}
