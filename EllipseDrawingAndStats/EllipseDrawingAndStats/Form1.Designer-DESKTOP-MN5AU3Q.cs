namespace EllipseDrawingAndStats
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
            this.centerLabel = new System.Windows.Forms.Label();
            this.centerXbox = new System.Windows.Forms.MaskedTextBox();
            this.centerYbox = new System.Windows.Forms.MaskedTextBox();
            this.comma1 = new System.Windows.Forms.Label();
            this.nonZeroCenterBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.fociTextLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // centerLabel
            // 
            this.centerLabel.AutoSize = true;
            this.centerLabel.Location = new System.Drawing.Point(30, 41);
            this.centerLabel.Name = "centerLabel";
            this.centerLabel.Size = new System.Drawing.Size(77, 25);
            this.centerLabel.TabIndex = 0;
            this.centerLabel.Text = "Center:";
            // 
            // centerXbox
            // 
            this.centerXbox.Enabled = false;
            this.centerXbox.Location = new System.Drawing.Point(113, 38);
            this.centerXbox.Mask = "00000";
            this.centerXbox.Name = "centerXbox";
            this.centerXbox.PromptChar = ' ';
            this.centerXbox.Size = new System.Drawing.Size(84, 29);
            this.centerXbox.TabIndex = 1;
            this.centerXbox.ValidatingType = typeof(int);
            // 
            // centerYbox
            // 
            this.centerYbox.Enabled = false;
            this.centerYbox.Location = new System.Drawing.Point(230, 38);
            this.centerYbox.Mask = "00000";
            this.centerYbox.Name = "centerYbox";
            this.centerYbox.PromptChar = ' ';
            this.centerYbox.Size = new System.Drawing.Size(84, 29);
            this.centerYbox.TabIndex = 2;
            this.centerYbox.ValidatingType = typeof(int);
            // 
            // comma1
            // 
            this.comma1.Location = new System.Drawing.Point(203, 44);
            this.comma1.Name = "comma1";
            this.comma1.Size = new System.Drawing.Size(21, 23);
            this.comma1.TabIndex = 3;
            this.comma1.Text = ",";
            // 
            // nonZeroCenterBox
            // 
            this.nonZeroCenterBox.AutoSize = true;
            this.nonZeroCenterBox.Checked = true;
            this.nonZeroCenterBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nonZeroCenterBox.Location = new System.Drawing.Point(35, 88);
            this.nonZeroCenterBox.Name = "nonZeroCenterBox";
            this.nonZeroCenterBox.Size = new System.Drawing.Size(183, 29);
            this.nonZeroCenterBox.TabIndex = 4;
            this.nonZeroCenterBox.Text = "Non-zero Center";
            this.nonZeroCenterBox.UseVisualStyleBackColor = true;
            this.nonZeroCenterBox.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ellipse Equation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Major Axis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Minor Axis:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(156, 231);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown1.TabIndex = 12;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(156, 283);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown2.TabIndex = 13;
            // 
            // fociTextLabel
            // 
            this.fociTextLabel.AutoSize = true;
            this.fociTextLabel.Location = new System.Drawing.Point(30, 400);
            this.fociTextLabel.Name = "fociTextLabel";
            this.fociTextLabel.Size = new System.Drawing.Size(55, 25);
            this.fociTextLabel.TabIndex = 14;
            this.fociTextLabel.Text = "Foci:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 779);
            this.Controls.Add(this.fociTextLabel);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nonZeroCenterBox);
            this.Controls.Add(this.comma1);
            this.Controls.Add(this.centerYbox);
            this.Controls.Add(this.centerXbox);
            this.Controls.Add(this.centerLabel);
            this.Name = "Form1";
            this.Text = "EllipseDrawingAndStats";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label centerLabel;
        private System.Windows.Forms.MaskedTextBox centerXbox;
        private System.Windows.Forms.MaskedTextBox centerYbox;
        private System.Windows.Forms.Label comma1;
        private System.Windows.Forms.CheckBox nonZeroCenterBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label fociTextLabel;
    }
}

