using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TwilioModule
/// </summary>
public class TwilioModule : IHttpModule
{
	public TwilioModule()
	{
	}

    public String ModuleName
    {
        get { return "Twilio Module"; }
    }

    public void Init(HttpApplication application)
    {
        application.BeginRequest += (new EventHandler(this.Application_BeginRequest));
    }

    private void Application_BeginRequest(Object source, EventArgs e)
    {
        HttpApplication application = (HttpApplication)source;
        HttpContext context = application.Context;
        string filePath = context.Request.FilePath;
        string fileExtension = VirtualPathUtility.GetExtension(filePath);
        if (fileExtension.Equals(".aspx"))
        {
            context.Response.Write("<h1><font color=red>" + "Twilio Module Test" + "</font></h1><hr>");
        }
    }

    public void Dispose() {}
}