using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    class Monitor
    {
        String Marca; 
        String Modelo; 
        int Resolucion;
        float Peso;
        int Puerto;

        public Monitor(string marca, string modelo, int resolucion, float peso, int puerto)
        {
            Marca = marca;
            Modelo = modelo;
            Resolucion = resolucion;
            Peso = peso;
            Puerto = puerto;
        }
    }
}
