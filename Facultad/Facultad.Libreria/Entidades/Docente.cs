using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria
{
    public sealed class Docente : Empleado
    {
        public override string GetNombreCompleto()
        {
            return $"Docente {this.Nombre}";
        }
    }
}
