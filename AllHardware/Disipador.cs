using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    class Disipador
    {
        String Marca;
        String Modelo; 
        String Material; 
        String Resistencia_termica;
        float Peso; 

        public Disipador(string marca, string modelo, string material, string resistencia_termica, float peso)
        {
            Marca = marca;
            Modelo = modelo;
            Material = material;
            Resistencia_termica = resistencia_termica;
            Peso = peso; 
        }
    }
}
