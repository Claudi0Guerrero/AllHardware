using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    class DiscoDuro
    {
        String Marca; 
        String Tipo;
        String Serie;
        String Modelo;
        String Capacidad;
        int Velocidad; 
        int Peso;

        public DiscoDuro(string marca, string tipo, string serie, string modelo, string capacidad, int velocidad, int peso)
        {
            Marca = marca;
            Tipo = tipo;
            Serie = serie;
            Modelo = modelo;
            Capacidad = capacidad;
            Velocidad = velocidad;
            Peso = peso;
        }
    }
}
