using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria
{
    public sealed class Bedel : Empleado
    {
        private string _apodo;

        public string Apodo { get => _apodo; set => _apodo = value; }

        public override string GetNombreCompleto()
        {
            return $"Bedel {this.Apodo}";
        }
    }
}
