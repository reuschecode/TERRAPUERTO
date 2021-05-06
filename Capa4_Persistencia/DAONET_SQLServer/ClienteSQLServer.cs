using System;
using System.Data.SqlClient;
using Capa3_Dominio.Entidades;

namespace Capa4_Persistencia.DAONET_SQLServer
{
    public class ClienteSQLServer
    {
        private GestorSQLServer gestorSQL;

        public ClienteSQLServer(GestorSQLServer gestorSQL)
        {
            this.gestorSQL = gestorSQL;
        }

        public Cliente BuscarClientePorDNI(string dni)
        {
            Cliente cliente;
            string query = "select * from Cliente where dni = '"+ dni + "';";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(query);
                if (resultadoSQL.Read())
                {
                    cliente = ObtenerCliente(resultadoSQL);
                }
                else
                {
                    throw new Exception("No existe el cliente.");
                }
            }
            catch(Exception err)
            {
                throw err;
            }
            return cliente;
        }

        public void GuardarCliente(Cliente cliente)
        {
            string query = "insert into Cliente values ('" +
                cliente.TipoDocumento + "','" +
                cliente.CodigoDocumento + "','" +
                cliente.Nombres + "','" +
                cliente.ApellidoPaterno + "','" +
                cliente.ApellidoMaterno + "','" +
                cliente.FechaNacimiento.ToString() + "',')";
            try
            {
                SqlDataReader resultado = gestorSQL.EjecutarConsulta(query);
            }
            catch(Exception err)
            {
                throw err;
            }
        }

        private Cliente ObtenerCliente(SqlDataReader resultadoSQL)
        {
            Cliente cliente = new Cliente();
            cliente.TipoDocumento = resultadoSQL.GetString(0);
            cliente.CodigoDocumento = resultadoSQL.GetString(1);
            cliente.Nombres = resultadoSQL.GetString(2);
            cliente.ApellidoPaterno = resultadoSQL.GetString(3);
            cliente.ApellidoMaterno = resultadoSQL.GetString(4);
            cliente.FechaNacimiento = resultadoSQL.GetDateTime(5);
            return cliente;
        }
    }
}
