using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HabemusPapa
{
    public class Cardenal
    {
        private int _cantVotosRecibidos;
        private ENacionalidades _nacionalidad;
        private string _nombre;
        private string _nombrePapal;
    
        private Cardenal()
        {
            this._cantVotosRecibidos = 0;
        }

        public Cardenal(string nombre, string nombrePapal)
        {
            this._nombre = nombre;
            this._nombrePapal = nombrePapal;
        }

        public Cardenal(string nombre, string nombrePapal, ENacionalidades nacionalidad):this(nombre,nombrePapal)
        {
            this._nacionalidad = nacionalidad;
        }

        public int getCantidadVotosRecibidos()
        {
            return _cantVotosRecibidos;
        }

        private string Mostrar()
        {
            string nombre = ObtenerNombreYNombrePapal();

            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine(nombre);
            sb.AppendLine("Nacionalidad: " + this._nacionalidad);
            sb.AppendLine("Cantidad de votos: " + this._cantVotosRecibidos);

            return sb.ToString();
        }

        public string Mostrar(Cardenal c)
        {
            string cardenal;

            cardenal = c.Mostrar();

            return cardenal;
        }

        public string ObtenerNombreYNombrePapal()
        {
            string papa;

            papa=("El cardenal " + this._nombre + " se llamará " + this._nombrePapal + ".");

            return papa;
        }

        public static bool operator ==(Cardenal c1, Cardenal c2)
        {
            if (c1._nombre == c2._nombre && c1._nombrePapal == c2._nombrePapal && c1._nacionalidad == c2._nacionalidad)
                return true;
            return false;
        }

        public static bool operator !=(Cardenal c1, Cardenal c2)
        {
            return !(c1 == c2);
        }

        public static Cardenal operator ++(Cardenal c)
        {
            c._cantVotosRecibidos += 1;

            return c;
        }
    }
}
