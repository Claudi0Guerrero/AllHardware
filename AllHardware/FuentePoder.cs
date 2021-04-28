using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    class FuentePoder
    {
        String Marca;
        String Tipo; 
        int Potencia; 
        float Voltaje;
        float Peso; 

        public FuentePoder(string marca, string tipo, int potencia, float voltaje, float peso)
        {
            Marca = marca;
            Tipo = tipo;
            Potencia = potencia;
            Voltaje = voltaje;
            Peso = peso;
        }
    }
}
