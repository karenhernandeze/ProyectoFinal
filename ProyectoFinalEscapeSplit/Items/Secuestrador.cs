using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalEscapeSplit.Items.Utilidades;

namespace ProyectoFinalEscapeSplit.Items
{
    public class Secuestrador : Personas
    {
        int tiempo2;

        public Secuestrador()
        {

        }

        public Secuestrador(string name)
        {
            name = "Kevin";

        }

        public int SAtaca(Tiempo tiempo1)
        {

            tiempo2 = tiempo1.PerderTiempo();
            return tiempo2;
        }
    }
}