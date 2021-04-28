using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    class Teclado
    {
       String Marca;
       String Modelo; 
       float Peso;
       int Matriz;
       int memoria_integrada;

        public Teclado(string marca, string modelo, float peso, int matriz, int memoria_integrada)
        {
            Marca = marca;
            Modelo = modelo;
            Peso = peso;
            Matriz = matriz;
            this.memoria_integrada = memoria_integrada;
        }
    }
}
