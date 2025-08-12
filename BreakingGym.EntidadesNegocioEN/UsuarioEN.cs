using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingGym.EntidadesNegocioEN
{
    public class UsuarioEN
    {
        public int Id { get; set; }
        public int IdRol { get; set; }       // Clave foránea hacia Rol
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Celular { get; set; }
        public string Cuenta { get; set; }
        public string Contrasenia { get; set; }
    }
}
