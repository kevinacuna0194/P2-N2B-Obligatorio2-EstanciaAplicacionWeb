using ClassLibrary.Interface;

namespace ClassLibrary
{
    public class Capataz : Empleado
    {
        private static int idContador = 1;
        private int _id;
        private int _cantidadPersonasACargo;

        /** Constructor **/
        public Capataz(string email, string password, string nombre, DateTime fechaIngreso, int cantidadPersonasACargo) : base(email, password, nombre, fechaIngreso)
        {
            _id = idContador++;
            _cantidadPersonasACargo = cantidadPersonasACargo;
        }

        // Propiedades de lectura y escritura
        public int Id
        {
            get { return _id; }
        }

        // Métodos
        public override string TipoEmpleado()
        {
            return "Capataz";
        }

        public override bool Validar()
        {
            base.Validar();
            if (_cantidadPersonasACargo > 0) return true;

            return false;
        }

        public override string ToString()
        {
            string mensaje = base.ToString();
            mensaje += $"Cantidad de Personas a Cargo: ${_cantidadPersonasACargo}";

            return mensaje;
        }

        public override bool Equals(Object obj)
        {
            Capataz capataz = obj as Capataz;
            return capataz is not null && this._nombre.Equals(capataz._nombre) && this._email.Equals(capataz._email);
        }
    }
}
