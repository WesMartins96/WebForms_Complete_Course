using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridView
{
    public partial class GridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetailsView1.PageIndex = (GridView1.PageIndex * GridView1.PageSize) + GridView1.SelectedIndex;
            DetailsView1.Visible = true;
        }
    }
}