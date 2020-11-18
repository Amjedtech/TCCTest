using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace وظيفة_التقانات3
{
    public partial class QueryString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Display.aspx?name=" + name.Text + "&age=" + age.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ViewState["Name"] = name.Text;
            ViewState["Age"] = age.Text;
            name.Text = age.Text = "";

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            name.Text = ViewState["Name"].ToString();
            age.Text = ViewState["Age"].ToString();
        }
    }
}