﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiscussionForum.DataAccess;

namespace DiscussionForum
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        string uname;
        protected void Page_Load(object sender, EventArgs e)
        {
            uname = Session["username"].ToString();
            if (!IsPostBack)
            {
                showprofile.DataSource= DBHelper.getuserdata(uname);
                showprofile.DataBind();
                

            }
        }
    }
}