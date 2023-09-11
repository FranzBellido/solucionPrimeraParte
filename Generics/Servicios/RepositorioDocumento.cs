using Generics.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Servicios
{
   public  class RepositorioDocumento
    {

        public void GuardarPersona(Documento doc)
        {
            Console.WriteLine($"Guardando persona {doc.Numero} a la Base");
        }


    }
}
