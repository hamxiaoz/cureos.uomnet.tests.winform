namespace cureos.uomnet.tests.winform
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox_MeasurementTypes = new System.Windows.Forms.ListBox();
            this.listBox_UnitsFrom = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.listBox_UnitsTo = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox_MeasurementTypes
            // 
            this.listBox_MeasurementTypes.FormattingEnabled = true;
            this.listBox_MeasurementTypes.Location = new System.Drawing.Point(13, 59);
            this.listBox_MeasurementTypes.Name = "listBox_MeasurementTypes";
            this.listBox_MeasurementTypes.ScrollAlwaysVisible = true;
            this.listBox_MeasurementTypes.Size = new System.Drawing.Size(136, 264);
            this.listBox_MeasurementTypes.TabIndex = 2;
            this.listBox_MeasurementTypes.SelectedIndexChanged += new System.EventHandler(this.listBox_MeasurementTypes_SelectedIndexChanged);
            // 
            // listBox_UnitsFrom
            // 
            this.listBox_UnitsFrom.FormattingEnabled = true;
            this.listBox_UnitsFrom.Location = new System.Drawing.Point(168, 59);
            this.listBox_UnitsFrom.Name = "listBox_UnitsFrom";
            this.listBox_UnitsFrom.Size = new System.Drawing.Size(136, 69);
            this.listBox_UnitsFrom.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(168, 135);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Location = new System.Drawing.Point(428, 135);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 6;
            // 
            // listBox_UnitsTo
            // 
            this.listBox_UnitsTo.FormattingEnabled = true;
            this.listBox_UnitsTo.Location = new System.Drawing.Point(428, 59);
            this.listBox_UnitsTo.Name = "listBox_UnitsTo";
            this.listBox_UnitsTo.Size = new System.Drawing.Size(136, 69);
            this.listBox_UnitsTo.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Convert to";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 327);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.listBox_UnitsTo);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listBox_UnitsFrom);
            this.Controls.Add(this.listBox_MeasurementTypes);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox_MeasurementTypes;
        private System.Windows.Forms.ListBox listBox_UnitsFrom;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ListBox listBox_UnitsTo;
        private System.Windows.Forms.Button button2;
    }
}

