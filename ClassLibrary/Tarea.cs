using ClassLibrary.Interface;

namespace ClassLibrary
{
    public class Tarea : IValidar
    {
        private static int idContador = 1;
        private int _id;
        private string _descripcion;
        private DateTime _fechaPactada;
        private bool _completada;
        private DateTime _fechaCierre;
        private string _comentario;

        public Tarea(string descripcion, DateTime fechaPactada, bool completada, DateTime fechaCierre, string comentario)
        {
            _id = idContador++;
            _descripcion = descripcion;
            _fechaPactada = fechaPactada;
            _completada = completada;
            _fechaCierre = fechaCierre;
            _comentario = comentario;
        }

        /** Get; Set; **/
        public int Id
        {
            get { return _id; }
        }

        public bool Validar()
        {
            if (!String.IsNullOrEmpty(_descripcion) && _fechaPactada < DateTime.Today && _fechaCierre < DateTime.Today && !String.IsNullOrEmpty(_comentario)) return true;

            return false;
        }

        public override string ToString()
        {
            string mensaje = string.Empty;
            mensaje += $"ID Tarea: {_id} ➟ ";
            mensaje += $"Descripción: {_descripcion} ➟ ";
            mensaje += $"Fecha Pactada: {_fechaPactada} ➟ ";
            mensaje += $"¿Completada?: {_completada} ➟ ";
            mensaje += $"fecha de Cierre: {_fechaCierre} ➟ ";
            mensaje += $"Comentario: {_comentario}";

            return mensaje;
        }

        public override bool Equals(object? obj)
        {
            Tarea tarea = obj as Tarea;
            return (tarea is not null) && this._id == tarea._id;
        }
    }
}
