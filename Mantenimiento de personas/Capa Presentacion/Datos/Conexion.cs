using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Presentacion.Datos
{
    public class Conexion
    {
        /**Cadena de Conexión */
        private readonly String CadenaConexion = "SERVER=.;DATABASE=Maintenance;Integrated security=true";

        /**Método GetCadenaConexion()*/
        public String GetCadenaConexion()
        {
            return CadenaConexion;
        }

        /**Método GetConexion()*/
        public bool GetConexion()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(CadenaConexion);
                conexion.Open();
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
