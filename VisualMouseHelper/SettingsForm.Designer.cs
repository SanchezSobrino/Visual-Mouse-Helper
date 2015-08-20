namespace VisualMouseHelper
{
    partial class SettingsForm
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
            this.color1 = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.color2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.freq = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.posX = new System.Windows.Forms.NumericUpDown();
            this.posY = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.offsetY = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.offsetX = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.freq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetX)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Colour 1:";
            // 
            // color1
            // 
            this.color1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color1.Location = new System.Drawing.Point(178, 12);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(32, 27);
            this.color1.TabIndex = 1;
            // 
            // color2
            // 
            this.color2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color2.Location = new System.Drawing.Point(178, 42);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(32, 27);
            this.color2.TabIndex = 3;
            this.color2.Click += new System.EventHandler(this.color2_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Colour 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Blinking delay (ms):";
            // 
            // freq
            // 
            this.freq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freq.Location = new System.Drawing.Point(178, 75);
            this.freq.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.freq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.freq.Name = "freq";
            this.freq.Size = new System.Drawing.Size(77, 26);
            this.freq.TabIndex = 5;
            this.freq.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.freq.ValueChanged += new System.EventHandler(this.freq_Changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Size (px):";
            // 
            // size
            // 
            this.size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size.Location = new System.Drawing.Point(178, 107);
            this.size.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.size.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(77, 26);
            this.size.TabIndex = 7;
            this.size.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.size.ValueChanged += new System.EventHandler(this.size_Changed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Horizontal pos.";
            // 
            // posX
            // 
            this.posX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posX.Location = new System.Drawing.Point(178, 139);
            this.posX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.posX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.posX.Name = "posX";
            this.posX.Size = new System.Drawing.Size(77, 26);
            this.posX.TabIndex = 9;
            this.posX.ValueChanged += new System.EventHandler(this.posX_Changed);
            // 
            // posY
            // 
            this.posY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posY.Location = new System.Drawing.Point(178, 171);
            this.posY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.posY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.posY.Name = "posY";
            this.posY.Size = new System.Drawing.Size(77, 26);
            this.posY.TabIndex = 11;
            this.posY.ValueChanged += new System.EventHandler(this.posY_Changed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vertical pos.";
            // 
            // offsetY
            // 
            this.offsetY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offsetY.Location = new System.Drawing.Point(178, 235);
            this.offsetY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.offsetY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.offsetY.Name = "offsetY";
            this.offsetY.Size = new System.Drawing.Size(77, 26);
            this.offsetY.TabIndex = 15;
            this.offsetY.ValueChanged += new System.EventHandler(this.offsetY_Changed);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Vertical offset:";
            // 
            // offsetX
            // 
            this.offsetX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offsetX.Location = new System.Drawing.Point(178, 203);
            this.offsetX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.offsetX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.offsetX.Name = "offsetX";
            this.offsetX.Size = new System.Drawing.Size(77, 26);
            this.offsetX.TabIndex = 13;
            this.offsetX.ValueChanged += new System.EventHandler(this.offsetX_Changed);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Horizontal offset:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 269);
            this.Controls.Add(this.offsetY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.offsetX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.posY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.posX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.size);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.freq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsForm";
            this.Text = "Configuración";
            ((System.ComponentModel.ISupportInitialize)(this.freq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel color1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel color2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown freq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown size;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown posX;
        private System.Windows.Forms.NumericUpDown posY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown offsetY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown offsetX;
        private System.Windows.Forms.Label label8;
    }
}