using BreakingGym.EntidadesNegocioEN;
using BreakingGym.LogicasAccesoDatosDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingGym.LogicasNegociosBL
{
    public class RolBL
    {
        public List<RolEN> MostrarRol()
        {
            return RolDAL.MostrarRol();
        }
        public int GuardarRol(RolEN prolEN)
        {
            return RolDAL.AgregarRol(prolEN);
        }
        public int EliminarRol(RolEN prolEN)
        {
            return RolDAL.EliminarRol(prolEN);
        }
        public int ModificarRol(RolEN prolEN)
        {
            return RolDAL.ModificarRol(prolEN);
        }

    }
}
