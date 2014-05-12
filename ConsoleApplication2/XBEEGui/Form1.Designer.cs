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
            this.buttonControl.Location = new System.Drawing.Point(100, 111);
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
            this.textBoxOutput.Location = new System.Drawing.Point(16, 169);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(379, 187);
            this.textBoxOutput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 368);
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

    }
}

