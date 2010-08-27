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

public partial class findajob : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
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
                            "<parm>100</parm>" +
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
        string vacancyId = null;
        string description = null;
        foreach (XmlNode record in nodes)
        {
            if (record.SelectSingleNode("internal").InnerXml != "1")
            {
                vacancyId = record.SelectSingleNode("vacancyId").InnerXml;
                description = record.SelectSingleNode("description").InnerXml;
                Label1.Text += "<a href='jobseekers/jobdetails.aspx?ID=" + vacancyId + "&Title=" + description.Replace("&amp;", "and") + "' title='" + description.Replace("&amp;", "and") + "'>" + description.Replace("&amp;", "and") + "</a>&nbsp;";
            }
        }
    }
}
