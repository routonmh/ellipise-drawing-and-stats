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
            this.nonZeroCenterBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.heightUpDown = new System.Windows.Forms.NumericUpDown();
            this.widthUpDown = new System.Windows.Forms.NumericUpDown();
            this.centerXBox = new System.Windows.Forms.NumericUpDown();
            this.centerYBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerXBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerYBox)).BeginInit();
            this.SuspendLayout();
            // 
            // centerLabel
            // 
            this.centerLabel.AutoSize = true;
            this.centerLabel.Location = new System.Drawing.Point(19, 454);
            this.centerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.centerLabel.Name = "centerLabel";
            this.centerLabel.Size = new System.Drawing.Size(41, 13);
            this.centerLabel.TabIndex = 0;
            this.centerLabel.Text = "Center:";
            // 
            // nonZeroCenterBox
            // 
            this.nonZeroCenterBox.AutoSize = true;
            this.nonZeroCenterBox.Checked = true;
            this.nonZeroCenterBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nonZeroCenterBox.Location = new System.Drawing.Point(22, 480);
            this.nonZeroCenterBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nonZeroCenterBox.Name = "nonZeroCenterBox";
            this.nonZeroCenterBox.Size = new System.Drawing.Size(103, 17);
            this.nonZeroCenterBox.TabIndex = 4;
            this.nonZeroCenterBox.Text = "Non-zero Center";
            this.nonZeroCenterBox.UseVisualStyleBackColor = true;
            this.nonZeroCenterBox.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 508);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ellipse Equation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 454);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Height:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 484);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Width";
            // 
            // heightUpDown
            // 
            this.heightUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.heightUpDown.Location = new System.Drawing.Point(360, 454);
            this.heightUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.heightUpDown.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.heightUpDown.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.heightUpDown.Name = "heightUpDown";
            this.heightUpDown.Size = new System.Drawing.Size(65, 20);
            this.heightUpDown.TabIndex = 12;
            this.heightUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.heightUpDown.ValueChanged += new System.EventHandler(this.heightUpDown_ValueChanged);
            // 
            // widthUpDown
            // 
            this.widthUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.widthUpDown.Location = new System.Drawing.Point(360, 482);
            this.widthUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.widthUpDown.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.widthUpDown.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.widthUpDown.Name = "widthUpDown";
            this.widthUpDown.Size = new System.Drawing.Size(65, 20);
            this.widthUpDown.TabIndex = 13;
            this.widthUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.widthUpDown.ValueChanged += new System.EventHandler(this.widthUpDown_ValueChanged);
            // 
            // centerXBox
            // 
            this.centerXBox.Enabled = false;
            this.centerXBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.centerXBox.Location = new System.Drawing.Point(65, 453);
            this.centerXBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.centerXBox.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.centerXBox.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.centerXBox.Name = "centerXBox";
            this.centerXBox.Size = new System.Drawing.Size(40, 20);
            this.centerXBox.TabIndex = 16;
            this.centerXBox.ValueChanged += new System.EventHandler(this.centerXBox_ValueChanged);
            // 
            // centerYBox
            // 
            this.centerYBox.Enabled = false;
            this.centerYBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.centerYBox.Location = new System.Drawing.Point(113, 453);
            this.centerYBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.centerYBox.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.centerYBox.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.centerYBox.Name = "centerYBox";
            this.centerYBox.Size = new System.Drawing.Size(40, 20);
            this.centerYBox.TabIndex = 17;
            this.centerYBox.ValueChanged += new System.EventHandler(this.centerYBox_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 557);
            this.Controls.Add(this.centerYBox);
            this.Controls.Add(this.centerXBox);
            this.Controls.Add(this.widthUpDown);
            this.Controls.Add(this.heightUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nonZeroCenterBox);
            this.Controls.Add(this.centerLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "EllipseDrawingAndStats";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerXBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerYBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label centerLabel;
        private System.Windows.Forms.CheckBox nonZeroCenterBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown heightUpDown;
        private System.Windows.Forms.NumericUpDown widthUpDown;
        private System.Windows.Forms.NumericUpDown centerXBox;
        private System.Windows.Forms.NumericUpDown centerYBox;
    }
}

