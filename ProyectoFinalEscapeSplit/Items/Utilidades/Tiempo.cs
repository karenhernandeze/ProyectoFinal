using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEscapeSplit.Items.Utilidades
{
    public class Tiempo: Objetos
    {
        //Jugador jugador;
        public string name;
        public bool vida;
        public static int Contador { get; set; }

        public Tiempo(int contador): base(contador)
        {
            Contador = contador;
            // jugador = new Jugador("Jugador1",vida);
        }

        public int PerderTiempo()
        {
            Contador = Contador - 10;
            return Contador;
        }
    }
}