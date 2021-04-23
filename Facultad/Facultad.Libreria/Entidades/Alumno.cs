using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria
{
    public class Alumno : Persona
    {
        private int _codigo;

        public int Codigo { get => _codigo; set => _codigo = value; }

        public override string GetCredencial()
        {
            return $"Código {this.Codigo}) {this.GetNombreCompleto()}";
        }
        public string ToString()
        {
            return GetCredencial();
        }
    }
}
