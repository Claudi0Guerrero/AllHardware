using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    class MemoriaRam
    {
        String Marca;
        String Tipo;
        int Capacidad;
        int Voltaje;

        public MemoriaRam(string marca, string tipo, int capacidad, int voltaje)
        {
            Marca = marca;
            Tipo = tipo;
            Capacidad = capacidad;
            Voltaje = voltaje;
        }
    }
}
