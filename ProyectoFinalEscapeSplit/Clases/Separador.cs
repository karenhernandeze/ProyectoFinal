using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalEscapeSplit.Items;
//using ProyectoFinalEscapeSplit.Items.Utilidades;
using ProyectoFinalEscapeSplit.Items.Utilidades;

namespace ProyectoFinalEscapeSplit.Clases
{
    public class Separador
    {



        //public Items.Jugador jugador = new Items.Jugador("jugador", true);

        //public Items.Secuestrador secuestrador = new Items.Secuestrador("Kevin");
        public static int SortArrays()
        {
            string[] instrucciones = Arrays.GetArrayins();
            string[] opcionesA = Arrays.GetArrayop1();
            string[] opcionesB = Arrays.GetArrayop2();
            string[] instruccionestxt = Arrays.GetArrayinstxt();
            string[] opciones = ArraysOpciones.GetArrayOp();
            string[] indexins = ArraysOpciones.GetArrayIndexIns();
            string[] optext = ArraysOpciones.GetArrayopcionestxt();
            int i = 0;
            Console.WriteLine(Descripcion.LeerTexto());


             Tiempo tiempo = new Tiempo(240);
                
             Secuestrador secuestrador = new Secuestrador("kevin");
             Jugador jugador1 = new Jugador("jugador", true);
            while (i < instrucciones.Length)
            {

            ValorI:
                    
                    
                Console.WriteLine("\n"+instruccionestxt[int.Parse(instrucciones[i])]);
                int temp = int.Parse(instrucciones[i]);

                Console.Write("Flecha izquierda:\t\t\t");

                Console.WriteLine("Flecha derecha: ");

                Console.Write("{0}\t\t\t", optext[int.Parse(opcionesA[i])]);
                int tempA = int.Parse(opcionesA[i]);

                //Console.Write("Flecha derecha: \t");
                Console.WriteLine(optext[int.Parse(opcionesB[i])]+"\n");
                int tempB = int.Parse(opcionesB[i]);
                //tablero.Perder();

                int tempA2;
                int tempB2;
                ConsoleKeyInfo KeyInfo;
                int timeconsole;

                KeyInfo = Console.ReadKey(true);
                switch (KeyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:

                        if (tempA == 0)
                        {

                            Console.WriteLine(Descripcion.LeerTexto());
                        }

                        //Console.WriteLine(instruccionestxt[int.Parse(indexins[tempA])];
                        tempA2 = int.Parse(indexins[tempA]);
                        if (tempA2 == 2 || tempA2 == 6 )
                        {

                             timeconsole=secuestrador.SAtaca(tiempo);
                            Console.WriteLine("\nPerdiste tiempo, tiempo={0}\n",timeconsole);
                            //if (timeconsole < 0)
                            //{
                            //    jugador1.Vida = false;
                            //}

                            Separador.Gameover(jugador1.Vida);
                        }
                        if (tempA2 == 7 || tempA2 == 8)
                        {

                            timeconsole = secuestrador.SAtaca(tiempo);
                            Console.WriteLine("\nPerdiste tiempo, tiempo={0}\n", timeconsole);
                            //if (timeconsole < 0)
                            //{
                            //    jugador1.Vida = false;
                            //}

                            Separador.Gameover(jugador1.Vida);
                        }
                        if (tempA2 == 11 || tempA2 == 13)
                        {

                            timeconsole = secuestrador.SAtaca(tiempo);
                            Console.WriteLine("\nPerdiste tiempo, tiempo={0}\n", timeconsole);
                            //if (timeconsole < 0)
                            //{
                            //    jugador1.Vida = false;
                            //}

                            Separador.Gameover(jugador1.Vida);
                        }
                        if (tempA2 == 14 || tempA2 == 16)
                        {

                            timeconsole = secuestrador.SAtaca(tiempo);
                            Console.WriteLine("\nPerdiste tiempo, tiempo={0}\n", timeconsole);
                            //if (timeconsole < 0)
                            //{
                            //    jugador1.Vida = false;
                            //}

                            Separador.Gameover(jugador1.Vida);
                        }
                        if (tempA2 == 18)
                        {

                            timeconsole = secuestrador.SAtaca(tiempo);
                            Console.WriteLine("\nPerdiste tiempo, tiempo={0}\n", timeconsole);
                            //if (timeconsole < 0)
                            //{
                            //    jugador1.Vida = false;
                            //}

                            Separador.Gameover(jugador1.Vida);
                        }

                        //if (tempA == 6)
                        //{
                        //    int timeconsole = secuestrador.SAtaca(tiempo);
                        //    Console.WriteLine("perdiste tiempo, tiempo={0}", timeconsole);
                        //    Separador.Gameover(jugador1.Vida);
                        //}
                        //Console.WriteLine("TEMP A2: " + tempA2);
                        i = tempA2;
                        goto ValorI;

                    case ConsoleKey.RightArrow:
                        //Console.WriteLine(instruccionestxt[int.Parse(indexins[tempB])]);
                        tempB2 = int.Parse(indexins[tempB]);
                        if (tempB2 == 2 || tempB2 == 6)
                        {

                            timeconsole = secuestrador.SAtaca(tiempo);
                            Console.WriteLine("\nPerdiste tiempo, tiempo={0}\n", timeconsole);
                            //if (timeconsole < 0)
                            //{
                            //    jugador1.Vida = false;
                            //}

                            Separador.Gameover(jugador1.Vida);
                        }
                        if (tempB2 == 7 || tempB2 == 8)
                        {

                            timeconsole = secuestrador.SAtaca(tiempo);
                            Console.WriteLine("\nPerdiste tiempo, tiempo={0}\n", timeconsole);
                            //if (timeconsole < 0)
                            //{
                            //    jugador1.Vida = false;
                            //}

                            Separador.Gameover(jugador1.Vida);
                        }
                        if (tempB2 == 11 || tempB2 == 13)
                        {

                            timeconsole = secuestrador.SAtaca(tiempo);
                            Console.WriteLine("\nPerdiste tiempo, tiempo={0}\n", timeconsole);
                            //if (timeconsole < 0)
                            //{
                            //    jugador1.Vida = false;
                            //}

                            Separador.Gameover(jugador1.Vida);
                        }
                        if (tempB2 == 14 || tempB2 == 16)
                        {

                            timeconsole = secuestrador.SAtaca(tiempo);
                            Console.WriteLine("\nPerdiste tiempo, tiempo={0}\n", timeconsole);
                            //if (timeconsole < 0)
                            //{
                            //    jugador1.Vida = false;
                            //}

                            Separador.Gameover(jugador1.Vida);
                        }
                        if (tempB2 == 18)
                        {

                            timeconsole = secuestrador.SAtaca(tiempo);
                            Console.WriteLine("\nPerdiste tiempo, tiempo={0}\n", timeconsole);
                            //if (timeconsole < 0)
                            //{
                            //    jugador1.Vida = false;
                            //}

                            Separador.Gameover(jugador1.Vida);
                        }
                        //if (tempB2 == 6)
                        //{
                        //    int timeconsole = secuestrador.SAtaca(tiempo);
                        //    Console.WriteLine("perdiste tiempo, tiempo={0}", timeconsole);
                        //    Separador.Gameover(jugador1.Vida);
                        //}
                        //Console.WriteLine("TEMP B2: " + tempB2);
                        //int tempB2 = i; 
                        i = tempB2;
                        goto ValorI;


                }



            }

            return i; 
        }

        public static void Gameover(bool vida)
        {
            Jugador jugador1 = new Jugador("jugador", true);
            Secuestrador secuestrador = new Secuestrador("kevin");
            Tiempo tiempo = new Tiempo(240);
            jugador1.Vivir(secuestrador.SAtaca(tiempo));
            if (jugador1.Vivir(secuestrador.SAtaca(tiempo)) == false)
            {
                Console.WriteLine("Moriste");
                Environment.Exit(0);

            }
           
        }
    }
}