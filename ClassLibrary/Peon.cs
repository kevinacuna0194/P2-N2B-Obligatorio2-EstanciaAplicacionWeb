namespace ClassLibrary
{
    // Clase para el Peon, derivada de Animal
    public class Peon : Empleado
    {
        private static int idContador = 1;
        private int _id;
        private bool _residenteEstancia;
        private List<Tarea> _tareas = new List<Tarea>();

        // Constructor
        public Peon(string email, string password, string nombre, DateTime fechaIngreso, bool residenteEstancia) : base(email, password, nombre, fechaIngreso)
        {
            _id = idContador++;
            _residenteEstancia = residenteEstancia;
        }

        /** Constructor Vacío **/
        public Peon() { }

        /** Get; Set; **/
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public bool EsResidente
        {
            get { return _residenteEstancia; }
            set { value = _residenteEstancia; }
        }

        public List<Tarea> Tareas
        {
            get { return _tareas; }
            set { _tareas = value; }
        }

        #region Métodos para Buscar Información
        /** Métodos para Buscar Información **/
        public List<Tarea> TareasNoCompletadas()
        {
            List<Tarea> tareas = new List<Tarea>();

            foreach (Tarea tarea in _tareas)
            {
                if (tarea.Completada == false)
                {
                    tareas.Add(tarea);
                }
            }

            /** ordenadas por fecha pactada ascendente **/
            tareas.Sort();

            return tareas;
        }

        public Tarea ObtenerTareaPorId(int id)
        {
            if (id <= 0) throw new ArgumentException("ID 0. ObtenerTareaPorId(int id)");

            Tarea tarea = null;

            int index = 0;
            while (index < _tareas.Count && tarea is null)
            {
                if (_tareas[index].Id == id) tarea = _tareas[index];

                index++;
            }

            return tarea;
        }
        #endregion Métodos para Buscar Información

        #region Métodos Que Agregan o Modifican Información
        // Método para asignar tarea al peón
        public void AsignarTarea(Tarea tarea)
        {
            try
            {
                if (tarea is null) throw new ArgumentException("Object Null. Peon.cs\\AsignarTarea(Tarea tarea)");
                tarea.Validar();
                _tareas.Add(tarea);
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
        # endregion Métodos Que Agregan o Modifican Información

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

            if (_tareas.Count > 0)
            {
                foreach (Tarea tarea in _tareas)
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
