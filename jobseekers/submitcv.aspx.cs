using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class jobseekers_submitcv : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string VacancyID = null;
        if (Request.QueryString["ID"] != "" && Request.QueryString["ID"] != null)
        {
            VacancyID = Request.QueryString["ID"];
        }
        else
        {
            VacancyID = "11337";
        }
        iFrameApplication.Attributes["src"] = "http://ww1.caliber.ie/cram/microJobs.html?job=" + VacancyID + "&nologo=1";
    }
}