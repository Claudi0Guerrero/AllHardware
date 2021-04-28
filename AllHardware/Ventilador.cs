using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    class Ventilador
    {
        String Marca; 
        String Modelo; 
        String Material; 
        float Peso;
        int tamaño;
        int Voltaje;

        public Ventilador(string marca, string modelo, string material, float peso, int tamaño, int voltaje)
        {
            Marca = marca;
            Modelo = modelo;
            Material = material;
            Peso = peso;
            this.tamaño = tamaño;
            Voltaje = voltaje;
        }
    }
}
