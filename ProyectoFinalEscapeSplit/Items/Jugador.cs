using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalEscapeSplit.Items.Utilidades;

namespace ProyectoFinalEscapeSplit.Items
{
    public class Jugador : Personas
    {
        Secuestrador secuestrador1;
        Clases.Separador separador;
        public Jugador()
        {
            separador = new Clases.Separador();

        }

        public Jugador(Secuestrador secuestrador1l)
        {
            secuestrador1 = secuestrador1l;
        }

        public bool Vida { get; set; }
        public Secuestrador secuestrador = new Secuestrador("Kevin");

        //public Tiempo tiempo1 = new Tiempo(240);
        //int tiempo2 = Tiempo.Contador;

        string Name; 
        public Jugador(string name, bool vida = true):base(name)
        {
            Vida = vida;
            Name = name;



        }

        public bool Vivir(int tiempo)
        {



            //int contador = secuestrador.SAtaca(tiempo1);
            if (Tiempo.Contador <= 0)
            {
                Vida = false;
            }
            return Vida;
        }


    }
}