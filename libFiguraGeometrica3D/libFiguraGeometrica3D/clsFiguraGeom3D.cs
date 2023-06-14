using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libFiguraGeometrica3D
{
    public abstract class clsFiguraGeom3D
    {
        #region "Atributos protegidos"
        protected float fltArea;
        protected float fltVolumen;
        protected string strError;
        #endregion

        #region "Propiedades"
        public float Area
        {
            get { return fltArea; }
        }
        public float Volumen
        {
            get { return fltVolumen; }
        }
        public string Error
        {
            get { return strError; }
        }
        #endregion

        #region "Metodos publicos"
        public abstract bool hallarArea();
        public abstract bool hallarVolumen();
        #endregion
    }
}
