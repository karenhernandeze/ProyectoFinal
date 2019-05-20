using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalEscapeSplit.Interfaces;

namespace ProyectoFinalEscapeSplit.Clases
{
    public class Descripcion
    {
        public static string LeerTexto()
        {
            string lines = System.IO.File.ReadAllText("Descripcion.txt");
            return lines;
        }
    }
}