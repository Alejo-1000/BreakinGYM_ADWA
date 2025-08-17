using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingGym.EntidadesNegocioEN
{
    public class ClienteEN : PersonaEN
    {
     public ClienteEN(int Id, int IdRol, int IdTipoDocumento, string Documento, string Nombre, string Apellido, string Celular)
            : base(Id, IdRol, IdTipoDocumento, Documento, Nombre, Apellido, Celular)
        {
        }

    }
}
