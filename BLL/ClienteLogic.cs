using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class ClienteLogic
    {

        public bool AlteCliente(string nombre, string apellido)
        {
            try
            {
                Cliente cliente = new Cliente(nombre, apellido);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }

        public bool BajaCliente(int NumCliente)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

    }
}
