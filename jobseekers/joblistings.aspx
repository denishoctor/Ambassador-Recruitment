<%@ Page Title="Ambassador Recruitment - Jobseekers - Job Listings" Language="C#" MasterPageFile="~/Right.master" AutoEventWireup="true" CodeFile="joblistings.aspx.cs" Inherits="joblistings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder_Text" Runat="Server">
    <link href="/css/demo_page.css" rel="stylesheet" type="text/css" />
    <link href="/css/demo_table.css" rel="stylesheet" type="text/css" />
    <link href="/css/demo_table_jui.css" rel="stylesheet" type="text/css" />
    <link href="/css/jquery-ui-1.8.1.custom.css" rel="stylesheet" type="text/css" />
	<style type="text/css">
	    div#content-wrap{background:none;}
	    div#main{padding:20px 5px 20px 20px;}
	</style>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js" type="text/javascript"></script>
    <script src="/JavaScript/jquery-ui-1.8.1.custom.min.js" type="text/javascript"></script>
    <script src="/JavaScript/jquery.dataTables.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function() {
            $.ajax({
                url: "http://ww1.caliber.ie/cram/api?uid=*GUEST&pw=guest&cmd=searchJobs&p1=100&p2=Open&p3=&p4=&p5=&p6=&p7=&p8=",
                cache: false,
                dataType: "jsonp",
                jsonp: "jsonp",
                jsonpCallback: "listJobsCallback",
                success: function(data) {
                    var aData = [];
                    var records = data.records;
                    var x = 0;
                    var y = 0;
                    for (x in data.records) {
                        if (records[x].internet == 1) {
                            if (records[x].salary == "")
                                records[x].salary = "Negotiable";
                            else
                                records[x].salary = "&euro;" + records[x].salary.replace(".00", "");
                            aData[y] = [records[x].vacancyId, records[x].description, records[x].salary, records[x].categoryDesc, records[x].locationDesc, records[x].vacancyType];
                            y++;
                        }
                    }
                    $('#jobswrapper').html('<table cellpadding="0" cellspacing="0" border="0" class="display" id="jobs"></table>');
                    $('#jobs').dataTable({
                        "bJQueryUI": true,
                        "sPaginationType": "full_numbers",
                        "aaData": aData,
                        "aoColumns": [
                    { "sTitle": "ID" },
                    { "sTitle": "Description" },
                    { "sTitle": "Salary" },
                    { "sTitle": "Category" },
                    { "sTitle": "Location" },
                    { "sTitle": "Type" }
                    ]
                    });
                },
                error: function(e) { }
            });

            $("#jobs tr").live("click", function() {
                window.location = "/jobseekers/jobdetails.aspx?id=" + $(this).children("td:first").text();
            });
        });
    </script>
    <div id="jobswrapper" style="width:750px;"></div>
</asp:Content>