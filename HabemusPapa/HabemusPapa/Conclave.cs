using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HabemusPapa
{
    public class Conclave
    {
        private int _cantMaxCardenales;
        private List<Cardenal> _cardenales;
        private bool _habemusPapa;
        private string _lugarEleccion;
        private Cardenal _papa;
        static int cantidadVotaciones;
        static DateTime fechaVotacion;

        public Conclave()
        {
            this._cantMaxCardenales = 1;
            this._lugarEleccion = ("Capilla Sixtina");
        }

        static Conclave()
        {
            cantidadVotaciones = 0;
            fechaVotacion = DateTime.Now;
        }

        private Conclave(int cantidadCardenales):this()
        {
            this._cantMaxCardenales = cantidadCardenales;
        }

        public Conclave(int cantidadCardenales, string lugarEleccion):this(cantidadCardenales)
        {
            this._lugarEleccion = lugarEleccion;
        }

        private void ContarVotos(Conclave conclave)
        {
            throw new System.NotImplementedException();
        }

        private bool HayLugar()
        {
            if (this._cantMaxCardenales < this._cardenales.Count)
                return true;
            return false;
        }

        public string Mostrar()
        {
            throw new System.NotImplementedException();
        }

        private string MostrarCardenales()
        {
            string cardenal;

            foreach (Cardenal item in this._cardenales)
            {
                cardenal=item.Mostrar(item);
            }

            return cardenal;
        }

        public void VotarPapa(Conclave conclave)
        {
            throw new System.NotImplementedException();
        }

        public static bool operator ==(Conclave con, Cardenal c)
        {
            foreach (Cardenal item in con._cardenales)
            {
                if (item.Equals(c))
                    return true;
            }
            return false;
        }

        public static bool operator !=(Conclave con, Cardenal c)
        {
            return !(con == c);
        }

    }
}
