using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Herencia.Entidades
{
    public partial class Auto
    {
        public int anios
        {
            get
            {
                return DateTime.Now.Year - 2;

            }
        }
        public void MiMetodoExtendido()
        {

        }

    }
}
