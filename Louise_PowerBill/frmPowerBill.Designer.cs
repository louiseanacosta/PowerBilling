namespace Louise_PowerBill
{
    partial class frmPowerBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPowerBill));
            this.lblUsage = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.radResidential = new System.Windows.Forms.RadioButton();
            this.radCommercial = new System.Windows.Forms.RadioButton();
            this.radIndustrial = new System.Windows.Forms.RadioButton();
            this.pnlindustrial = new System.Windows.Forms.Panel();
            this.txtOffPeakCharge = new System.Windows.Forms.TextBox();
            this.txtPeakCharge = new System.Windows.Forms.TextBox();
            this.lblOffPeakCharge = new System.Windows.Forms.Label();
            this.lblPeakCharge = new System.Windows.Forms.Label();
            this.txtOffPeakUsage = new System.Windows.Forms.TextBox();
            this.txtPeakUsage = new System.Windows.Forms.TextBox();
            this.lblOffPeakUsage = new System.Windows.Forms.Label();
            this.lblPeakUsage = new System.Windows.Forms.Label();
            this.lblCustType = new System.Windows.Forms.Label();
            this.pnlUsage = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlindustrial.SuspendLayout();
            this.pnlUsage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsage
            // 
            this.lblUsage.AutoSize = true;
            this.lblUsage.BackColor = System.Drawing.SystemColors.Control;
            this.lblUsage.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsage.Location = new System.Drawing.Point(23, 15);
            this.lblUsage.Name = "lblUsage";
            this.lblUsage.Size = new System.Drawing.Size(312, 43);
            this.lblUsage.TabIndex = 0;
            this.lblUsage.Text = "Enter Usage (kWh):";
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.BackColor = System.Drawing.SystemColors.Control;
            this.lblBill.Font = new System.Drawing.Font("Trebuchet MS", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.Location = new System.Drawing.Point(498, 661);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(189, 49);
            this.lblBill.TabIndex = 1;
            this.lblBill.Text = "Total Bill:";
            // 
            // txtUsage
            // 
            this.txtUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsage.Location = new System.Drawing.Point(381, 15);
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.Size = new System.Drawing.Size(392, 45);
            this.txtUsage.TabIndex = 0;
            // 
            // txtBill
            // 
            this.txtBill.BackColor = System.Drawing.SystemColors.Info;
            this.txtBill.Enabled = false;
            this.txtBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBill.Location = new System.Drawing.Point(693, 659);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(361, 49);
            this.txtBill.TabIndex = 6;
            this.txtBill.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(479, 758);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(235, 59);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(720, 758);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(190, 59);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(916, 758);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(190, 59);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // radResidential
            // 
            this.radResidential.AutoSize = true;
            this.radResidential.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radResidential.Location = new System.Drawing.Point(401, 221);
            this.radResidential.Name = "radResidential";
            this.radResidential.Size = new System.Drawing.Size(226, 47);
            this.radResidential.TabIndex = 0;
            this.radResidential.Text = "R&esidential";
            this.radResidential.UseVisualStyleBackColor = true;
            this.radResidential.CheckedChanged += new System.EventHandler(this.radResidential_CheckedChanged);
            // 
            // radCommercial
            // 
            this.radCommercial.AutoSize = true;
            this.radCommercial.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCommercial.Location = new System.Drawing.Point(673, 221);
            this.radCommercial.Name = "radCommercial";
            this.radCommercial.Size = new System.Drawing.Size(237, 47);
            this.radCommercial.TabIndex = 1;
            this.radCommercial.Text = "C&ommercial";
            this.radCommercial.UseVisualStyleBackColor = true;
            this.radCommercial.CheckedChanged += new System.EventHandler(this.radCommercial_CheckedChanged);
            // 
            // radIndustrial
            // 
            this.radIndustrial.AutoSize = true;
            this.radIndustrial.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIndustrial.Location = new System.Drawing.Point(956, 221);
            this.radIndustrial.Name = "radIndustrial";
            this.radIndustrial.Size = new System.Drawing.Size(200, 47);
            this.radIndustrial.TabIndex = 2;
            this.radIndustrial.Text = "I&ndustrial";
            this.radIndustrial.UseVisualStyleBackColor = true;
            this.radIndustrial.CheckedChanged += new System.EventHandler(this.radIndustrial_CheckedChanged);
            // 
            // pnlindustrial
            // 
            this.pnlindustrial.Controls.Add(this.txtOffPeakCharge);
            this.pnlindustrial.Controls.Add(this.txtPeakCharge);
            this.pnlindustrial.Controls.Add(this.lblOffPeakCharge);
            this.pnlindustrial.Controls.Add(this.lblPeakCharge);
            this.pnlindustrial.Controls.Add(this.txtOffPeakUsage);
            this.pnlindustrial.Controls.Add(this.txtPeakUsage);
            this.pnlindustrial.Controls.Add(this.lblOffPeakUsage);
            this.pnlindustrial.Controls.Add(this.lblPeakUsage);
            this.pnlindustrial.Location = new System.Drawing.Point(188, 370);
            this.pnlindustrial.Name = "pnlindustrial";
            this.pnlindustrial.Size = new System.Drawing.Size(1192, 268);
            this.pnlindustrial.TabIndex = 9;
            this.pnlindustrial.Visible = false;
            // 
            // txtOffPeakCharge
            // 
            this.txtOffPeakCharge.BackColor = System.Drawing.SystemColors.Info;
            this.txtOffPeakCharge.Enabled = false;
            this.txtOffPeakCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOffPeakCharge.Location = new System.Drawing.Point(758, 205);
            this.txtOffPeakCharge.Name = "txtOffPeakCharge";
            this.txtOffPeakCharge.Size = new System.Drawing.Size(374, 45);
            this.txtOffPeakCharge.TabIndex = 5;
            this.txtOffPeakCharge.TabStop = false;
            // 
            // txtPeakCharge
            // 
            this.txtPeakCharge.BackColor = System.Drawing.SystemColors.Info;
            this.txtPeakCharge.Enabled = false;
            this.txtPeakCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeakCharge.Location = new System.Drawing.Point(758, 149);
            this.txtPeakCharge.Name = "txtPeakCharge";
            this.txtPeakCharge.Size = new System.Drawing.Size(374, 45);
            this.txtPeakCharge.TabIndex = 4;
            this.txtPeakCharge.TabStop = false;
            // 
            // lblOffPeakCharge
            // 
            this.lblOffPeakCharge.AutoSize = true;
            this.lblOffPeakCharge.BackColor = System.Drawing.SystemColors.Control;
            this.lblOffPeakCharge.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffPeakCharge.Location = new System.Drawing.Point(33, 203);
            this.lblOffPeakCharge.Name = "lblOffPeakCharge";
            this.lblOffPeakCharge.Size = new System.Drawing.Size(570, 43);
            this.lblOffPeakCharge.TabIndex = 13;
            this.lblOffPeakCharge.Text = "Total charges during off peak hours:";
            // 
            // lblPeakCharge
            // 
            this.lblPeakCharge.AutoSize = true;
            this.lblPeakCharge.BackColor = System.Drawing.SystemColors.Control;
            this.lblPeakCharge.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeakCharge.Location = new System.Drawing.Point(33, 145);
            this.lblPeakCharge.Name = "lblPeakCharge";
            this.lblPeakCharge.Size = new System.Drawing.Size(516, 43);
            this.lblPeakCharge.TabIndex = 12;
            this.lblPeakCharge.Text = "Total charges during peak hours:";
            // 
            // txtOffPeakUsage
            // 
            this.txtOffPeakUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOffPeakUsage.Location = new System.Drawing.Point(758, 82);
            this.txtOffPeakUsage.Name = "txtOffPeakUsage";
            this.txtOffPeakUsage.Size = new System.Drawing.Size(374, 45);
            this.txtOffPeakUsage.TabIndex = 2;
            // 
            // txtPeakUsage
            // 
            this.txtPeakUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeakUsage.Location = new System.Drawing.Point(758, 16);
            this.txtPeakUsage.Name = "txtPeakUsage";
            this.txtPeakUsage.Size = new System.Drawing.Size(374, 45);
            this.txtPeakUsage.TabIndex = 1;
            // 
            // lblOffPeakUsage
            // 
            this.lblOffPeakUsage.AutoSize = true;
            this.lblOffPeakUsage.BackColor = System.Drawing.SystemColors.Control;
            this.lblOffPeakUsage.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffPeakUsage.Location = new System.Drawing.Point(33, 82);
            this.lblOffPeakUsage.Name = "lblOffPeakUsage";
            this.lblOffPeakUsage.Size = new System.Drawing.Size(648, 43);
            this.lblOffPeakUsage.TabIndex = 11;
            this.lblOffPeakUsage.Text = "Enter usage (kWh) during off-peak hours:";
            // 
            // lblPeakUsage
            // 
            this.lblPeakUsage.AutoSize = true;
            this.lblPeakUsage.BackColor = System.Drawing.SystemColors.Control;
            this.lblPeakUsage.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeakUsage.Location = new System.Drawing.Point(29, 14);
            this.lblPeakUsage.Name = "lblPeakUsage";
            this.lblPeakUsage.Size = new System.Drawing.Size(592, 43);
            this.lblPeakUsage.TabIndex = 10;
            this.lblPeakUsage.Text = "Enter usage (kWh) during peak hours:";
            // 
            // lblCustType
            // 
            this.lblCustType.AutoSize = true;
            this.lblCustType.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustType.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustType.Location = new System.Drawing.Point(303, 146);
            this.lblCustType.Name = "lblCustType";
            this.lblCustType.Size = new System.Drawing.Size(359, 43);
            this.lblCustType.TabIndex = 10;
            this.lblCustType.Text = "Select Customer Type:";
            // 
            // pnlUsage
            // 
            this.pnlUsage.Controls.Add(this.txtUsage);
            this.pnlUsage.Controls.Add(this.lblUsage);
            this.pnlUsage.Location = new System.Drawing.Point(307, 292);
            this.pnlUsage.Name = "pnlUsage";
            this.pnlUsage.Size = new System.Drawing.Size(820, 72);
            this.pnlUsage.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.Location = new System.Drawing.Point(487, 61);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(593, 48);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Power Bill Calculator";
            // 
            // frmPowerBill
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1618, 1008);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlUsage);
            this.Controls.Add(this.lblCustType);
            this.Controls.Add(this.pnlindustrial);
            this.Controls.Add(this.radIndustrial);
            this.Controls.Add(this.radCommercial);
            this.Controls.Add(this.radResidential);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.lblBill);
            this.Name = "frmPowerBill";
            this.Text = "Power Bill Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlindustrial.ResumeLayout(false);
            this.pnlindustrial.PerformLayout();
            this.pnlUsage.ResumeLayout(false);
            this.pnlUsage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsage;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radResidential;
        private System.Windows.Forms.RadioButton radCommercial;
        private System.Windows.Forms.RadioButton radIndustrial;
        private System.Windows.Forms.Panel pnlindustrial;
        private System.Windows.Forms.Label lblOffPeakUsage;
        private System.Windows.Forms.Label lblPeakUsage;
        private System.Windows.Forms.Label lblOffPeakCharge;
        private System.Windows.Forms.Label lblPeakCharge;
        private System.Windows.Forms.TextBox txtOffPeakUsage;
        private System.Windows.Forms.TextBox txtPeakUsage;
        private System.Windows.Forms.TextBox txtOffPeakCharge;
        private System.Windows.Forms.TextBox txtPeakCharge;
        private System.Windows.Forms.Label lblCustType;
        private System.Windows.Forms.Panel pnlUsage;
        private System.Windows.Forms.Label lblTitle;
    }
}

