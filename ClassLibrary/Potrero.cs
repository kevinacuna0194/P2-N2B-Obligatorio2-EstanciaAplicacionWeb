using ClassLibrary.Interface;

namespace ClassLibrary
{
    public class Potrero : IValidar
    {
        private static int idContador = 1;
        private int _id;
        private string _descripcion;
        private double _hectareas;
        private int _capacidadMaxima;
        private List<Animal> _animales = new List<Animal>();

        public Potrero(string descripcion, double hectareas, int capacidadMaxima)
        {
            _id = idContador++;
            _descripcion = descripcion;
            _hectareas = hectareas;
            _capacidadMaxima = capacidadMaxima;
        }

        #region Get; Set;
        /** Get; Set; **/
        public List<Animal> Animales
        {
            get { return _animales; }
        }

        public int Id
        {
            get { return _id; }
        }

        public double Hectareas
        {
            get { return _hectareas; }
        }

        public int CapacidadMaxima
        {
            get { return _capacidadMaxima; }
        }
        #endregion Get; Set;

        #region Métodos que Agregan o Modifican Información
        /** Métodos que Agregan o Modifican Información **/
        public void AsignarPotrero(Animal animal, Potrero potrero)
        {
            try
            {
                // Verificar si el potrero tiene capacidad para más animales
                if (potrero._animales.Count >= potrero._capacidadMaxima) throw new InvalidOperationException("El Potrero Está Lleno.");

                // Agregar el animal al potrero y asignarle el potrero
                potrero._animales.Add(animal);
                animal.PotreroAsignado = potrero;
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Sistema.Error($"{ex.Message} \n");
            }
        }
        #endregion Métodos que Agregan o Modifican Información

        #region Métodos Globales
        /** Métodos Globales **/
        public bool Validar()
        {
            if (!String.IsNullOrEmpty(_descripcion) && _hectareas > 0 && _capacidadMaxima > 0 && _animales.Count > 0) return true;
            return false;
        }

        public override string ToString()
        {
            string mensaje;
            mensaje = $"ID Potrero: {_id} ➟ ";
            mensaje += $"Descripción: {_descripcion} ➟ ";
            mensaje += $"Hectareas: {_hectareas} ➟ ";
            mensaje += $"Capacidad Máxima: {_capacidadMaxima} ➟ ";

            mensaje += $"\n \n Animales en Potrero: \n";

            if (_animales.Count > 0)
            {
                foreach (Animal animal in _animales)
                {
                    mensaje += $"\n ➜ {animal} \n";
                }
            }
            else
            {
                mensaje += $"\n ➜ No hay registros de Animales en el Potrero \n";
            }

            return mensaje;
        }
        #endregion Métodos Globales
    }
}
