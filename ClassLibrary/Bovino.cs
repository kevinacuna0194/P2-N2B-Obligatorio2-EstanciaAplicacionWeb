using ClassLibrary.Enum;

namespace ClassLibrary
{
    // Clase para los bovinos, derivada de Animal
    public class Bovino : Animal
    {
        private static int idContador = 1;
        private int _id;
        private TipoAlimentacion _tipoAlimentacion;
        private decimal _precioPorKiloBovinoEnPie;

        // Constructor Clase Derivada
        public Bovino(string codigoCaravana, Sexo sexo, string raza, DateTime fechaNacimiento, decimal costoAdquisicion, decimal costoAlimentacion, double pesoActual, bool esHibrido, TipoAlimentacion tipoAlimentacion, decimal precioPorKiloBovinoEnPie) : base(codigoCaravana, sexo, raza, fechaNacimiento, costoAdquisicion, costoAlimentacion, pesoActual, esHibrido)
        {
            _id = idContador++;
            _tipoAlimentacion = tipoAlimentacion;
            _precioPorKiloBovinoEnPie = precioPorKiloBovinoEnPie;
        }

        /** Get; Set; **/
        public int Id
        {
            get { return _id; }
        }
        public decimal PrecioPorKiloBovinoEnPie
        {
            get { return _precioPorKiloBovinoEnPie; }
        }

        public TipoAlimentacion TipoAlimentacion
        {
            get { return _tipoAlimentacion; }
        }

        /** Métodos Globales **/
        public override string TipoAnimal()
        {
            return "Bovino";
        }

        public override bool Validar()
        {
            base.Validar();
            if (_precioPorKiloBovinoEnPie > 0) return true;

            return false;
        }

        public override string ToString()
        {
            string mensaje = base.ToString();
            mensaje += $"\n Tipo de Alimentación: {_tipoAlimentacion} ➟ ";
            mensaje += $"Precio por Kilo de Bovino en Pie: {_precioPorKiloBovinoEnPie}";

            return mensaje;
        }

        public override bool Equals(object? obj)
        {
            Bovino bovino = obj as Bovino;
            return bovino is not null && _codigoCaravana == bovino._codigoCaravana;
        }
    }
}
