namespace rbmtflowchartocode
{
    partial class FormDialogInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblprompt = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txt_tipedata = new System.Windows.Forms.ComboBox();
            this.lbl_tipedata = new System.Windows.Forms.Label();
            this.lbl_variabel = new System.Windows.Forms.Label();
            this.lbl_set = new System.Windows.Forms.Label();
            this.txtinput1 = new System.Windows.Forms.TextBox();
            this.lbl_to = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(403, 170);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(87, 41);
            this.btnBatal.TabIndex = 0;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(308, 170);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 41);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblprompt
            // 
            this.lblprompt.AutoSize = true;
            this.lblprompt.Location = new System.Drawing.Point(16, 42);
            this.lblprompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprompt.Name = "lblprompt";
            this.lblprompt.Size = new System.Drawing.Size(40, 17);
            this.lblprompt.TabIndex = 1;
            this.lblprompt.Text = "????";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(117, 118);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(371, 22);
            this.txtInput.TabIndex = 2;
       
            // 
            // txt_tipedata
            // 
            this.txt_tipedata.FormattingEnabled = true;
            this.txt_tipedata.Items.AddRange(new object[] {
            "char",
            "int",
            "float",
            "double"});
            this.txt_tipedata.Location = new System.Drawing.Point(117, 73);
            this.txt_tipedata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tipedata.Name = "txt_tipedata";
            this.txt_tipedata.Size = new System.Drawing.Size(168, 24);
            this.txt_tipedata.TabIndex = 3;
            this.txt_tipedata.Visible = false;
         
            // 
            // lbl_tipedata
            // 
            this.lbl_tipedata.AutoSize = true;
            this.lbl_tipedata.Location = new System.Drawing.Point(31, 76);
            this.lbl_tipedata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipedata.Name = "lbl_tipedata";
            this.lbl_tipedata.Size = new System.Drawing.Size(70, 17);
            this.lbl_tipedata.TabIndex = 4;
            this.lbl_tipedata.Text = "Tipe Data";
            this.lbl_tipedata.Visible = false;
            
            // 
            // lbl_variabel
            // 
            this.lbl_variabel.AutoSize = true;
            this.lbl_variabel.Location = new System.Drawing.Point(35, 122);
            this.lbl_variabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_variabel.Name = "lbl_variabel";
            this.lbl_variabel.Size = new System.Drawing.Size(60, 17);
            this.lbl_variabel.TabIndex = 5;
            this.lbl_variabel.Text = "Variabel";
            this.lbl_variabel.Visible = false;
           
            // 
            // lbl_set
            // 
            this.lbl_set.AutoSize = true;
            this.lbl_set.Location = new System.Drawing.Point(55, 76);
            this.lbl_set.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_set.Name = "lbl_set";
            this.lbl_set.Size = new System.Drawing.Size(29, 17);
            this.lbl_set.TabIndex = 6;
            this.lbl_set.Text = "Set";
            this.lbl_set.Visible = false;
             
            // 
            // txtinput1
            // 
            this.txtinput1.Location = new System.Drawing.Point(117, 73);
            this.txtinput1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtinput1.Name = "txtinput1";
            this.txtinput1.Size = new System.Drawing.Size(144, 22);
            this.txtinput1.TabIndex = 7;
            this.txtinput1.Visible = false;
      
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Location = new System.Drawing.Point(55, 122);
            this.lbl_to.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(25, 17);
            this.lbl_to.TabIndex = 8;
            this.lbl_to.Text = "To";
            this.lbl_to.Visible = false;
            // 
            // FormDialogInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 242);
            this.Controls.Add(this.lbl_to);
            this.Controls.Add(this.txtinput1);
            this.Controls.Add(this.lbl_set);
            this.Controls.Add(this.lbl_variabel);
            this.Controls.Add(this.lbl_tipedata);
            this.Controls.Add(this.txt_tipedata);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblprompt);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnBatal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDialogInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog Input";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblprompt;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox txt_tipedata;
        private System.Windows.Forms.Label lbl_tipedata;
        private System.Windows.Forms.Label lbl_variabel;
        private System.Windows.Forms.Label lbl_set;
        private System.Windows.Forms.TextBox txtinput1;
        private System.Windows.Forms.Label lbl_to;
    }
}