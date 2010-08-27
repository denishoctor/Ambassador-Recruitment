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
        /*
        string category = null;
        string xml = null;
        if (Request.QueryString["Category"] != "")
        {
            category = Request.QueryString["Category"];
        }
        xml = "<?xml version='1.0' encoding='UTF-8'?><request><header><userId>*GUEST</userId><password>guest</password></header><body><command>searchJobs</command><parms><parm></parm><parm>Open</parm><parm></parm><parm></parm><parm></parm><parm></parm><parm></parm><parm></parm></parms></body></request>";
        string url = "http://ww1.caliber.ie/cram/api?output=json";
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

            //read stream
            using (StreamReader reader = new StreamReader(res.GetResponseStream())) {
                string json = reader.ReadToEnd();
            }

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
            string category2 = null;
            string categoryDesc = null;
            string locationDesc = null;
            foreach (XmlNode record in nodes)
            {
                if (record.SelectSingleNode("internal").InnerXml != "1")
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
                    category2 = record.SelectSingleNode("category2").InnerXml;
                    categoryDesc = record.SelectSingleNode("categoryDesc").InnerXml;
                    locationDesc = record.SelectSingleNode("locationDesc").InnerXml;
                    if (Request.QueryString["Category"] != "" && Request.QueryString["Category"] != null)
                    {
                        if (category.CompareTo(category2) == 0)
                        {
                            sb.Append("<record " + "vacancyId='" + vacancyId + "' description='" + description.Replace("&amp;", "and") + "' salary='" + salary + "' categoryDesc='" + categoryDesc + "' locationDesc='" + locationDesc + "'" + "/>");
                        }
                    }
                    else if (category2 != "" || category2 != null)
                    {
                        sb.Append("<record " + "vacancyId='" + vacancyId + "' description='" + description.Replace("&amp;", "and") + "' salary='" + salary + "' categoryDesc='" + categoryDesc + "' locationDesc='" + locationDesc + "'" + "/>");
                    }
                }
            }
            sb.Append("</response>");
            string xmlstr = sb.ToString();

            if (xmlstr != "<response></response>")
            {
                XmlDataSourceJoblist.Data = xmlstr;
                GridView1.DataSourceID = XmlDataSourceJoblist.ID;
            }
            else
            {
                LabelNoListings.Text = "No jobs listings were found for your specified search. Please send us your CV and we'll contact you if anything arises.";
            }
        }
        catch
        { 

        }
         */
    }
    
    /*
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect("jobdetails.aspx?ID=" + GridView1.SelectedRow.Cells[0].Text + "&Title=" + GridView1.SelectedRow.Cells[1].Text);
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
