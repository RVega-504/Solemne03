using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cliente
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcularModulo_Click(object sender, EventArgs e)
        {
            ServiceReference.ServiceClient sc = new ServiceReference.ServiceClient();
            ServiceReference.Factor factor = new ServiceReference.Factor();

            float a = 0.0f;
            float b = 0.0f;

            bool isA = float.TryParse(txtFactorA.Text, out a);
            bool isB = float.TryParse(txtFactorB.Text, out b);

            if (isA && isB)
            {
                factor.A = a;
                factor.B = b;
                lblResultado.Text = string.Format("El Resultado del Módulo es: {0}", sc.calcularModulo(factor));
            }
            else
            {
                lblResultado.Text = "ERROR: datos ingresados invalidos";
            }
        }
    }
}