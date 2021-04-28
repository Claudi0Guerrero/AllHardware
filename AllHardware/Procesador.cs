using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    class Procesador
    {
        String Marca; 
        String Modelo; 
        String Zocalo; 
        int Nucleo; 
        int Hilos; 
        String Frecuencia_reloj;

        public Procesador(string marca, string modelo, string zocalo, int nucleo, int hilos, string frecuencia_reloj)
        {
            Marca = marca;
            Modelo = modelo;
            Zocalo = zocalo;
            Nucleo = nucleo;
            Hilos = hilos;
            Frecuencia_reloj = frecuencia_reloj;
        }
    }
}
