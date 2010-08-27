<%@ Page Language="C#" MasterPageFile="~/Right.master" Title="Ambassador Recruitment - Employers" %>

<script type="text/C#" runat="server">
    void Page_Load(Object sender, EventArgs e)
    {
        int founded = 1988;
        int now = DateTime.Today.Year;
        Label1.Text = (now - founded).ToString();
    }
</script>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Text" Runat="Server">
	<h1>Employers</h1>
	<p>Ambassador Recruitment is in the business of providing and recruiting personnel for the Hotel and Catering Industry.  Our roles include job placement: the sourcing, screening and evaluation of candidates, the presenting of candidates for interview and acting as a mediator between employer and candidate.</p> 
    <p>With over <asp:Label ID="Label1" runat="server" Text=""></asp:Label> years in the Recruitment business we pride ourselves on our ability to offer a 5***** service to both employers and candidates to achieve quality placements for quality people in the following sectors:</p>
    <ul>
        <li>4*/5* Hotels in Ireland and Overseas</li>
        <li>Cruiselines</li>
        <li>Event and Industrial Catering</li>
        <li>US Graduate Programmes</li>
        <li>Australia</li>
    </ul>
    <p>We Place:</p>
    <ul>
        <li>Chief Executives</li>
        <li>Directors</li>
        <li>Regional/Area Managers</li>
        <li>General Managers</li>
        <li>Deputy/Operations Managers</li>
        <li>HR Managers</li>
        <li>Sales & Marketing Managers</li>
        <li>Executive/Head Chefs</li>
        <li>Sous Chefs</li>
        <li>ALL Heads of Departments</li>
    </ul>
</asp:Content>