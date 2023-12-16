using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rbmtflowchartocode
{
    public partial class FormDialogInput : Form
    {
        public FormDialogInput()
        {
            InitializeComponent();
        }

        public void Init(String title, String prompt)
        {
            this.Text = title;
            this.lblprompt.Text = prompt;

        }
        public void PrepareInput(String tipedata,String variable)
        {
            txt_tipedata.Visible = true;
            lbl_tipedata.Visible = true;
            lbl_variabel.Visible = true;
            if (!tipedata.Equals(""))
            {
                txt_tipedata.Text = tipedata;
            }

            if (!variable.Equals(""))
            {
                txtInput.Text = variable;

            }
        }

        public void PrepareProcessInput(string refvar,string value)
        {
            txtinput1.Visible = true;
            if (!refvar.Equals(""))
            {
                txtinput1.Text = refvar;
            }

            if (!value.Equals(""))
            {
                txtInput.Text = value;
            }
            lbl_set.Visible = true;
            lbl_to.Visible = true;
        }

        public String GetVarInput()
        {
            return txtinput1.Text;
        }

        public String GetInput()
        {
            return txtInput.Text;
        }


        public String getInput_tipeData()
        {
            return txt_tipedata.Text;
        }
        public String getinputtipe()
        {
            string tipe =  txt_tipedata.Text;
            return tipe;
        }
           


        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            this.Hide();

        }

         
    }
}
