using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEscapeSplit.Clases
{
    public class ArraysOpciones
    {
        public static string[] GetArrayOp()
        {
            string[] lineasop = new string[] { };
            Opcion ops = new Opcion();
            lineasop = ops.LeerTxt();
            string[] lines = new string[] { };
            string[] opciones = new string[] { };
            List<string> listaopciones = new List<string>();
            foreach (string line in lineasop)
            {
                lines = line.Split('+');
                listaopciones.Add(Generics.Lists<string>(ref lines[0]));


            }

            opciones = listaopciones.ToArray();


            return opciones;

        }

        public static string[] GetArrayIndexIns()
        {
            string[] lineasop = new string[] { };
            Opcion ops = new Opcion();
            lineasop = ops.LeerTxt();
            string[] lines = new string[] { };
            string[] indexins = new string[] { };
            List<string> listaindexins = new List<string>();
            foreach (string line in lineasop)
            {
                lines = line.Split('+');
                listaindexins.Add(Generics.Lists<string>(ref lines[1]));


            }

            indexins = listaindexins.ToArray();


            return indexins;

        }
        public static string[] GetArrayopcionestxt()
        {
            string[] lineasop = new string[] { };
            Opcion ops = new Opcion();
            lineasop = ops.LeerTxt();
            string[] lines = new string[] { };
            string[] optext = new string[] { };
            List<string> listaoptxt = new List<string>();
            foreach (string line in lineasop)
            {
                lines = line.Split('+');
                listaoptxt.Add(Generics.Lists<string>(ref lines[2]));


            }

            optext = listaoptxt.ToArray();


            return optext;

        }
    }
}