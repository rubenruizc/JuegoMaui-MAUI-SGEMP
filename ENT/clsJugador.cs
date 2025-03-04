namespace ENT
{
    public class clsJugador
    {

        #region Atributos

        private int id;

        private string nombre;

        private string contrasena;

        private int puntacion;
        #endregion

        #region Propiedades

        public int Id { 
            get 
            { 
                return id; 
            } 
            set 
            { 
                if(value > 0)
                {
                    id = value;
                }
            } 
        }

        public string Nombre { 
            get 
            { 
                return nombre; 
            } 
            set 
            {
                if (!String.IsNullOrEmpty(value))
                {
                    nombre = value;
                }
            } 
        }

        public string Contrasena { 
            get 
            { 
                return contrasena; 
            } 
            set 
            { 
                if (!String.IsNullOrEmpty(value))
                {
                    contrasena = value;
                }
            } 
        }

        public int Puntacion { 
            get 
            { 
                return puntacion; 
            } 
            set 
            {
                if(value > -1)
                {
                    puntacion = value;
                }
            } 
        }


        #endregion

        #region Constructores

        public clsJugador() { }

        public clsJugador(int id, string nombre, string contrasena,int puntuacion)
        {
            this.id = id;
            this.nombre = nombre;
            this.contrasena = contrasena;
            this.puntacion = puntuacion;
        }
        #endregion

    }
}
