﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace telephone
{
    public partial class page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b9_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_data.aspx");

        }

        protected void b11_Click(object sender, EventArgs e)
        {
            Response.Redirect("page3.aspx");
        }

        protected void b12_Click(object sender, EventArgs e)
        {
            Response.Redirect("ent1.aspx");
        }
    }
}