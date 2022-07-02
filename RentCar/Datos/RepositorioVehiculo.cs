using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatosDAO;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class RepositorioVehiculo : ConexionBD, ICRUD<Vehiculo>
    {
        public string Actualizar(Vehiculo obj)
        {
            throw new NotImplementedException();
        }

        public Vehiculo BuscarID(string id)
        {
            throw new NotImplementedException();
        }

        public string Eliminar(Vehiculo obj)
        {
            throw new NotImplementedException();
        }

        public string Insertar(Vehiculo obj)
        {
            string _sql= string.Format("insert into Vehiculos (Placa, Marca, KilometrajeActual) values ('{0}', '{1}', {2})",obj.PlacaVehiculo, obj.Marca, obj.KilometrajeActual);
            var cmd = new SqlCommand(_sql, conexion);
            AbrirConnexion();
            int filas= cmd.ExecuteNonQuery();
            CerrarConnexion();
            if (filas==1)
            {
                return "se agrego el registro del vehiculo placa :" + obj.PlacaVehiculo;
            }
            return "vehiculo placa :" + obj.PlacaVehiculo + "No agregado";
        }

        public List<Vehiculo> Todos(string obj)
        {
            string _sql = string.Format("select * from vehiculos");
            var cmd = new SqlCommand(_sql, conexion);
            AbrirConnexion();
            var listaVehiculos = new List<Entidades.Vehiculo>();

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var vehiculo = new Entidades.Vehiculo(reader.GetString(0), reader.GetString(1), reader.GetInt32(2));
                listaVehiculos.Add(vehiculo);
            }
            CerrarConnexion();
            return listaVehiculos;
        }
        Vehiculo Map()
        {
            return new Vehiculo();
        }
    }
}