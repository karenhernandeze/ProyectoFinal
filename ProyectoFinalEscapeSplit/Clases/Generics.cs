using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEscapeSplit.Clases
{
    class Generics
    {
        public static T Lists<T>(ref T rhs)
        {
            T temp = rhs;


            List<T> lista = new List<T>();

            List<T> lista2 = new List<T>();

            lista.Add(temp);

            foreach (T item in lista)
            {
                //Console.WriteLine("generic"+item);
                lista2.Add(item);


            }

            return temp;

        }


    }
}