using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria
{
    public abstract class Empleado : Persona
    {
        private int _legajo;
        private DateTime _fechaIngreso;

        public int Legajo { get => _legajo; set => _legajo = value; }
        public DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }

        //private List<Salario> _salarios = new List<Salario>();
        public override string GetCredencial()
        {
            return $"{this.Legajo} - {this.GetNombreCompleto()} Salario $ ";
        }
        public string ToString()
        {
            return GetCredencial();
        }

        public override bool Equals(object obj)
        {
            Empleado E = (Empleado)obj;
            if (E.Legajo == this._legajo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public int Antiguedad()
        {
            int a = Convert.ToInt32(DateTime.Now - this.FechaIngreso);
            return a;
        }
        public DateTime FechaNacimiento()
        {
            return this.FechaNac;
        }
        //AgregarSalario(Salario) void
        //Salarios() List<Salario>
        //UltimoSalario() Salario
        }
}
