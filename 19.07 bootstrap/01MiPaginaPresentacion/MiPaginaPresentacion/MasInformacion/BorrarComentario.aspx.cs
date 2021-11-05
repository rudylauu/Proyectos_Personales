using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiPaginaPresentacion.MasInformacion
{
    public partial class BorrarComentario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["Id"]; //Request es para pedir los datos 
            if (string.IsNullOrWhiteSpace(id))
            {
                pnlError.Visible = true;
            }
            else
            {
                //borrar
            }
        }
    }
}