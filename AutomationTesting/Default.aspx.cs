using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace AutomationTesting
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void runTest_Click(object sender, EventArgs e)
        {
            Test t = new Test();
            t.Initialize(this.webSiteUrl.Text, this.fulfillmentTesting.SelectedValue, this.paymentTesting.SelectedValue, this.creditCardTesting.Text);
            var resultList = System.Web.HttpContext.Current.Session["ResultList"];
            this.resultGrid.DataSource = resultList;
            this.resultGrid.DataBind();
        }
    }
}