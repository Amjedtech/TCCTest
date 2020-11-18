using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace وظيفة_التقانات3
{
    public partial class Display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Name = Request.QueryString.Get("name");
            string Age = Request.QueryString.Get("age");
            Label1.Text = "Your Name is : " + Name + "<br>Your Age is : " + Age;
        }
    }
}