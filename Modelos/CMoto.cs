using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copia_practica_2.Modelos
{
    class CMoto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Freno { get; set; }
        public string Peso { get; set; }
        public string Capacidad { get; set; }
        public string Dimensiones { get; set; }
        public string Transmision { get; set; }

        public CMoto() { }

        public override string ToString()
        {
            return $"Nombre: {Nombre} \nPrecio: US${Precio} \nCapacidad del tanque: {Capacidad} \nPeso: {Peso} \nFreno: {Freno} \nTransmisición: {Transmision} \nDimensiones {Dimensiones}";
        }

    }
}
