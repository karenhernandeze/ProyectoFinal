using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalEscapeSplit.Clases;

namespace ProyectoFinalEscapeSplit.Clases
{
    public class Arrays
    {
        Instrucciones instrucciones;
        public Arrays()
        {
            instrucciones = new Instrucciones();
        }
        ArraysOpciones Arraysopciones;
        public Arrays(ArraysOpciones ArraysopcionesL)
        {
            Arraysopciones = ArraysopcionesL;
        }

        public static string[] GetArrayins() //ARRAY DONDE ESTÁN LOS INDICES DEL NUMERO DE INSTRUCCION QUE SE VA A EJECUTAR 
        {
            string[] lineasInstr = new string[] { };
            Instrucciones inst = new Instrucciones();
            lineasInstr = inst.LeerTxt();
            string[] lines = new string[] { };
            string[] instrucciones = new string[] { };
            List<string> listainstrucciones = new List<string>();
            foreach (string line in lineasInstr)
            {
                lines = line.Split('+');
                listainstrucciones.Add(Generics.Lists<string>(ref lines[0]));



            }
            instrucciones = listainstrucciones.ToArray();


            //instrucciones = listainstrucciones.ToArray();

            //Console.WriteLine(instrucciones.GetLength(0));
            return instrucciones;
        }


        public static string[] GetArrayop1() //ARRAY DONDE ESTÁN LOS INDICES DEL NUMERO DE INSTRUCCION QUE SE VA A EJECUTAR 
        {
            string[] lineasOP = new string[] { };
            Instrucciones inst1 = new Instrucciones();
            lineasOP = inst1.LeerTxt();
            string[] lines = new string[] { };
            string[] opcionesA = new string[] { };
            List<string> listaopcionesA = new List<string>();
            foreach (string line in lineasOP)
            {
                lines = line.Split('+');
                listaopcionesA.Add(Generics.Lists<string>(ref lines[1]));


            }

            opcionesA = listaopcionesA.ToArray();

            return opcionesA;

        }


        public static string[] GetArrayop2()
        {

            string[] lineasOp = new string[] { };
            Instrucciones inst2 = new Instrucciones();
            lineasOp = inst2.LeerTxt();
            string[] lines = new string[] { };
            string[] opcionesB = new string[] { };
            List<string> listaopcionesB = new List<string>();
            foreach (string line in lineasOp)
            {
                lines = line.Split('+');
                listaopcionesB.Add(Generics.Lists<string>(ref lines[2]));


            }

            opcionesB = listaopcionesB.ToArray();


            return opcionesB;

        }


        public static string[] GetArrayinstxt()
        {
            string[] lineastxt = new string[] { };
            Instrucciones inst3 = new Instrucciones();
            lineastxt = inst3.LeerTxt();
            string[] lines = new string[] { };
            string[] instruccionestxt = new string[] { };
            List<string> listainstxt = new List<string>();
            foreach (string line in lineastxt)
            {
                lines = line.Split('+');
                listainstxt.Add(Generics.Lists<string>(ref lines[3]));


            }

            instruccionestxt = listainstxt.ToArray();


            return instruccionestxt;

        }
    }
}