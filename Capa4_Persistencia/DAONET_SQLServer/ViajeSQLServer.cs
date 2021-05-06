using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Capa3_Dominio.Entidades;

namespace Capa4_Persistencia.DAONET_SQLServer
{
    public class ViajeSQLServer
    {
        private GestorSQLServer gestorSQL;

        public ViajeSQLServer(GestorSQLServer gestorSQL)
        {
            this.gestorSQL = gestorSQL;
        }

        public List<Viaje> ObtenerViajesDisponibles()
        {
            List<Viaje> listaDeViajes = new List<Viaje>();
            Viaje viaje;
            string query = "select * from Viaje";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(query);
                while (resultadoSQL.Read())
                {
                    viaje = ObtenerViaje(resultadoSQL);
                    listaDeViajes.Add(viaje);
                }
            }
            catch(Exception err)
            {
                throw err;
            }
            return listaDeViajes;
        }

        public List<Viaje> ObtenerViajesEntreCiudades(string embarque, string desembarque)
        {
            List<Viaje> listaDeViajes = new List<Viaje>();
            Viaje viaje;
            string query = "select * from Viaje where ciudadEmbarque = '" + embarque +
                "' and ciudadDesembarque = '"+ desembarque +"'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(query);
                while (resultadoSQL.Read())
                {
                    viaje = ObtenerViaje(resultadoSQL);
                    listaDeViajes.Add(viaje);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return listaDeViajes;
        }

        public List<Viaje> ObtenerViajesEntreCiudadYFecha(string embarque, string desembarque, DateTime ida)
        {
            List<Viaje> listaDeViajes = new List<Viaje>();
            Viaje viaje;
            string query = "select * from Viaje where FechaSalida = '"+ ida.ToString() 
                +"and ciudadEmbarque = '"+ embarque +"' and ciudadDesembarque = '"+ desembarque +"'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(query);
                while (resultadoSQL.Read())
                {
                    viaje = ObtenerViaje(resultadoSQL);
                    listaDeViajes.Add(viaje);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return listaDeViajes;
        }

        public List<int> ObtenerAsientosOcupadosDeViaje(string codigoViaje)
        {
            List<int> listaAsientosOcupados = new List<int>();
            int numeroAsiento;
            string query = "select P.numeroAsiento from Viaje V, Pasaje P where V.idViaje = P.idViaje and " +
                "V.idViaje = '"+codigoViaje+"'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(query);
                while (resultadoSQL.Read())
                {
                    numeroAsiento = resultadoSQL.GetInt32(0);
                    listaAsientosOcupados.Add(numeroAsiento);
                }
            }
            catch(Exception err)
            {
                throw err;
            }
            return listaAsientosOcupados;
        }

        private Viaje ObtenerViaje(SqlDataReader resultadoSQL)
        {
            Viaje viaje = new Viaje();
            viaje.IdViaje = resultadoSQL.GetInt32(0);
            //viaje.IdBus = resultadoSQL.GetString(1);
            viaje.FechaSalida = resultadoSQL.GetDateTime(2);
            viaje.FechaLlegada = resultadoSQL.GetDateTime(3);
            viaje.CiudadEmbarque = resultadoSQL.GetString(4);
            viaje.CiudadDesembarque = resultadoSQL.GetString(5);
            viaje.Precio = resultadoSQL.GetDouble(6);
            return viaje;
        }
    }
}
