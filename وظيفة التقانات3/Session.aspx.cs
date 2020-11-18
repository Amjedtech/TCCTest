using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace وظيفة_التقانات3
{
    public partial class Session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogIn_Click(object sender, EventArgs e)
        {
            Session["email"] = email.Text;
            Session["password"] = password.Text;
            if (Session["email"] != null)
            {
                // Displaying stored email  
                Show.Text += "This email is stored to the session.<br>This password is stored to the session.<br>" + Session["email"].ToString();
               
            }
        }
    }
}