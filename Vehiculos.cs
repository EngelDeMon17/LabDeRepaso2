using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDeRepaso2
{
    class Vehiculos
    {
        string placa;
        string marca;
        string modelo;
        string color;
        int precioKilometro;

        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public int PrecioKilometro { get => precioKilometro; set => precioKilometro = value; }
    }
}
