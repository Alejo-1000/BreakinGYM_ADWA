using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingGym.EntidadesNegocioEN
{
    public class ClienteEN
    {
        public int Id { get; set; }
        public int IdRol { get; set; }       // Clave foránea hacia Rol
        public int IdTipoDocumento { get; set; } // Clave foránea hacia TipoDocumento
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Celular { get; set; }

    }
}
