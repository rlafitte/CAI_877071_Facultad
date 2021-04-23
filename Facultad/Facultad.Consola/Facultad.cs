using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facultad.Libreria;

namespace Facultad.Consola
{

    public class Facultad
    {

        private List<Alumno> _alumnos;
        private int _cantidadSedes;
        private List<Empleado> _empleados;
        private string _nombre;
        private bool flag;
        public Facultad()
        {
            flag = true;
            _alumnos = new List<Alumno>();
            _empleados = new List<Empleado>();
        }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int CantidadSedes { get => _cantidadSedes; set => _cantidadSedes = value; }
        public bool Flag { get => flag; set => flag = value; }

        static void Main(string[] args)
        {
            Facultad F = new Facultad();
            Console.WriteLine("Bienvenido al sistema de la facultad.");
            while (F.flag)
            {
            MostrarMenu();
                try
                {
                F.Ejecutar(F.OpcionElegida(Console.ReadLine()));
                }
                catch (OperacionInvalida o)
                {
                    Console.WriteLine(o.Message);
                }
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("1 - Agregar Alumno" + Environment.NewLine +
                "2 - Agregar Empleado" + Environment.NewLine +
                "3 - Eliminar Alumno" + Environment.NewLine +
                "4 - Eliminar Empleado" + Environment.NewLine +
                "5 - Modificar Empleado" + Environment.NewLine +
                "6 - Traer Alumnos" + Environment.NewLine +
                "7 - Traer Empleados por Legajo" + Environment.NewLine +
                "8 - Traer Empleados" + Environment.NewLine +
                "9 - Traer Empleados por Nombre" + Environment.NewLine + 
                "0 - Salir" + Environment.NewLine);
        }
        public int OpcionElegida(string s)
        {
            int i;
            if (int.TryParse(s, out i))
            {
                return i;
            }
            else
            {
                throw new OperacionInvalida();
                i = -1;
                return i;
            }
            return i;

        }
        public void Ejecutar(int i)
        {
            switch (i)
            {
                case 1: //"1 - Agregar Alumno"
                    Alumno A = new Alumno();
                    A.Codigo = 1;
                    A.Apellido = "Perez";
                    A.Nombre = "Juan";
                    _alumnos.Add(A);
                    break; 
                case 2: break; // "2 - Agregar Empleado" 
                case 3: break; // "3 - Eliminar Alumno" 
                case 4: break; // "4 - Eliminar Empleado" 
                case 5: break; // "5 - Modificar Empleado" 
                case 6: 
                    foreach (Alumno a in _alumnos)
                    {
                        Console.WriteLine(a.ToString());
                    }

                    break; // "6 - Traer Alumnos" 
                case 7: break; // "7 - Traer Empleados por Legajo" 
                case 8: break; // "8 - Traer Empleados" 
                case 9: break; // "9 - Traer Empleados por Nombre" 
                // "0 - Salir" + Environment.NewLine);
                case 0: //Salir
                    Console.WriteLine("Gracias por utilizar el sistema.");
                    Console.ReadLine();
                    this.Salir(); 
                    break;

            }

        }
        public void Salir()
        {
            this.Flag = false;
        }
    }
}
