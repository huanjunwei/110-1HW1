using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1HW1
{
    public partial class Trons : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double c, d_Value;
            d_Value = 3.982;
            c = d_Value * d_Value;
            Response.Write("d_Value =" + d_Value + "*" + d_Value + "=" +c);
        }
    }
}