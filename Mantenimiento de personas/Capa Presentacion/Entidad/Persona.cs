using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Presentacion.Entidad
{
    public class Persona
    {
        /**Variable de la tabla dbo.Persona */
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Paterno { get; set; }
        public String Materno { get; set; }
        public String Dni { get; set; }
        public String EstadoCivil { get; set; }
        public String Direccion { get; set; }
        public String Nacimiento { get; set; }
        public int Edad { get; set; }
    }
}
