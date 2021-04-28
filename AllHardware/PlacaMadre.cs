using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class PlacaMadre
    {
        String Marca; 
        String Modelo;
        String Plataforma; 
        int Puerto; 
        String Tipo_memoria;

        public PlacaMadre(string marca, string modelo, string plataforma, int puerto, string tipo_memoria)
        {
            Marca = marca;
            Modelo = modelo;
            Plataforma = plataforma;
            Puerto = puerto;
            Tipo_memoria = tipo_memoria;
        }
    }
}
