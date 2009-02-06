using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Prototipo3C_Negocio.Controladores;
using Prototipo3C_Entidade.Entidade;


namespace Prototipo3C_Aplicacao.Paginas
{
    public partial class ObjetoCadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Trim().Equals("") || TextBox2.Text.Trim().Equals("") || TextBox3.Text.Trim().Equals(""))
            {
                Label1.Visible = true;
            }
            else {

                Objeto objeto = new Objeto(Convert.ToInt32(TextBox1.Text), TextBox2.Text, TextBox3.Text);
                ObjetoController controller = new ObjetoController();

                if (controller.CadastrarObjeto(objeto))
                {
                    Response.Redirect("ObjetoListagem.aspx");
                    //GridView1.Visible = true;
                    //GridView1.DataBind();

                }
                else {
                    Label1.Visible = false;
                    Label2.Visible = true;
                    GridView1.Visible = false;
                    
                }
            
            }
        }
    }
}
