namespace rbmtflowchartocode
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnRoundRect = new System.Windows.Forms.ToolStripButton();
            this.tsbtnParalellogram = new System.Windows.Forms.ToolStripButton();
            this.tsbtnoutput = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRectangle = new System.Windows.Forms.ToolStripButton();
            this.tsbtndiamond = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDiamondEllipse = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstripbtnremove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnExecute = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbPseudoCode = new System.Windows.Forms.RichTextBox();
            this.rtbHasil = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1273, 741);
            this.splitContainer1.SplitterDistance = 797;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.SizeChanged += new System.EventHandler(this.splitContainer2_Panel2_SizeChanged);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.splitContainer2_Panel2_MouseClick);
            this.splitContainer2.Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer2_Panel2_MouseMove);
            this.splitContainer2.Size = new System.Drawing.Size(797, 741);
            this.splitContainer2.SplitterDistance = 68;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Maroon;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnRoundRect,
            this.tsbtnParalellogram,
            this.tsbtnoutput,
            this.tsbtnRectangle,
            this.tsbtndiamond,
            this.tsBtnDiamondEllipse,
            this.toolStripSeparator1,
            this.toolstripbtnremove,
            this.toolStripSeparator2,
            this.tbtnExecute});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(797, 68);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnRoundRect
            // 
            this.tsBtnRoundRect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnRoundRect.Image = global::rbmtflowchartocode.Properties.Resources.new_document;
            this.tsBtnRoundRect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnRoundRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRoundRect.Name = "tsBtnRoundRect";
            this.tsBtnRoundRect.Size = new System.Drawing.Size(82, 65);
            this.tsBtnRoundRect.ToolTipText = "Dokumen Baru";
            this.tsBtnRoundRect.Click += new System.EventHandler(this.tsBtnRoundRect_Click);
            // 
            // tsbtnParalellogram
            // 
            this.tsbtnParalellogram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnParalellogram.Image = global::rbmtflowchartocode.Properties.Resources.input_data;
            this.tsbtnParalellogram.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnParalellogram.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnParalellogram.Name = "tsbtnParalellogram";
            this.tsbtnParalellogram.Size = new System.Drawing.Size(88, 65);
            this.tsbtnParalellogram.ToolTipText = "Input or Output Data";
            this.tsbtnParalellogram.Click += new System.EventHandler(this.tsbtnParalellogram_Click);
            // 
            // tsbtnoutput
            // 
            this.tsbtnoutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnoutput.Image = global::rbmtflowchartocode.Properties.Resources.output_data;
            this.tsbtnoutput.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnoutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnoutput.Name = "tsbtnoutput";
            this.tsbtnoutput.Size = new System.Drawing.Size(88, 65);
            this.tsbtnoutput.Text = "toolStripButton1";
            this.tsbtnoutput.Click += new System.EventHandler(this.tsbtnoutput_Click);
            // 
            // tsbtnRectangle
            // 
            this.tsbtnRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRectangle.Image = global::rbmtflowchartocode.Properties.Resources.process;
            this.tsbtnRectangle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRectangle.Name = "tsbtnRectangle";
            this.tsbtnRectangle.Size = new System.Drawing.Size(92, 65);
            this.tsbtnRectangle.ToolTipText = "Process";
            this.tsbtnRectangle.Click += new System.EventHandler(this.tsbtnRectangle_Click);
            // 
            // tsbtndiamond
            // 
            this.tsbtndiamond.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtndiamond.Image = global::rbmtflowchartocode.Properties.Resources.decision;
            this.tsbtndiamond.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtndiamond.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtndiamond.Name = "tsbtndiamond";
            this.tsbtndiamond.Size = new System.Drawing.Size(88, 65);
            this.tsbtndiamond.Text = "toolStripButton4";
            this.tsbtndiamond.ToolTipText = "Decision Block";
            this.tsbtndiamond.Click += new System.EventHandler(this.tsbtndiamond_Click);
            // 
            // tsBtnDiamondEllipse
            // 
            this.tsBtnDiamondEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnDiamondEllipse.Image = global::rbmtflowchartocode.Properties.Resources.loop;
            this.tsBtnDiamondEllipse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnDiamondEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDiamondEllipse.Name = "tsBtnDiamondEllipse";
            this.tsBtnDiamondEllipse.Size = new System.Drawing.Size(88, 65);
            this.tsBtnDiamondEllipse.Text = "Loop";
            this.tsBtnDiamondEllipse.Click += new System.EventHandler(this.tsBtnDiamondEllipse_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 68);
            // 
            // toolstripbtnremove
            // 
            this.toolstripbtnremove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstripbtnremove.Image = global::rbmtflowchartocode.Properties.Resources.remove;
            this.toolstripbtnremove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolstripbtnremove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripbtnremove.Name = "toolstripbtnremove";
            this.toolstripbtnremove.Size = new System.Drawing.Size(86, 65);
            this.toolstripbtnremove.Text = "toolStripButton1";
            this.toolstripbtnremove.ToolTipText = "Delete the Flow";
            this.toolstripbtnremove.Click += new System.EventHandler(this.toolstripbtnremove_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 68);
            // 
            // tbtnExecute
            // 
            this.tbtnExecute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnExecute.Image = global::rbmtflowchartocode.Properties.Resources.btnexecute;
            this.tbtnExecute.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtnExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnExecute.Name = "tbtnExecute";
            this.tbtnExecute.Size = new System.Drawing.Size(71, 65);
            this.tbtnExecute.Text = "toolStripButton5";
            this.tbtnExecute.ToolTipText = "Execute or Translate";
            this.tbtnExecute.Click += new System.EventHandler(this.tsbtnexecute_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rtbPseudoCode);
            this.panel1.Controls.Add(this.rtbHasil);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 741);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(236, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pseudocode:";
            // 
            // rtbPseudoCode
            // 
            this.rtbPseudoCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPseudoCode.BackColor = System.Drawing.Color.Black;
            this.rtbPseudoCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbPseudoCode.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPseudoCode.ForeColor = System.Drawing.Color.Lime;
            this.rtbPseudoCode.Location = new System.Drawing.Point(0, 49);
            this.rtbPseudoCode.Margin = new System.Windows.Forms.Padding(13, 10, 4, 4);
            this.rtbPseudoCode.Name = "rtbPseudoCode";
            this.rtbPseudoCode.ReadOnly = true;
            this.rtbPseudoCode.Size = new System.Drawing.Size(465, 320);
            this.rtbPseudoCode.TabIndex = 1;
            this.rtbPseudoCode.Text = "";
            // 
            // rtbHasil
            // 
            this.rtbHasil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbHasil.BackColor = System.Drawing.Color.Black;
            this.rtbHasil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbHasil.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHasil.ForeColor = System.Drawing.Color.Lime;
            this.rtbHasil.Location = new System.Drawing.Point(0, 423);
            this.rtbHasil.Margin = new System.Windows.Forms.Padding(13, 10, 4, 4);
            this.rtbHasil.Name = "rtbHasil";
            this.rtbHasil.ReadOnly = true;
            this.rtbHasil.Size = new System.Drawing.Size(465, 313);
            this.rtbHasil.TabIndex = 1;
            this.rtbHasil.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(227, 374);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Result:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 741);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rule Base Machine Translation :: . Flowchart To Code";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtbHasil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnRoundRect;
        private System.Windows.Forms.ToolStripButton tsbtnParalellogram;
        private System.Windows.Forms.ToolStripButton tsbtnRectangle;
        private System.Windows.Forms.ToolStripButton tsbtndiamond;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolstripbtnremove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbPseudoCode;
        private System.Windows.Forms.ToolStripButton tsBtnDiamondEllipse;
        private System.Windows.Forms.ToolStripButton tsbtnoutput;
    }
}

