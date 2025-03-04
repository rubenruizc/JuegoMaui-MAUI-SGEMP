using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class clsPartida
    {

        #region Atributos

        private int id;

        private List<clsJugador> jugadores = new List<clsJugador>();

        private bool enJuego;

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


        public List<clsJugador> Jugadores
        {
            get { return jugadores; }
            set
            {
                if (value != null && value.Count > 0)
                {
                    jugadores = value;
                }
            }
        }

        public bool EnJuego
        {
            get { return enJuego; }
            set
            {
                // Solo permitimos valores true o false explícitamente
                if (value == true || value == false)
                {
                    enJuego = value;
                }
            }
        }


        #endregion

        #region Constructores
        #endregion
    }
}
