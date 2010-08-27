<%@ Page Title="Ambassador Recruitment" Language="C#" MasterPageFile="~/Right.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="joblistings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder_Text" Runat="Server">
    <div class="f-left" style="width: 440px; padding-right: 8px;">
        <h1>Quality opportunities for quality people</h1>
        <p>Ambassador Recruitment, a leader in the Recruitment arena for over 
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label> years.</p>
        <p>We are the premier recruiters for Hospitality Management, recruiting for the leading Hotel and Event Companies in Ireland with strong links to Companies in the UK, USA and Australia.</p>
        <p>We are also the exclusive Irish Agent for Cunard, Seabourn and PO Cruise Lines.</p>
        <p class="bold">Our mission is to provide a 5<img alt="Five Star" height="12px" width="55px" src="images/fivestar.gif" /> service to Clients and Candidates achieving quality opportunities for quality people.</p>
		<%--
        <a href="http://www.dit.ie/news/archive2010/culinaryartsopenday/" rel="nofollow"><img class="dit" src="images/ditopenday2010.gif" alt="DIT Culinary Arts Open Day 2010" title="DIT Culinary Arts Open Day 2010" /></a>
		--%>
    </div>
    <div class="f-left" style="width: 300px;">
        <div style="width: 300px;">
            <h3 style="font-weight:bolder; color:White; background-color:#1f74b7; margin-bottom: -10px">&nbsp;Submit Your CV</h3>
            <p><a href="jobseekers/submitcv.aspx" style="color:Red;">Click here</a> to submit your CV now and get us on your side searching for your next position!</p>   
        </div>
        <div class="f-clear"></div>
        <h3 style="font-weight:bolder; color:White; background-color:#1f74b7;">&nbsp;Hot Jobs</h3>
        <script type="text/javascript">
            $(function() {
                $.ajax({
                    url: "http://ww1.caliber.ie/cram/api?uid=*GUEST&pw=guest&cmd=searchJobs&p1=5&p2=Open&p3=&p4=&p5=&p6=&p7=&p8=",
                    cache: false,
                    dataType: "jsonp",
                    jsonp: "jsonp",
                    jsonpCallback: "listJobsCallback",
                    success: function(data) {
                        var records = data.records;
                        var x = 0;
                        for (x in data.records) {
                            if (records[x].internet == 1) {
                                if (records[x].salary == "")
                                    records[x].salary = "Negotiable";
                                else
                                    records[x].salary = "&euro;" + records[x].salary.replace(".00", "");
                                $("#homepageJobs").html(
                                    $("#homepageJobs").html() +
                                    "<dt><a href=\"/jobseekers/jobdetails.aspx?id=" + records[x].vacancyId + "\">" + records[x].description + "</a></dt>" +
                                    "<dd>" + records[x].locationDesc + "</dd>"
                                );                                    
                            }
                        }
                    },
                    error: function(e) { }
                });

                $("#jobs tr").live("click", function() {
                    window.location = "/jobseekers/jobdetails.aspx?id=" + $(this).children("td:first").text();
                });
            });
        </script>
        <dl id="homepageJobs">
            
        </dl>
    </div>
<!--&#8230;&#8230; -->
    <div class="f-clear"></div>
</asp:Content>