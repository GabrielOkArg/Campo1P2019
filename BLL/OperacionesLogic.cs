using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class OperacionesLogic
    {


        public bool Depositar(CajaAhorro cajaAhorro, int monto)
        {
            try
            {
                cajaAhorro.Saldo += monto;
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public bool Extraer(CajaAhorro cajaAhorro, int monto)
        {
            try
            {
                if (cajaAhorro.Saldo < monto)
                {
                    return false;
                    throw new Exception("El saldo es insuficiente para realizar la operacion");
                }
                else
                {
                    cajaAhorro.Saldo -= monto;
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Transferir(CajaAhorro cajaAhorro, CajaAhorro cajaAhorro1, int monto)
        {
            try
            {
                bool TraferenciaValida = this.Extraer(cajaAhorro, monto);
                if (TraferenciaValida)
                {
                    cajaAhorro1.Saldo += monto;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
