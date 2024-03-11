using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDeRepaso2
{
    class Alquiler
    {
        int nit;
        string placa;
        DateTime fechaAlquiler;
        DateTime fechaDevoluion;
        int kilometrosRecorridos;

        public int Nit { get => nit; set => nit = value; }
        public string Placa { get => placa; set => placa = value; }
        public DateTime FechaAlquiler { get => fechaAlquiler; set => fechaAlquiler = value; }
        public DateTime FechaDevoluion { get => fechaDevoluion; set => fechaDevoluion = value; }
        public int KilometrosRecorridos { get => kilometrosRecorridos; set => kilometrosRecorridos = value; }
    }
}
