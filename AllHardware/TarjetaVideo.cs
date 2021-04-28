using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    class TarjetaVideo
    {
        String Marca;
        String Modelo;
        String Motor_Grafico;
        String Memoria_video; 
        int Interfaz_memoria;

        public TarjetaVideo(string marca, string modelo, string motor_Grafico, string memoria_video, int interfaz_memoria)
        {
            Marca = marca;
            Modelo = modelo;
            Motor_Grafico = motor_Grafico;
            Memoria_video = memoria_video;
            Interfaz_memoria = interfaz_memoria;
        }
    }
}
