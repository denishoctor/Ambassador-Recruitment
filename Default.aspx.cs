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

public partial class joblistings : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int founded = 1986;
        int now = DateTime.Today.Year;
        Label1.Text = (now - founded).ToString();
        /*
        string xml = "<?xml version='1.0' encoding='UTF-8'?>" +
                    "<request>" +
                    "<header>" +
                        "<userId>*GUEST</userId>" +
                        "<password>guest</password>" +
                    "</header>" +
                    "<body>" +
                        "<command>searchJobs</command>" +
                        "<parms>" +
            // maxHits: for top five jobs put 5 here (integer)(optional)
                            "<parm>5</parm>" +
            // space delimited list of vacancy statuses (required)
                            "<parm>Open</parm>" +
            // space delimited list of vacancy categories (optional)
                            "<parm></parm>" +
            // space delimited list of vacancy categories 2 (optional)
                            "<parm></parm>" +
            // space delimited list of vacancy categories 3 (optional)
                            "<parm></parm>" +
            // preferred location (optional)
                            "<parm></parm>" +
            // preferred salary (integer)(optional)
                            "<parm></parm>" +
            // list of keywords and/or double-quoted phrases (optional)
                            "<parm></parm>" +
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
            XmlElement root = doc.DocumentElement;
            string xpath = "body/record";
            XmlNodeList nodes = root.SelectNodes(xpath);
            StringBuilder sb = new StringBuilder();
            sb.Append("<response>");
            string vacancyId = null;
            string description = null;
            string salary = null;
            string categoryDesc = null;
            string locationDesc = null;
            foreach (XmlNode record in nodes)
            {
                vacancyId = record.SelectSingleNode("vacancyId").InnerXml;
                description = record.SelectSingleNode("description").InnerXml;
                salary = record.SelectSingleNode("salary").InnerXml;
                if (String.IsNullOrEmpty(salary) == true)
                {
                    salary = "Negotiable";
                }
                else
                {
                    salary = "€" + salary.Replace(".00", "");
                }
                categoryDesc = record.SelectSingleNode("categoryDesc").InnerXml;
                locationDesc = record.SelectSingleNode("locationDesc").InnerXml;
                sb.Append("<record " + "vacancyId='" + vacancyId + "' description='" + description + "' salary='" + salary + "' categoryDesc='" + categoryDesc + "' locationDesc='" + locationDesc + "'" + "/>");
            }
            sb.Append("</response>");
            string xmlstr = sb.ToString();
            XmlDataSourceJoblist.Data = xmlstr;
            GridView1.DataSourceID = XmlDataSourceJoblist.ID;
        }
        catch
        { 

        }
        */
    }
    /*

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect("jobseekers/jobdetails.aspx?ID=" + GridView1.SelectedRow.Cells[0].Text + "&Title=" + GridView1.SelectedRow.Cells[1].Text);
    }

    protected void GridView_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes["onmouseover"] = "this.style.cursor='pointer';this.style.textDecoration='underline';";
            e.Row.Attributes["onmouseout"] = "this.style.textDecoration='none';";
            e.Row.Attributes["onclick"] = ClientScript.GetPostBackClientHyperlink(this.GridView1, "Select$" + e.Row.RowIndex);
        }
    }

    protected override void Render(HtmlTextWriter writer)
    {
        for (int i = 0; i < this.GridView1.Rows.Count; i++)
        {
            ClientScript.RegisterForEventValidation(this.GridView1.UniqueID, "Select$" + i);
        }
        base.Render(writer);
    }
     */
}
