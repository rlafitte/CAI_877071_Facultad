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
        public List<Empleado> _empleados;
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
            Controlador C = new Controlador();
            switch (i)
            {
                case 1: //"1 - Agregar Alumno"
                    Alumno A = new Alumno();
                    try
                    {
                        Console.WriteLine("Ingrese el código de alumno");
                        A.Codigo = C.ValidaNumerico(Console.ReadLine());
                        C.ValidaExistencia(A.Codigo);
                        Console.WriteLine("Ingrese el nombre del alumno");
                        A.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido del alumno");
                        A.Apellido = Console.ReadLine();
                        C.AgregarAlumno(A);

                    }
                    catch
                    {

                    }
                    break; 
                case 2: // "2 - Agregar Empleado" 
                    AgregarEmpleado();
                    break; 
                case 3: break; // "3 - Eliminar Alumno" 
                case 4: break; // "4 - Eliminar Empleado" 
                case 5: break; // "5 - Modificar Empleado" 
                case 6: 
                    foreach (Alumno a in Alumnos)
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
        //public void AgregarAlumno()
        //{
        //    Alumno A = new Alumno();
        //    try
        //    {
        //        Console.WriteLine("Ingrese el código de alumno");
        //        A.Codigo=ValidaNumerico(Console.ReadLine());
        //        ValidaExistencia(A.Codigo);
        //        Console.WriteLine("Ingrese el nombre del alumno");
        //        A.Nombre = Console.ReadLine();
        //        Console.WriteLine("Ingrese el apellido del alumno");
        //        A.Apellido = Console.ReadLine();
        //        _alumnos.Add(A);
        //    }
        //    catch (ValorNoNumerico ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    catch (AlumnoExistente ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    catch
        //    {

        //    }
        //}
        public void AgregarEmpleado()
        {
            Empleado E;
            try
            {
                Console.WriteLine("Ingrese el tipo de empleado: "+Environment.NewLine +
                    "1 - Bedel" + Environment.NewLine + 
                    "2 - Docente" + Environment.NewLine + 
                    "3 - Directivo" + Environment.NewLine);
                int i = ValidaEmpleado(Console.ReadLine());
                switch (i)
                {
                    case 1: E = new Bedel();
                        ValidaExistenciaEmpleado(E.Legajo);
                        Console.WriteLine("Ingrese el nombre del empleado");
                        E.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido del empleado");
                        E.Apellido = Console.ReadLine();
                        _empleados.Add(E);
                        break;
                    case 2: E = new Docente();
                        ValidaExistenciaEmpleado(E.Legajo);
                        Console.WriteLine("Ingrese el nombre del empleado");
                        E.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido del empleado");
                        E.Apellido = Console.ReadLine();
                        _empleados.Add(E);
                        break;
                    case 3: E = new Directivo();
                        ValidaExistenciaEmpleado(E.Legajo);
                        Console.WriteLine("Ingrese el nombre del empleado");
                        E.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido del empleado");
                        E.Apellido = Console.ReadLine();
                        _empleados.Add(E);
                        break;
                
                }
            }
            catch (ValorNoNumerico ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CodigoEmpleado ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch
            {

            }
        }
        public void Salir()
        {
            this.Flag = false;
        }
        //public int ValidaNumerico(string s)
        //{
        //    int i;
        //    if (int.TryParse(s, out i))
        //    {
        //        return i;
        //    }
        //    else
        //    {
        //        throw new ValorNoNumerico();
        //        i = -1;
        //        return i;
        //    }
        //} 
        public int ValidaEmpleado(string s)
        {
            int i;
            if (int.TryParse(s, out i))
            {
                if (i == 1 || i == 2 || i == 3)
                {
                    
                }
                else
                {
                    throw new CodigoEmpleado();
                }
            }
            else
            {
                throw new ValorNoNumerico();
            }
            return i;
        }
        //public void ValidaExistencia (int i)
        //{
        //    Alumno aux;
        //    try
        //    {
        //        aux = _alumnos.FirstOrDefault(o => o.Codigo == i);
        //        if (aux.Codigo != null)
        //        {
        //            throw new AlumnoExistente();

        //        }
        //    }
        //    catch (NullReferenceException)
        //    {

        //    }
        //}
        public void ValidaExistenciaEmpleado(int i)
        {
            Empleado aux;
            try
            {
                aux = _empleados.FirstOrDefault(o => o.Legajo == i);
                if (aux.Legajo!= null)
                {

                }
            }
            catch (NullReferenceException)
            {

            }
        }
    }
}
