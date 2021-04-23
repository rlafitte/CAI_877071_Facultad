using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facultad.Libreria;


namespace Facultad.Libreria
{
    public class Controlador
    {
        public List<Empleado> _empleados;
        public List<Alumno> _alumnos;
        
        public string AgregarAlumno(Alumno A)
        {
            try
            {

                 _alumnos.Add(A);
                 return $"Registro {A.Codigo} agregado correctamente.";
            }
            catch (ValorNoNumerico ex)
            {
                //Console.WriteLine(ex.Message);
            }
            catch (AlumnoExistente ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch
            {

            }
            return "";
        }
        public int ValidaNumerico(string s)
        {
            int i;
            if (int.TryParse(s, out i))
            {
                return i;
            }
            else
            {
                throw new ValorNoNumerico();
                i = -1;
                return i;
            }
        }
        public void ValidaExistencia(int i)
        {
            Alumno aux;
            if (_alumnos != null)
            {

            try
            {
                aux = _alumnos.FirstOrDefault(o => o.Codigo == i);
                if (aux.Codigo != null)
                {
                    throw new AlumnoExistente();

                }
            }
            catch (NullReferenceException)
            {

            }
            }
        }
    }
}
