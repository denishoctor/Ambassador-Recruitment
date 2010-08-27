<%@ Page Title="" Language="C#" MasterPageFile="~/Right.master" AutoEventWireup="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder_Text" Runat="Server">
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js" type="text/javascript"></script>
    <script src="/JavaScript/jquery-ui-1.8.1.custom.min.js" type="text/javascript"></script>
    <script src="/JavaScript/jquery.dataTables.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function() {
            $.ajax({
                url: "http://ww1.caliber.ie/cram/api?uid=*GUEST&pw=guest&cmd=getVacancy&p1=" + getParameterByName('id'),
                cache: false,
                dataType: "jsonp",
                jsonp: "jsonp",
                jsonpCallback: "showJobCallback",
                success: function(data) {
                    var record = data.records[0];
                    $("#location").html(record.categoryDesc);
                    $("#category").html(record.location + "     " + record.locationDesc);                            
                    if (record.salary == "")
                        record.salary = "Negotiable";
                    else
                        record.salary = "&euro;" + record.salary.replace(".00", "");
                    $("#salary").html(record.salary);
                    $("#vacancyType").html(record.vacancyType);
                    //$("#jobListing").html(record.locationDesc);
                },
                error: function(e) { }
            });
            $.ajax({
                url: "http://ww1.caliber.ie/cram/api?uid=*GUEST&pw=guest&cmd=getVacancyDescriptions&p1=" + getParameterByName('id'),
                cache: false,
                dataType: "jsonp",
                jsonp: "jsonp",
                jsonpCallback: "showJobDescriptionCallback",
                success: function(data) {
                    var record = data.records[0];
                    $("#description").html(record.externalDesc);
                },
                error: function(e) { }
            });
            $("#sendCVLink").attr("href", "submitcv.aspx?ID=" + getParameterByName('id'));
        });

        function getParameterByName(name) {
            name = name.replace(/[\[]/, "\\\[").replace(/[\]]/, "\\\]");
            var regexS = "[\\?&]" + name + "=([^&#]*)";
            var regex = new RegExp(regexS);
            var results = regex.exec(window.location.href);
            if (results == null)
                return "";
            else
                return decodeURIComponent(results[1].replace(/\+/g, " "));
        }
    </script>
    <div id="jobListing" class="f-left" style="width: 540px; padding-right: 8px;">
        <dl>
            <dt>Location</dt><dd id="location"></dd>
            <dt>Category</dt><dd id="category"></dd>
            <dt>Salary</dt><dd id="salary"></dd>
            <dt>VacancyType</dt><dd id="vacancyType"></dd>
            <dt>Description</dt><dd id="description"></dd>
        </dl>
    </div>
    <div class="f-left" style="width: 200px; padding-top: 10px;">
        <h3 style="font-weight:bolder; color:White; background-color:#1f74b7; margin-bottom: -12px">Submit Your CV</h3>
        <p><a id="sendCVLink" href="#">Click here</a> to submit your CV now and get us on your side searching for your next position!</p>   
    </div>
</asp:Content>

