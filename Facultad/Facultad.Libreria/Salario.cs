using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria
{
    public class Salario
    {
        private double _bruto;
        private string _codigoTransferencia;
        private double _descuentos;
        private DateTime _fecha;

        public double Bruto { get => _bruto; set => _bruto = value; }
        public string CodigoTransferencia { get => _codigoTransferencia; set => _codigoTransferencia = value; }
        public double Descuentos { get => _descuentos; set => _descuentos = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }

        
        public double GetSalarioNeto()
        {
            return (this.Bruto * 0.83); //asumimos fuera de ganancias y convenio laboral básico
        }

        public Salario(double gross)
        {
            this.Bruto = gross;
        }

    }
}
