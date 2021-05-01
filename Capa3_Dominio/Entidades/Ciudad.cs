using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    class Ciudad
    {
        private string direccion;
        private string idCiudad;
        private string nombre;

        public string Direccion { get => direccion; set => direccion = value; }
        public string IdCiudad { get => idCiudad; set => idCiudad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
