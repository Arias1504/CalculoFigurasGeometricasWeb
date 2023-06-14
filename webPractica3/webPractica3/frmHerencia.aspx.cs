using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libFiguras3D;

namespace webPractica3
{
    public partial class frmHerencia : System.Web.UI.Page
    {
        #region "Variables globales"
        static int intFig;
        static string strDir = "~/Imagenes/";
        #endregion

        #region "Metodos propios"
        private void Mensaje(string texto)
        {
            this.lblMsj.Text = texto;
        }

        private void cargarImagen(string nombreFig)
        {
            string img = strDir + nombreFig;
            this.imgFigura.ImageUrl = @img;
        }

        private void limpiarRpta()
        {
            this.lblArea.Text = string.Empty;
            this.lblVolumen.Text = string.Empty;
        }

        private void LimpiarDatos()
        {
            this.txtRadioEsf.Text = string.Empty;
            this.txtRadioCil.Text = string.Empty;
            this.txtAltura.Text = string.Empty;
            this.txtLadoA.Text = string.Empty;
            this.txtLadoB.Text = string.Empty;
            this.txtLadoC.Text = string.Empty;
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //Por 1ra vez.
            {
                intFig = 1;
                cargarImagen("Esfera.jpg");
                this.txtRadioEsf.Focus();
            }
        }

        protected void rblFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarRpta();
            LimpiarDatos();

            Mensaje(string.Empty);
            intFig = this.rblFiguras.SelectedIndex + 1;
            this.pnlEsfera.Visible = false;
            this.pnlCilindro.Visible = false;
            this.pnlParalele.Visible = false;
            this.pnlRpta.Visible = false;

            switch (intFig)
            {
                case 1: //Esfera
                    cargarImagen("Esfera.jpg");
                    this.pnlEsfera.Visible = true;
                    this.txtRadioEsf.Focus();
                    break;
                case 2: //cilindro
                    cargarImagen("Cilindro.jpg");
                    this.pnlCilindro.Visible = true;
                    this.txtRadioCil.Focus();
                    break;
                default: //Paralelepipedo
                    cargarImagen("Paralelepipedo.jpg");
                    this.pnlParalele.Visible = true;
                    this.txtLadoA.Focus();
                    break;
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            rblFiguras_SelectedIndexChanged(null, null);
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            float fltvl1 = 0, fltvl2 = 0, fltvl3 = 0;
            try
            {
                switch (intFig)
                {
                    case 1: //Esfera
                        fltvl1 = Convert.ToSingle(this.txtRadioEsf.Text);
                        clsEsfera Esfera = new clsEsfera(fltvl1);
                        if (!Esfera.hallarArea() || !Esfera.hallarVolumen())
                        {
                            Mensaje("Error, " + Esfera.Error);
                            Esfera = null;
                            this.txtRadioEsf.Focus();
                            return;
                        }
                        this.lblArea.Text = Esfera.Area.ToString();
                        this.lblVolumen.Text = Esfera.Volumen.ToString();
                        this.pnlRpta.Visible = true;
                        break;
                    case 2: //Cilindro
                        fltvl1 = Convert.ToSingle(this.txtRadioCil.Text);
                        fltvl2 = Convert.ToSingle(this.txtAltura.Text);
                        clsCilindro Cl = new clsCilindro(fltvl1, fltvl2);
                        if (!Cl.hallarArea() || !Cl.hallarVolumen())
                        {
                            Mensaje("Error, " + Cl.Error);
                            Esfera = null;
                            this.txtRadioCil.Focus();
                            return;
                        }
                        this.lblArea.Text = Cl.Area.ToString();
                        this.lblVolumen.Text = Cl.Volumen.ToString();
                        this.pnlRpta.Visible = true;
                        break;
                    default:
                        fltvl1 = Convert.ToSingle(this.txtLadoA.Text);
                        fltvl2 = Convert.ToSingle(this.txtLadoB.Text);
                        fltvl3 = Convert.ToSingle(this.txtLadoC.Text);
                        clsParalelepipedo Pr = new clsParalelepipedo(fltvl1, fltvl2, fltvl3);
                        if (!Pr.hallarArea() || !Pr.hallarVolumen())
                        {
                            Mensaje("Error, " + Pr.Error);
                            Esfera = null;
                            this.txtLadoA.Focus();
                            return;
                        }
                        this.lblArea.Text = Pr.Area.ToString();
                        this.lblVolumen.Text = Pr.Volumen.ToString();
                        this.pnlRpta.Visible = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                Mensaje("Error en ejecución -> " + ex.Message);
            }
        }
    }
}