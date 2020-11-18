using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace وظيفة_التقانات3
{
    public partial class application : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("The num of users online=" + Application["user"].ToString());
        }
    }
}