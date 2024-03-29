﻿using System;
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
        public List<Alumno> _alumnos = new List<Alumno>();
        private int _cantidadSedes;
        private string _Nombre;
        private bool flag=true;
        private string _opcion;
        private int _numericOpcion;
      
        public string Opcion { get => _opcion; set => _opcion = value; }
        public bool Flag { get => flag; set => flag = value; }
        public int CantidadSedes { get => _cantidadSedes; set => _cantidadSedes = value; }
        public int NumericOpcion { get => _numericOpcion; set => _numericOpcion = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }

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
                throw new AlumnoExistente();
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
                //i = -1;
                //return i;
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
        public string ListarAlumnos()
        {
            string msg = "";
            foreach (Alumno a in _alumnos)
            {
                msg += (a.ToString() + Environment.NewLine);
            }
            return msg;
        }
        public void ValidaExistenciaEmpleado(int i)
        {
            Empleado aux;
            try
            {
                aux = _empleados.FirstOrDefault(o => o.Legajo == i);
                if (aux.Legajo != null)
                {

                }
            }
            catch (NullReferenceException)
            {

            }
        }
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
        public int OpcionElegida(string s)
        {
            int i = -1; //para asegurar no arrastrar valores
            if (int.TryParse(s, out i))
            {
                return i;
            }
            else
            {
                throw new OperacionInvalida();

            }
            return i;

        }
    }
}
