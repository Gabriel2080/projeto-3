namespace Projeto_3_Principal
{
    partial class Form2
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.RGB = new System.Windows.Forms.GroupBox();
            this.Blue = new System.Windows.Forms.Label();
            this.Green = new System.Windows.Forms.Label();
            this.Red = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.RGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(73, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 96);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(212, 243);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(22, 32);
            this.panel2.TabIndex = 6;
            // 
            // RGB
            // 
            this.RGB.BackColor = System.Drawing.Color.White;
            this.RGB.Controls.Add(this.Blue);
            this.RGB.Controls.Add(this.Green);
            this.RGB.Controls.Add(this.Red);
            this.RGB.Controls.Add(this.numericUpDown3);
            this.RGB.Controls.Add(this.numericUpDown2);
            this.RGB.Controls.Add(this.numericUpDown1);
            this.RGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGB.Location = new System.Drawing.Point(235, 0);
            this.RGB.Name = "RGB";
            this.RGB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RGB.Size = new System.Drawing.Size(269, 326);
            this.RGB.TabIndex = 0;
            this.RGB.TabStop = false;
            this.RGB.Text = "RGB";
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Location = new System.Drawing.Point(19, 175);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(41, 20);
            this.Blue.TabIndex = 5;
            this.Blue.Text = "Blue";
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.Location = new System.Drawing.Point(6, 143);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(54, 20);
            this.Green.TabIndex = 4;
            this.Green.Text = "Green";
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.Location = new System.Drawing.Point(21, 111);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(39, 20);
            this.Red.TabIndex = 3;
            this.Red.Text = "Red";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(66, 173);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown3.TabIndex = 2;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(66, 141);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(66, 109);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Projeto_3_Principal.Properties.Resources.placa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(437, 314);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RGB);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.RGB.ResumeLayout(false);
            this.RGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox RGB;
        private System.Windows.Forms.Label Blue;
        private System.Windows.Forms.Label Green;
        private System.Windows.Forms.Label Red;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel2;
    }
}