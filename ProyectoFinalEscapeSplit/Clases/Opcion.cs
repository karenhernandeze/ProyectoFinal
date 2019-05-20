using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalEscapeSplit.Interfaces;
using System.IO;

namespace ProyectoFinalEscapeSplit.Clases
{
    class Opcion : AbstractLeerText
    {
        public override string[] LeerTxt()
        {
            try
            {
                string[] linesInstr = System.IO.File.ReadAllLines("OpcionesFinales.txt");
                return linesInstr;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
                return null;
            }

        }
    }
}