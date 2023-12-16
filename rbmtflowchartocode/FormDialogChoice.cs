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
    public partial class FormDialogChoice : Form
    {

        private int pil;
        public FormDialogChoice()
        {
            InitializeComponent();
        }

        public void init(String prompt, String strchoose1,String strchoose2)
        {
            lblprompt.Text = prompt;
            btnChoose1.Text = strchoose1;
            btnChoose2.Text = strchoose2;
        }
        
        public int getPilihan()
        {
            return pil;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pil = -1;
            this.Hide();
        }

        private void FormDialogChoice_Load(object sender, EventArgs e)
        {

        }

        private void btnChoose1_Click(object sender, EventArgs e)
        {
            pil = 1;
            this.Hide();

        }

        private void btnChoose2_Click(object sender, EventArgs e)
        {
            pil = 2;
            this.Hide();
        }
    }
}
