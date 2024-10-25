namespace NIC_FINDER
{
    partial class NIC_FINDER
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NIC_FINDER));
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picHelp = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tlTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNIC
            // 
            this.txtNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIC.Location = new System.Drawing.Point(18, 36);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(258, 38);
            this.txtNIC.TabIndex = 0;
            this.txtNIC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNIC_KeyDown);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(282, 36);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(67, 38);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "FIND";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblDay);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.txtDOB);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(33, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 361);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "AGE OF NIC HOLDER";
            // 
            // lblAge
            // 
            this.lblAge.BackColor = System.Drawing.Color.Gainsboro;
            this.lblAge.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(18, 313);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(331, 37);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "AGE";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGender
            // 
            this.lblGender.BackColor = System.Drawing.Color.Gainsboro;
            this.lblGender.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(18, 102);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(331, 44);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "GENDER";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDOB
            // 
            this.txtDOB.Font = new System.Drawing.Font("Calibri", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.Location = new System.Drawing.Point(18, 160);
            this.txtDOB.Multiline = true;
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(331, 43);
            this.txtDOB.TabIndex = 3;
            this.txtDOB.Text = "DATE OF BIRTH";
            this.txtDOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnFind);
            this.panel2.Controls.Add(this.txtNIC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 90);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ENTER YOUR NIC NUMBER AND PRESS ENTER";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 2);
            this.label2.TabIndex = 2;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "SOFTWARE BY : MUM. NIFRAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Gadugi", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(434, 80);
            this.label3.TabIndex = 3;
            this.label3.Text = "SRI LANKA NIC NUMBER CONVERTER";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlTip.SetToolTip(this.label3, "The Software Was Developed By: MUM. Nifras");
            // 
            // picHelp
            // 
            this.picHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picHelp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.picHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHelp.Image = ((System.Drawing.Image)(resources.GetObject("picHelp.Image")));
            this.picHelp.Location = new System.Drawing.Point(391, 479);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(37, 25);
            this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHelp.TabIndex = 4;
            this.picHelp.TabStop = false;
            this.picHelp.Click += new System.EventHandler(this.picHelp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(171, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "ON";
            // 
            // lblDay
            // 
            this.lblDay.BackColor = System.Drawing.Color.White;
            this.lblDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDay.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(18, 232);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(331, 42);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "DAY";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(367, 2);
            this.label7.TabIndex = 4;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlTip
            // 
            this.tlTip.ToolTipTitle = "About";
            // 
            // NIC_FINDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.picHelp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 550);
            this.Name = "NIC_FINDER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NIC FINDER";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picHelp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip tlTip;
    }
}

