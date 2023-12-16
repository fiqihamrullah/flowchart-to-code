namespace rbmtflowchartocode
{
    partial class FormDialogChoice
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
            this.lblprompt = new System.Windows.Forms.Label();
            this.btnChoose2 = new System.Windows.Forms.Button();
            this.btnChoose1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblprompt
            // 
            this.lblprompt.AutoSize = true;
            this.lblprompt.Location = new System.Drawing.Point(25, 28);
            this.lblprompt.Name = "lblprompt";
            this.lblprompt.Size = new System.Drawing.Size(31, 13);
            this.lblprompt.TabIndex = 0;
            this.lblprompt.Text = "????";
            // 
            // btnChoose2
            // 
            this.btnChoose2.Location = new System.Drawing.Point(225, 115);
            this.btnChoose2.Name = "btnChoose2";
            this.btnChoose2.Size = new System.Drawing.Size(82, 31);
            this.btnChoose2.TabIndex = 1;
            this.btnChoose2.UseVisualStyleBackColor = true;
            this.btnChoose2.Click += new System.EventHandler(this.btnChoose2_Click);
            // 
            // btnChoose1
            // 
            this.btnChoose1.Location = new System.Drawing.Point(139, 115);
            this.btnChoose1.Name = "btnChoose1";
            this.btnChoose1.Size = new System.Drawing.Size(80, 31);
            this.btnChoose1.TabIndex = 2;
            this.btnChoose1.UseVisualStyleBackColor = true;
            this.btnChoose1.Click += new System.EventHandler(this.btnChoose1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(314, 115);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 30);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormDialogChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 158);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChoose1);
            this.Controls.Add(this.btnChoose2);
            this.Controls.Add(this.lblprompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDialogChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose";
            this.Load += new System.EventHandler(this.FormDialogChoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprompt;
        private System.Windows.Forms.Button btnChoose2;
        private System.Windows.Forms.Button btnChoose1;
        private System.Windows.Forms.Button btnCancel;
    }
}