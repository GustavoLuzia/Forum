using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Forum
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Verify Cookie
            HttpCookie cookie = Context.Request.Cookies["ForumXYHelper"];

            if(cookie != null)
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "Login", "changeMenusLogin('Welcome " + cookie.Values["NAME"] + "')", true);
            }
        }
    }
}