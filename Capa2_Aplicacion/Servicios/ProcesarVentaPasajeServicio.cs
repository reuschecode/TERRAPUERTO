using System;
using System.Collections.Generic;
using Capa3_Dominio.Entidades;
using Capa3_Dominio.Servicios;
using Capa4_Persistencia.DAONET_SQLServer;

namespace Capa2_Aplicacion.Servicios
{
    public class ProcesarVentaPasajeServicio
    {
        private Pasaje pasaje;
        private Cliente cliente;
        private GestorSQLServer gestorAccesoDatos;
        private PasajeSQLServer pasajeDAO;
        private ClienteSQLServer clienteDAO;
        private ViajeSQLServer viajeDAO;

        public Pasaje Pasaje { get => pasaje; set => pasaje = value; }

        public ProcesarVentaPasajeServicio()
        {
            pasaje = new Pasaje();
            gestorAccesoDatos = new GestorSQLServer();
            pasajeDAO = new PasajeSQLServer(gestorAccesoDatos);
            clienteDAO = new ClienteSQLServer(gestorAccesoDatos);
            viajeDAO = new ViajeSQLServer(gestorAccesoDatos);
        }

        public void AgregarPasaje()
        {

        }

        public Cliente BuscarCliente(string documento, string codigoDocumento)
        {

            return cliente;
        }

        public List<Viaje> BuscarTodosViajes()
        {
            return viajeDAO.ObtenerViajesDisponibles();
        }

        public List<Viaje> BuscarViajesEntreCiudades(string embarque, string desembarque)
        {
            return viajeDAO.ObtenerViajesEntreCiudades(embarque, desembarque);
        }

        public List<Viaje> BuscarViajesEntreCiudadesYFechas(string embarque, string desembarque, DateTime ida)
        {
            return viajeDAO.ObtenerViajesEntreCiudadYFecha(embarque, desembarque, ida); //Falta implementar retorno
        }

        public List<Viaje> BuscarPasajes(string embarque, string desembarque) 
        {
            List<Viaje> viajes = new List<Viaje>();
            return viajes;
        }
    }
}
