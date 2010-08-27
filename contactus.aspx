<%@ Page Language="C#" MasterPageFile="~/Right.master" Title="Ambassador Recruitment - Contact Us" %>

<script runat="server">

</script>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_Text" Runat="Server">

	<h1>Contact Details</h1>
	<p>Please feel free to contact us with any queries regarding our services</p>
    <div id="contact">	
        <div class="f-right" style="width:320px;top: -20px;">
	        <p>
		        <strong>Dolores O'Connor </strong><br />
		        <strong>Mob:</strong> +353 (0)87 258 2374<br />
		        <strong>Email:</strong> <a href="mailto:dolores@ambassador-recruit.com">dolores@ambassador-recruit.com</a>
	        </p>
	        <p>
		        <strong>Elaine Blood</strong><br />
		        <strong>Mob:</strong> +353 (0)86 770 2000<br />
		        <strong>Email:</strong> <a href="mailto:elaine@ambassador-recruit.com">elaine@ambassador-recruit.com</a>
	        </p>
	        <p>
		        <strong>Fiona Keane</strong><br />
		        <strong>Mob:</strong> +353 (0)86 770 2020<br />
		        <strong>Email:</strong> <a href="mailto:fiona@ambassador-recruit.com">fiona@ambassador-recruit.com</a>
	        </p>
        </div>
        <div style="width:320px; height: 20px;">    
            <p>
		        Ambassador Recruitment<br />
		        3 Abbeydale Gardens<br />
		        Lucan<br />
		        Co. Dublin<br />
	        </p>
	        <p>
		        <strong>Tel:</strong> +353 (0)1 610 0201<br />
		        <strong>Fax:</strong> +353 (0)1 610 0204<br />
		        <strong>Email:</strong> <a href="mailto:info@ambassador-recruit.com">info@ambassador-recruit.com</a>
	        </p>
        </div>
	    <div id="map_canvas" style="width:680px;height:400px;margin-bottom:12px;"></div>
	</div>
<script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false"></script> 
<script type="text/javascript"> 
  function initializeMap() {
    var myLatlng = new google.maps.LatLng(53.3445693, -6.4225602);
    var myOptions = {
      zoom: 12,
      center: myLatlng,
      mapTypeId: google.maps.MapTypeId.ROADMAP
    }
    var map = new google.maps.Map(document.getElementById("map_canvas"), myOptions);
    var marker = new google.maps.Marker({
        position: myLatlng, 
        map: map,
        title:"Ambassador Office"
    });
  }
  window.onload = initializeMap;
</script>
</asp:Content>