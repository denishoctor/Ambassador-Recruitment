using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;
using System.Web.Hosting;

public partial class jobseekers_jobdetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*
        Page.Title = Request.QueryString["Title"] + " - Ambassador Recruitment";
        JobTile.Text = Request.QueryString["Title"];
        string VacancyID = Request.QueryString["ID"];
        SubmitHyperLink.NavigateUrl = "submitcv.aspx?ID=" + Request.QueryString["ID"];
        string xml = "<?xml version='1.0' encoding='UTF-8'?>" +
                    "<request>" +
                        "<header>" +
                            "<userId>*GUEST</userId>" +
                            "<password>guest</password>" +
                        "</header>" +
                        "<body>" +
                            "<command>getVacancyDescriptions</command>" +
                            "<parms>" +
                                "<parm>" + VacancyID + "</parm>" +
                            "</parms>" +
                        "</body>" +
                    "</request>";
        string url = "http://ww1.caliber.ie/cram/api";
        try
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            byte[] requestBytes = System.Text.Encoding.ASCII.GetBytes(xml);
            req.Method = "POST";
            req.ContentType = "text/xml;charset=utf-8";
            req.ContentLength = requestBytes.Length;
            using (Stream requestStream = req.GetRequestStream())
            {
                requestStream.Write(requestBytes, 0, requestBytes.Length);
            }
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            XmlDocument doc = new XmlDocument();
            doc.Load(res.GetResponseStream());
            XmlNode node = doc.SelectSingleNode("response/body/record/externalDesc/text()");
            string externalDesc = null;
            try
            {
                externalDesc = node.Value.Replace("&", "and");
            }
            catch
            {
                externalDesc = "No description found for Job ID " + VacancyID + ", please contact us for further details";
            }
            StringBuilder sb = new StringBuilder();

            sb.Append("<response>");
            sb.Append("<record " + "externalDesc='" + externalDesc + "'/>");
            sb.Append("</response>");

            string xmlstr = sb.ToString();
            XmlDataSourceJobDetail.Data = xmlstr;
            DetailsView1.DataSourceID = XmlDataSourceJobDetail.ID;
            try
            {
                DetailsView1.Rows[0].Visible = false;
            }
            catch
            {
                LabelDataError.Text = "Error occurred retrieving Job ID " + VacancyID + ". Please contact us for further details noting the ID of the joblisting.";
            }
        }
        catch
        { 

        }
         */
    }
}