using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    class Asiento
    {
        private bool estado;
        private string idAsiento;
        private int numero;

        public bool Estado { get => estado; set => estado = value; }
        public string IdAsiento { get => idAsiento; set => idAsiento = value; }
        public int Numero { get => numero; set => numero = value; }
    }
}
