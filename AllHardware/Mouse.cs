using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    class Mouse
    {
        String Marca;
        String Modelo;
        int Dpi;
        float Peso;
        int Botones;

        public Mouse(string marca, string modelo, int dpi, float peso, int botones)
        {
            Marca = marca;
            Modelo = modelo;
            Dpi = dpi;
            Peso = peso;
            Botones = botones;
        }
    }
}
