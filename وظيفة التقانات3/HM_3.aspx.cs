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

        protected void queryBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Display.aspx?name=" + name.Text + "&age=" + age.Text);
        }

        protected void setView_Click(object sender, EventArgs e)
        {
            ViewState["Name"] = name.Text;
            ViewState["Age"] = age.Text;
            name.Text = age.Text = "";

        }

        protected void restBtn_Click(object sender, EventArgs e)
        {
            name.Text = ViewState["Name"].ToString();
            age.Text = ViewState["Age"].ToString();
        }

        protected void createBtn_Click(object sender, EventArgs e)
        {
            Response.Cookies["name"].Value = crtTxt.Text;
            Response.Cookies["name"].Expires = DateTime.Now.AddMinutes(1);
            Label5.Text = "Cookie Created";
            crtTxt.Text = "";
        }

        protected void retBtn_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["name"] == null)
            {
                retTxt.Text = "No cookie found";
            }
            else
            {
               
                retTxt.Text = Request.Cookies["name"].Value;
            }
            Label5.Text = "";

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