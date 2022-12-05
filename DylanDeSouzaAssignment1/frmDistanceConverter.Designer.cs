namespace DylanDeSouzaAssignment1
{
    partial class frmDistanceConverter
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
            this.lblValueToBeConverted = new System.Windows.Forms.Label();
            this.btnInchesCentimetres = new System.Windows.Forms.Button();
            this.btnFeetMetres = new System.Windows.Forms.Button();
            this.btnYardsMetres = new System.Windows.Forms.Button();
            this.btnMilesKilometres = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtEnteredValue = new System.Windows.Forms.TextBox();
            this.txtConversion = new System.Windows.Forms.TextBox();
            this.lblEnteredValue = new System.Windows.Forms.Label();
            this.lblConversion = new System.Windows.Forms.Label();
            this.lblEquals = new System.Windows.Forms.Label();
            this.lstTypeOfConversion = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblValueToBeConverted
            // 
            this.lblValueToBeConverted.AutoSize = true;
            this.lblValueToBeConverted.Location = new System.Drawing.Point(166, 151);
            this.lblValueToBeConverted.Name = "lblValueToBeConverted";
            this.lblValueToBeConverted.Size = new System.Drawing.Size(157, 13);
            this.lblValueToBeConverted.TabIndex = 0;
            this.lblValueToBeConverted.Text = "Enter the value to be converted";
            // 
            // btnInchesCentimetres
            // 
            this.btnInchesCentimetres.Location = new System.Drawing.Point(184, 211);
            this.btnInchesCentimetres.Name = "btnInchesCentimetres";
            this.btnInchesCentimetres.Size = new System.Drawing.Size(126, 23);
            this.btnInchesCentimetres.TabIndex = 1;
            this.btnInchesCentimetres.Text = "&Inches to Centimetres";
            this.btnInchesCentimetres.UseVisualStyleBackColor = true;
            this.btnInchesCentimetres.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFeetMetres
            // 
            this.btnFeetMetres.Location = new System.Drawing.Point(184, 240);
            this.btnFeetMetres.Name = "btnFeetMetres";
            this.btnFeetMetres.Size = new System.Drawing.Size(100, 23);
            this.btnFeetMetres.TabIndex = 2;
            this.btnFeetMetres.Text = "&Feet to Metres";
            this.btnFeetMetres.UseVisualStyleBackColor = true;
            this.btnFeetMetres.Click += new System.EventHandler(this.btnFeetMetres_Click);
            // 
            // btnYardsMetres
            // 
            this.btnYardsMetres.Location = new System.Drawing.Point(184, 269);
            this.btnYardsMetres.Name = "btnYardsMetres";
            this.btnYardsMetres.Size = new System.Drawing.Size(100, 23);
            this.btnYardsMetres.TabIndex = 3;
            this.btnYardsMetres.Text = "&Yards to Metres";
            this.btnYardsMetres.UseVisualStyleBackColor = true;
            this.btnYardsMetres.Click += new System.EventHandler(this.btnYardsMetres_Click);
            // 
            // btnMilesKilometres
            // 
            this.btnMilesKilometres.Location = new System.Drawing.Point(184, 298);
            this.btnMilesKilometres.Name = "btnMilesKilometres";
            this.btnMilesKilometres.Size = new System.Drawing.Size(107, 23);
            this.btnMilesKilometres.TabIndex = 4;
            this.btnMilesKilometres.Text = "&Miles to Kilometres";
            this.btnMilesKilometres.UseVisualStyleBackColor = true;
            this.btnMilesKilometres.Click += new System.EventHandler(this.btnKilometres_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(354, 298);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtEnteredValue
            // 
            this.txtEnteredValue.Location = new System.Drawing.Point(169, 167);
            this.txtEnteredValue.Name = "txtEnteredValue";
            this.txtEnteredValue.Size = new System.Drawing.Size(100, 20);
            this.txtEnteredValue.TabIndex = 11;
            this.txtEnteredValue.Enter += new System.EventHandler(this.txtEnteredValue_Enter);
            this.txtEnteredValue.Leave += new System.EventHandler(this.txtEnteredValue_Leave);
            // 
            // txtConversion
            // 
            this.txtConversion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtConversion.Location = new System.Drawing.Point(329, 167);
            this.txtConversion.Name = "txtConversion";
            this.txtConversion.ReadOnly = true;
            this.txtConversion.ShortcutsEnabled = false;
            this.txtConversion.Size = new System.Drawing.Size(100, 20);
            this.txtConversion.TabIndex = 12;
            this.txtConversion.TabStop = false;
            this.txtConversion.Visible = false;
            // 
            // lblEnteredValue
            // 
            this.lblEnteredValue.AutoSize = true;
            this.lblEnteredValue.Location = new System.Drawing.Point(275, 174);
            this.lblEnteredValue.Name = "lblEnteredValue";
            this.lblEnteredValue.Size = new System.Drawing.Size(35, 13);
            this.lblEnteredValue.TabIndex = 13;
            this.lblEnteredValue.Text = "label1";
            this.lblEnteredValue.Visible = false;
            // 
            // lblConversion
            // 
            this.lblConversion.AutoSize = true;
            this.lblConversion.Location = new System.Drawing.Point(435, 174);
            this.lblConversion.Name = "lblConversion";
            this.lblConversion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblConversion.Size = new System.Drawing.Size(35, 13);
            this.lblConversion.TabIndex = 14;
            this.lblConversion.Text = "label2";
            this.lblConversion.Visible = false;
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Location = new System.Drawing.Point(310, 174);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(13, 13);
            this.lblEquals.TabIndex = 15;
            this.lblEquals.Text = "=";
            this.lblEquals.Visible = false;
            // 
            // lstTypeOfConversion
            // 
            this.lstTypeOfConversion.BackColor = System.Drawing.SystemColors.Menu;
            this.lstTypeOfConversion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTypeOfConversion.ForeColor = System.Drawing.Color.Blue;
            this.lstTypeOfConversion.FormattingEnabled = true;
            this.lstTypeOfConversion.Items.AddRange(new object[] {
            "Type of conversion"});
            this.lstTypeOfConversion.Location = new System.Drawing.Point(169, 193);
            this.lstTypeOfConversion.Name = "lstTypeOfConversion";
            this.lstTypeOfConversion.Size = new System.Drawing.Size(154, 132);
            this.lstTypeOfConversion.TabIndex = 16;
            this.lstTypeOfConversion.TabStop = false;
            // 
            // frmDistanceConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.lblConversion);
            this.Controls.Add(this.lblEnteredValue);
            this.Controls.Add(this.txtConversion);
            this.Controls.Add(this.txtEnteredValue);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMilesKilometres);
            this.Controls.Add(this.btnYardsMetres);
            this.Controls.Add(this.btnFeetMetres);
            this.Controls.Add(this.btnInchesCentimetres);
            this.Controls.Add(this.lblValueToBeConverted);
            this.Controls.Add(this.lstTypeOfConversion);
            this.Name = "frmDistanceConverter";
            this.Text = "Distance Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValueToBeConverted;
        private System.Windows.Forms.Button btnInchesCentimetres;
        private System.Windows.Forms.Button btnFeetMetres;
        private System.Windows.Forms.Button btnYardsMetres;
        private System.Windows.Forms.Button btnMilesKilometres;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtEnteredValue;
        private System.Windows.Forms.Label lblEnteredValue;
        private System.Windows.Forms.Label lblConversion;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.ListBox lstTypeOfConversion;
        public System.Windows.Forms.TextBox txtConversion;
    }
}

