using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria
{
    public class Excepciones : Exception
    {

    }
    public class OperacionInvalida : Exception
    {
        public OperacionInvalida() : base("La opción no es válida.") { }
    }
    public class ValorNoNumerico: Exception
    {
        public ValorNoNumerico() : base("El valor ingresado no es numérico") { }
    }
}
