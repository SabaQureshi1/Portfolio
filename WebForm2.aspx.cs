﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PORTFOLIO_WEBSITE
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAboutUs_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }



    }
}