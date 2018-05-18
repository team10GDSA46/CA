using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace WebApplication1
{
    public partial class rohitTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Model1 ct = new Model1();
            ListBox1.DataSource = ct.YesNoes.ToList<YesNo>();
            ListBox1.DataTextField = "Description";
            ListBox1.DataValueField = "ID";
            ListBox1.DataBind();
        }

        protected void myFunc(object sender, EventArgs e)
        {
            Response.Write("<br /> Hello World");
        }
    }
}