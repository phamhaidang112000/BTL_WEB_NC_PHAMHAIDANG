﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Auction_Web_PhamHaiDangBTL
{
    public partial class ViewAllUserPosts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataSourceUserPosts.SelectCommand = "SELECT * FROM [ITEM] WHERE OWNER ='" + Session["UserID"] + "'";
        }
    }
}