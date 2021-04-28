using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    class Gabinete
    {
        String Marca; 
        String Modelo;
        int Puerto_expansion; 
        float Peso;
        String Material;

        public Gabinete(string marca, string modelo, int puerto_expansion, float peso, string material)
        {
            Marca = marca;
            Modelo = modelo;
            Puerto_expansion = puerto_expansion;
            Peso = peso;
            Material = material;
        }
    }
}
