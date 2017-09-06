using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Week_1___Robot
{
    public partial class Default : System.Web.UI.Page
    {

        private Robot myrobot;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["robot"] == null)
            {
                myrobot = new Robot(0, 0);
                Session["robot"] = myrobot;
            }
            else
            {
                myrobot = (Robot)Session["robot"];
            }
            
        }

        protected void btn_Links_Click(object sender, EventArgs e)
        {   
            myrobot.zetEenStapLinks();
            string positie = myrobot.HaalPlaatsOP().ToString();
            Session["robot"] = myrobot;
            lbl_positie.Text = positie;
        }

        protected void btn_Rust_Click(object sender, EventArgs e)
        {                      
            string positie = myrobot.HaalPlaatsOP().ToString();
            Session["robot"] = myrobot;
            lbl_positie.Text = positie;

        }

        protected void btn_Rechts_Click(object sender, EventArgs e)
        {            
            myrobot.zetEenStapRechts();
            string positie = myrobot.HaalPlaatsOP().ToString();
            Session["robot"] = myrobot;
            lbl_positie.Text = positie;

        }
    }
}