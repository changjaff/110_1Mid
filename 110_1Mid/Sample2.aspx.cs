﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Mid {
    public partial class Sample2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        // To generate a 4 digital number
        public string mt_GenVeriStr() {
            string s_Res = "";
            Random o_Ran = new Random();
            for (int i_Ct = 0; i_Ct < 4; i_Ct++) {
                int i_Tmp = o_Ran.Next(0, 10);
                s_Res = s_Res + i_Tmp.ToString();
            }
            return s_Res;
        }

        protected void ddl_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddl_Type_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void ddl_ZoneCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void rb_Des_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}