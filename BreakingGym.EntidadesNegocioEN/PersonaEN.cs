using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingGym.EntidadesNegocioEN
{
    public abstract class PersonaEN
    {
        protected int id {get; set; } // Identificador único de la persona
        protected string nombre { get; set; } // Nombre de la persona
        protected string apellido { get; set; } // Apellido de la persona
        protected string celular { get; set; } // Número de celular de la persona
        protected int idRol { get; set; } // Clave foránea hacia Rol
        protected int idTipoDocumento { get; set; } // Clave foránea hacia TipoDocumento
        protected int documento { get; set; } // Documento de identidad de la persona

        protected PersonaEN(int id, string nombre, string apellido, string celular, int idRol, int idTipoDocumento, int documento)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.celular = celular;
            this.idRol = idRol;
            this.idTipoDocumento = idTipoDocumento;
            this.documento = documento;
        }
        public abstract void Registrar();
        public abstract void Eliminar();
        public abstract void Modificar();
        public abstract void Mostrar();
    }
    
}
