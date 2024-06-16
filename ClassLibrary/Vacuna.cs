using ClassLibrary.Interface;

namespace ClassLibrary
{
    public class Vacuna : IValidar
    {
        private static int idContador = 1;
        private int _id;
        private string _nombre;
        private string _descripcion;
        private string _patogeno;

        // Constructor
        public Vacuna(string nombre, string descripcion, string patogeno)
        {
            _id = idContador++;
            _nombre = nombre;
            _descripcion = descripcion;
            _patogeno = patogeno;
        }

        /** Get; Set; **/
        public int Id
        {
            get { return _id; }
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        /** Métodos **/
        public bool Validar()
        {
            if (!String.IsNullOrEmpty(_nombre) && !String.IsNullOrEmpty(_descripcion) && !String.IsNullOrEmpty(_patogeno)) return true;
            return false;
        }

        public override string ToString()
        {
            string mensaje;
            mensaje = $"Nombre: {_nombre} ➟ ";
            mensaje += $"Descripción: {_descripcion} ➟ ";
            mensaje += $"patógeno: {_patogeno}";

            return mensaje;
        }
    }
}
