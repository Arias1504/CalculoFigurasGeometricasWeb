using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Referenciar y usar
using libFiguraGeometrica3D;

namespace libFiguras3D
{
    public class clsEsfera : clsFiguraGeom3D
    {
        #region "Atributos"
        private float fltRadio;
        #endregion

        #region "Constructor"
        /// <summary>
        /// Clase esfera - hallar área y volumen
        /// </summary>
        public clsEsfera()
        {
            fltRadio = 0;
            fltArea = 0;
            fltVolumen = 0;
            strError = string.Empty;
        }
        /// <summary>
        /// Clase esfera - hallar área y volumen con el radio de argumento
        /// </summary>
        /// <param name="Radio">Vr. Radio de la esfera</param>
        public clsEsfera(float Radio)
        {
            fltRadio = Radio;
            fltArea = 0;
            fltVolumen = 0;
            strError = string.Empty;
        }
        #endregion

        #region "Propiedades"
        public float Radio
        {
            set { fltRadio = value; }
        }
        #endregion

        #region "Metodos privados"
        private bool validar()
        {
            if(fltRadio <= 0)
            {
                strError = "Error, valor del radio no válido";
                return false;
            }
            return true;
        }
        #endregion

        #region "Metodos publicos"
        public override bool hallarArea() //Polimorfismo A = 4πr2
        {
            try
            {
                if (!validar())
                    return false;

                fltArea = 4f * (float)(Math.PI * Math.Pow(fltRadio, 2));
                return true;
            }
            catch (Exception ex)
            {
                strError = "Error, reintente por favor" + ex.Message;
                return false;
            }
        }

        public override bool hallarVolumen()
        {
            try
            {
                if (!validar())
                    return false;

                fltVolumen = 4/3f * (float)(Math.PI * Math.Pow(fltRadio, 3));
                return true;
            }
            catch (Exception ex)
            {
                strError = "Error, reintente por favor" + ex.Message;
                return false;
            }
        }
        #endregion
    }

    /// <summary>
    /// Provee el hallar área y volumen del cilindro 
    /// </summary>
    public class clsCilindro : clsFiguraGeom3D
    {
        #region "Atributos"
        private float fltRadio;
        private float fltaltura;
        #endregion

        #region "Constructor"
        /// <summary>
        /// Clase cilindro - Hallar área y volumen
        /// </summary>
        public clsCilindro()
        {
            fltRadio = 0;
            fltaltura = 0;
            fltArea = 0;
            fltVolumen = 0;
            strError = string.Empty;
        }
        /// <summary>
        /// Clase cilindro - Hallar área y volumen
        /// </summary>
        /// <param name="vrRadio">Vr. del radio del cilindro</param>
        /// <param name="vrAltura">Vr. de la altura del cilindro</param>
        public clsCilindro(float vrRadio, float vrAltura)
        {
            fltRadio = vrRadio;
            fltaltura = vrAltura;
            fltArea = 0;
            fltVolumen = 0;
            strError = string.Empty;
        }

        #endregion

        #region "Propiedades"
        public float Radio
        {
            set { fltRadio = value; }
        }
        public float Altura
        {
            set { fltaltura = value; }
        }
        #endregion

        #region "Metodos privados"
        private bool validar()
        {
            if (fltRadio <= 0)
            {
                strError = "Error, valor del radio no válido";
                return false;
            }
            if (fltaltura <= 0)
            {
                strError = "Error, valor de la altura no válida";
                return false;
            }
            return true;
        }
        #endregion

        #region "Metodos publicos"
        /// <summary>
        /// Para hallar área del cilindro
        /// </summary>
        /// <returns>Vr. del área del cilindro</returns>
        public override bool hallarArea()
        {
            try
            {
                if (!validar())
                    return false;

                fltArea = Convert.ToSingle( (2f * Math.PI * fltRadio * fltaltura) + (2f * Math.PI * Math.Pow(fltRadio, 2)));
                return true;
            }
            catch (Exception ex)
            {
                strError = "Error, reintente por favor" + ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Para hallar el volumen del cilindro
        /// </summary>
        /// <returns>Vr. del volumen del cilindro</returns>
        public override bool hallarVolumen()
        {
            try
            {
                if (!validar())
                    return false;

                fltVolumen = Convert.ToSingle(Math.PI * Math.Pow(fltRadio, 2) * fltaltura);
                return true;
            }
            catch (Exception ex)
            {
                strError = "Error, reintente por favor" + ex.Message;
                return false;
            }
        }
        #endregion
    }

    /// <summary>
    /// Provee el hallar área y volumen del paralelepípedo
    /// </summary>
    public class clsParalelepipedo : clsFiguraGeom3D
    {
        #region "Atributos"
        private float fltLadoA;
        private float fltLadoB;
        private float fltLadoC;
        #endregion

        #region "Constructor"
        /// <summary>
        /// Clase paralelepípedo - Hallar área y volumen
        /// </summary>
        public clsParalelepipedo()
        {
            fltLadoA = 0;
            fltLadoB = 0;
            fltLadoC = 0;
            fltArea = 0;
            fltVolumen = 0;
            strError = string.Empty;
        }
        /// <summary>
        /// Clase paralelepípedo - Hallar área y volumen
        /// </summary>
        /// <param name="vrLadoA">Vr. del lado A</param>
        /// <param name="vrLadoB">Vr. del lado B</param>
        /// <param name="vrLadoC">Vr. del lado C</param>
        public clsParalelepipedo(float vrLadoA, float vrLadoB, float vrLadoC)
        {
            fltLadoA = vrLadoA;
            fltLadoB = vrLadoB;
            fltLadoC = vrLadoC;
            fltArea = 0;
            fltVolumen = 0;
            strError = string.Empty;
        }

        #endregion

        #region "Propiedades"
        public float LadoA
        {
            set { fltLadoA = value; }
        }
        public float LadoB
        {
            set { fltLadoB = value; }
        }
        public float LadoC
        {
            set { fltLadoC = value; }
        }
        #endregion

        #region "Metodos privados"
        private bool validar()
        {
            if (fltLadoA <= 0)
            {
                strError = "Valor del lado A, no es válido";
                return false;
            }
            if (fltLadoB <= 0)
            {
                strError = "Valor del lado B, no es válido";
                return false;
            }
            if (fltLadoC <= 0)
            {
                strError = "Valor del lado C, no es válido";
                return false;
            }
            return true;
        }
        #endregion

        #region "Metodos publicos"
        /// <summary>
        /// Para hallar área del paralelepípedo
        /// </summary>
        /// <returns>Vr. del área del paralelepípedo</returns>
        public override bool hallarArea()
        {
            try
            {
                if (!validar())
                    return false;

                fltArea = 2f * (fltLadoA * fltLadoB + fltLadoA * fltLadoC + fltLadoB * fltLadoC);
                return true;
            }
            catch (Exception ex)
            {
                strError = "Error, reintente por favor" + ex.Message;
                return false;
            }
        }
        /// <summary>
        /// Para hallar volumen del paralelepípedo
        /// </summary>
        /// <returns>Vr. del volumen del paralelepípedo</returns>
        public override bool hallarVolumen()
        {
            try
            {
                if (!validar())
                    return false;

                fltVolumen = Convert.ToSingle(fltLadoA * fltLadoB * fltLadoC);
                return true;
            }
            catch (Exception ex)
            {
                strError = "Error, reintente por favor" + ex.Message;
                return false;
            }
        }
        #endregion
    }
}
