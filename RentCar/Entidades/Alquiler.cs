using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alquiler
    {
        public string IdAlquiler { get; set; }
        public string PlacaVehiculo { get; set; }
        public double KmEntrega { get; set; }
        public double KmRecepcion { get; set; }
        public double KmRecorridos { get; set; }
        public double ValorKm { get; set; }
        public double Descuento { get; set; }
        public double Total { get; set; }
        public DateTime FechaDeEntrega { get; set; }
        public DateTime FechaDeRecepcion { get; set; }
        public string IdCliente { get; set; }

        public Alquiler()
        {

        }

        public Alquiler(string idalquiler, string placavehiculo, double kmentrega, double kmrecepcion,
            double valorkm, double descuento, double total, DateTime fechadeentrega, DateTime fechaderecepcion, string idcliente)
        {
            IdAlquiler = idalquiler;
            PlacaVehiculo = placavehiculo;
            KmEntrega = kmentrega;
            KmRecepcion = kmrecepcion;
            ValorKm = valorkm;
            Descuento = descuento;
            Total = total;
            FechaDeEntrega = fechadeentrega;
            FechaDeRecepcion = fechaderecepcion;
            IdCliente = idcliente;
        }
    }
}
