using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente
    {
        public Cliente(string p0, string p1)
        {
            this.Nombre = p0;
            this.Apellido = p1;
        }
       public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NumCliente { get; set; }

    }
}
