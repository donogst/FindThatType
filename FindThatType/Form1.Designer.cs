namespace FindThatType
{
    partial class FindThatType
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnLoadLibs = new System.Windows.Forms.Button();
            this.lstLibs = new System.Windows.Forms.ListBox();
            this.lstTypes = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkCase = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstHits = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoadLibs);
            this.panel1.Controls.Add(this.btnSelectFolder);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 32);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 32);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstHits);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(730, 385);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lstLibs);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lstTypes);
            this.splitContainer2.Size = new System.Drawing.Size(730, 200);
            this.splitContainer2.SplitterDistance = 110;
            this.splitContainer2.TabIndex = 0;
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(115, 5);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(485, 22);
            this.txtPath.TabIndex = 0;
            this.txtPath.Text = "c:\\Dev";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(5, 3);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(106, 24);
            this.btnSelectFolder.TabIndex = 1;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnLoadLibs
            // 
            this.btnLoadLibs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadLibs.Location = new System.Drawing.Point(606, 4);
            this.btnLoadLibs.Name = "btnLoadLibs";
            this.btnLoadLibs.Size = new System.Drawing.Size(119, 23);
            this.btnLoadLibs.TabIndex = 2;
            this.btnLoadLibs.Text = "Load Libraries";
            this.btnLoadLibs.UseVisualStyleBackColor = true;
            this.btnLoadLibs.Click += new System.EventHandler(this.btnLoadLibs_Click);
            // 
            // lstLibs
            // 
            this.lstLibs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLibs.FormattingEnabled = true;
            this.lstLibs.ItemHeight = 16;
            this.lstLibs.Location = new System.Drawing.Point(0, 0);
            this.lstLibs.Name = "lstLibs";
            this.lstLibs.Size = new System.Drawing.Size(730, 110);
            this.lstLibs.TabIndex = 0;
            this.lstLibs.SelectedIndexChanged += new System.EventHandler(this.lstLibs_SelectedIndexChanged);
            // 
            // lstTypes
            // 
            this.lstTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTypes.FormattingEnabled = true;
            this.lstTypes.ItemHeight = 16;
            this.lstTypes.Location = new System.Drawing.Point(0, 0);
            this.lstTypes.Name = "lstTypes";
            this.lstTypes.Size = new System.Drawing.Size(730, 86);
            this.lstTypes.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.chkCase);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 31);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(45, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(465, 22);
            this.textBox1.TabIndex = 1;
            // 
            // chkCase
            // 
            this.chkCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCase.AutoSize = true;
            this.chkCase.Location = new System.Drawing.Point(516, 4);
            this.chkCase.Name = "chkCase";
            this.chkCase.Size = new System.Drawing.Size(123, 21);
            this.chkCase.TabIndex = 2;
            this.chkCase.Text = "Case Sensitive";
            this.chkCase.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(645, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstFinds
            // 
            this.lstHits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstHits.FormattingEnabled = true;
            this.lstHits.ItemHeight = 16;
            this.lstHits.Location = new System.Drawing.Point(0, 31);
            this.lstHits.Name = "lstFinds";
            this.lstHits.Size = new System.Drawing.Size(730, 150);
            this.lstHits.TabIndex = 1;
            // 
            // FindThatType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 417);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(326, 244);
            this.Name = "FindThatType";
            this.Text = "Find That Type";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoadLibs;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox lstLibs;
        private System.Windows.Forms.ListBox lstTypes;
        private System.Windows.Forms.ListBox lstHits;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkCase;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

