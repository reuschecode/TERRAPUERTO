using System;
using System.Data.SqlClient;
using Capa3_Dominio.Entidades;

namespace Capa4_Persistencia.DAONET_SQLServer
{
    public class PasajeSQLServer
    {
        private GestorSQLServer gestorSQL;

        public PasajeSQLServer(GestorSQLServer gestorSQL)
        {
            this.gestorSQL = gestorSQL;
        }

        public void GuardarPasaje(Pasaje pasaje)
        {
            string query = "insert into Pasaje "+
                "(idCliente, idViaje, fecha, precio, numeroAsiento) values ('" +
                pasaje.Cliente.CodigoDocumento+ "','" +
                pasaje.Viaje.IdViaje + "','" +
                pasaje.Fecha.ToString() + "','" +
                pasaje.CalcularPrecio() + "','" +
                pasaje.NumeroDeAsiento + "',')";
            try
            {
                SqlDataReader resultado = gestorSQL.EjecutarConsulta(query);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        private Pasaje ObtenerProducto(SqlDataReader resultadoSQL)
        {
            Pasaje pasaje = new Pasaje();
            pasaje.IdPasaje = resultadoSQL.GetString(0);
            //pasaje.IdCliente = resultadoSQL.GetString(1);
            //pasaje.IdViaje = resultadoSQL.GetString(2);
            pasaje.Fecha = resultadoSQL.GetDateTime(3);
            //pasaje.Precio = float.Parse(resultadoSQL.GetDecimal(4).ToString());
            pasaje.NumeroDeAsiento = resultadoSQL.GetInt32(5);
            return pasaje;

        }
    }
}
