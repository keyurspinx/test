using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.FriendlyUrls;

namespace SignalR
{
    public partial class product : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (var items in Request.GetFriendlyUrlSegments())
                {
                    Response.Write(items);
                    Response.Write("<br/>");
                }
   
            }

        }
        
    }
}