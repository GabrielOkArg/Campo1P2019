using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class ConexionBD
    {

        public static void ActualizarBD(DataTable DT, string seleccomand, SqlDataAdapter DaAux)
        {
            try
            {
                DT.PrimaryKey = new DataColumn[] { DT.Columns[0] };
                DaAux.SelectCommand.CommandText = seleccomand;
                SqlCommandBuilder CB = new SqlCommandBuilder(DaAux);
                DaAux.UpdateCommand = CB.GetUpdateCommand();
                DaAux.DeleteCommand = CB.GetDeleteCommand();
                DaAux.InsertCommand = CB.GetInsertCommand();
                DaAux.Update(DT);
            }
            catch (Exception)
            {

                throw;
            }

        }// fin actualizar

        public static DataTable ObtenerTodos(string seleccommand, SqlDataAdapter DaAux)
        {
            DataTable DT = new DataTable();
            try
            {
                DaAux.SelectCommand.CommandText = seleccommand;
                DaAux.Fill(DT);
                return DT;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }// fin obtener  todos.

        public static DataTable GetSchemma(string TableSchemma, SqlDataAdapter DaAux)
        {
            DataTable DT = new DataTable();
            DaAux.SelectCommand.CommandText = "select * from " + TableSchemma;
            DaAux.FillSchema(DT, SchemaType.Mapped);
            return DT;
        }




    }
}
