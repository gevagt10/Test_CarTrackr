﻿using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace CarTrackr
{
    public partial class _Default : Page
    {	
		//test 123
        public void Page_Load(object sender, System.EventArgs e)
        {
            HttpContext.Current.RewritePath(Request.ApplicationPath);
            IHttpHandler httpHandler = new MvcHttpHandler();
            httpHandler.ProcessRequest(HttpContext.Current);
        }
    }
}
