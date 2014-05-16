namespace XBEEGui
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownAddress = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxControl = new System.Windows.Forms.ComboBox();
            this.buttonControl = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.textBoxTemp2 = new System.Windows.Forms.TextBox();
            this.textBoxRelay2 = new System.Windows.Forms.TextBox();
            this.textBoxTemp3 = new System.Windows.Forms.TextBox();
            this.textBoxRelay3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Address";
            // 
            // numericUpDownAddress
            // 
            this.numericUpDownAddress.Location = new System.Drawing.Point(100, 26);
            this.numericUpDownAddress.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownAddress.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownAddress.Name = "numericUpDownAddress";
            this.numericUpDownAddress.Size = new System.Drawing.Size(59, 20);
            this.numericUpDownAddress.TabIndex = 1;
            this.numericUpDownAddress.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Function";
            // 
            // comboBoxControl
            // 
            this.comboBoxControl.FormattingEnabled = true;
            this.comboBoxControl.Items.AddRange(new object[] {
            "Control Sensor",
            "Turn on Light",
            "Turn off Light"});
            this.comboBoxControl.Location = new System.Drawing.Point(100, 64);
            this.comboBoxControl.Name = "comboBoxControl";
            this.comboBoxControl.Size = new System.Drawing.Size(121, 21);
            this.comboBoxControl.TabIndex = 3;
            // 
            // buttonControl
            // 
            this.buttonControl.Location = new System.Drawing.Point(267, 62);
            this.buttonControl.Name = "buttonControl";
            this.buttonControl.Size = new System.Drawing.Size(75, 23);
            this.buttonControl.TabIndex = 4;
            this.buttonControl.Text = "Control";
            this.buttonControl.UseVisualStyleBackColor = true;
            this.buttonControl.Click += new System.EventHandler(this.buttonControl_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOutput.Location = new System.Drawing.Point(12, 107);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(379, 48);
            this.textBoxOutput.TabIndex = 5;
            this.textBoxOutput.TextChanged += new System.EventHandler(this.textBoxOutput_TextChanged);
            // 
            // textBoxTemp2
            // 
            this.textBoxTemp2.Location = new System.Drawing.Point(85, 211);
            this.textBoxTemp2.Name = "textBoxTemp2";
            this.textBoxTemp2.Size = new System.Drawing.Size(100, 20);
            this.textBoxTemp2.TabIndex = 6;
            // 
            // textBoxRelay2
            // 
            this.textBoxRelay2.Location = new System.Drawing.Point(85, 303);
            this.textBoxRelay2.Name = "textBoxRelay2";
            this.textBoxRelay2.Size = new System.Drawing.Size(100, 20);
            this.textBoxRelay2.TabIndex = 7;
            // 
            // textBoxTemp3
            // 
            this.textBoxTemp3.Location = new System.Drawing.Point(291, 211);
            this.textBoxTemp3.Name = "textBoxTemp3";
            this.textBoxTemp3.Size = new System.Drawing.Size(100, 20);
            this.textBoxTemp3.TabIndex = 8;
            // 
            // textBoxRelay3
            // 
            this.textBoxRelay3.Location = new System.Drawing.Point(291, 303);
            this.textBoxRelay3.Name = "textBoxRelay3";
            this.textBoxRelay3.Size = new System.Drawing.Size(100, 20);
            this.textBoxRelay3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Node 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Temperature";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "relay";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Node 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Temperature";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "relay";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 368);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRelay3);
            this.Controls.Add(this.textBoxTemp3);
            this.Controls.Add(this.textBoxRelay2);
            this.Controls.Add(this.textBoxTemp2);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonControl);
            this.Controls.Add(this.comboBoxControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownAddress);
            this.Name = "Form1";
            this.Text = "XBEE Base Station";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxControl;
        private System.Windows.Forms.Button buttonControl;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.TextBox textBoxTemp2;
        private System.Windows.Forms.TextBox textBoxRelay2;
        private System.Windows.Forms.TextBox textBoxTemp3;
        private System.Windows.Forms.TextBox textBoxRelay3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

    }
}

