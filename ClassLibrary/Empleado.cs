﻿using ClassLibrary.Enum;
using ClassLibrary.Interface;

namespace ClassLibrary
{
    // Clase base para todos los empleados
    public abstract class Empleado : IValidar
    {
        protected string _email;
        protected string _password;
        protected string _nombre;
        protected DateTime _fechaIngreso;

        // Constructor
        protected Empleado(string email, string password, string nombre, DateTime fechaIngreso)
        {
            _email = email;
            _password = password;
            _nombre = nombre;
            _fechaIngreso = fechaIngreso;
        }

        protected Empleado() { }

        /** Propiedades **/
        public string Email { get { return _email; } set { value = _email; } }

        public string Password { get { return _password; } set { value = _password; } }

        public string Nombre { get { return _nombre; } set { value = _nombre; } }

        public DateTime FechaIngreso { get {  return _fechaIngreso; } set { value = _fechaIngreso; } }

        // Métodos
        public abstract string TipoEmpleado();

        public virtual bool Validar()
        {
            if (!string.IsNullOrEmpty(_email) && !string.IsNullOrEmpty(_password) && _password.Length >= 8 && !string.IsNullOrEmpty(_nombre) && _fechaIngreso > DateTime.Today) return true;
            return false;
        }

        public override string ToString()
        {
            string mensaje;
            mensaje = $"Email: {_email} ➟ ";
            mensaje += $"Password: {_password} ➟ ";
            mensaje += $"Nombre: {_nombre} ➟ ";
            mensaje += $"Fecha de Ingreso: {_fechaIngreso} ➟ ";

            return mensaje;
        }

        public override bool Equals(object? obj)
        {
            Empleado empleado = obj as Empleado;
            return empleado is not null && _nombre.Equals(empleado._nombre) && _email.Equals(empleado._email);
        }
    }
}
