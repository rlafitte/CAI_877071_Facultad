using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria
{
    public class Persona
    {
        private string _apellido;
        private DateTime _fechaNac;
        private string _nombre;

        public string Apellido { get => _apellido; set => _apellido = value; }
        public DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        public virtual string GetCredencial()
        {
            return GetNombreCompleto();
        }
        private string GetNombreCompleto()
        {
            return $"{this._nombre} - {this._apellido}";
        }
    }
}
