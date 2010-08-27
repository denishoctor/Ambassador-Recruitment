using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Right2 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int selectableNum = 16;
        int selectNum = 6;

        Random randomNumber = new Random();
        Dictionary<int, int> used = new Dictionary<int, int>();
        while (used.Count < selectNum)
        {
            int imageNumber = randomNumber.Next(0, selectableNum);
            if (!used.ContainsKey(imageNumber))
            {
                used.Add(imageNumber, imageNumber);
            }
        }
        int iNum = 1;
        foreach (int imagenumber in used.Keys)
        {
            Image img = (Image)FooterImages.FindControl("Image" + iNum);
            img.ImageUrl = "images/image" + imagenumber + ".jpg";
            iNum++;
        }
    }
}