using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using ClassLibrary1;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        public double num { get; set; }
        public Class1 cl1 { get; set; }
        public Class2 cl2 { get; set; }
        public void Page_Load(object sender, EventArgs e)
        {
            Random a = new Random();

            num = a.Next()+10;
            cl1 = new Class1("Instancia clase 1");
            cl2 = new Class2("Instancia clase 2");
            
            

        }
       

        

    }
}
