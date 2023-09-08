using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Contratos
{
public  interface IEntidad
	{

        public int Id { get; set; }

        public string UserCreador { get; set;}

    }
}
