﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWebSite
{
    public partial class Frame4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["LastPage"] = "Frame4";
            Session["UtcNow"] = DateTime.UtcNow;
				var bigObj = Session["BigObject"];
				Session["BigObject"] = null;

				var newBigObj = Session["BigObject"];
				if (newBigObj != null) {
					throw new Exception("Null value saved to session but not retrievable");
				}
        }
    }
}