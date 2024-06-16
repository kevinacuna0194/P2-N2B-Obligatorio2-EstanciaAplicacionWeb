namespace ClassLibrary
{
    // Clase para el Peon, derivada de Animal
    public class Peon : Empleado
    {
        private static int idContador = 1;
        private int _id;
        private bool _residenteEstancia;
        private List<Tarea> _tareasAsignadas = new List<Tarea>();

        // Constructor
        public Peon(string email, string password, string nombre, DateTime fechaIngreso, bool residenteEstancia) : base(email, password, nombre, fechaIngreso)
        {
            _id = idContador++;
            _residenteEstancia = residenteEstancia;
        }

        /** Get; Set; **/
        public List<Tarea> TareasAsignadas
        {
            get { return _tareasAsignadas; }
            set { _tareasAsignadas = value; }
        }

        public int Id
        {
            get { return _id; }
        }

        /** Métodos Que Agregan o Modifican Información **/
        // Método para asignar tarea al peón
        public void AsignarTarea(Tarea tarea)
        {
            try
            {
                if (tarea is null) throw new ArgumentException("Object Null. Peon.cs\\AsignarTarea(Tarea tarea)");
                tarea.Validar();
                _tareasAsignadas.Add(tarea);
            }
            catch (Exception ex)
            {
                Sistema.Error(ex.Message);
            }
        }

        public override string TipoEmpleado()
        {
            return "Peon";
        }

        /** Métodos Globales **/
        public override bool Validar()
        {
            return base.Validar();
        }

        public override string ToString()
        {
            string mensaje = base.ToString();
            mensaje += $"¿Es Residente de la Estancia?: {_residenteEstancia} ➟ ";

            mensaje += $"\n \n Tareas Asignadas: \n";

            if (_tareasAsignadas.Count > 0)
            {
                foreach (Tarea tarea in _tareasAsignadas)
                {
                    mensaje += $"\n ➜ {tarea} \n";
                }
            }
            else
            {
                mensaje += $"\n ➜ No Hay Tareas Asignadas ";
            }

            return mensaje;
        }
    }
}
