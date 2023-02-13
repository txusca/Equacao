namespace Equacao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtXv = new System.Windows.Forms.TextBox();
            this.txtYv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite a Esquação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aqui será mostrado o Gráfico da função";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(42, 57);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(49, 27);
            this.txtA.TabIndex = 5;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(110, 57);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(51, 27);
            this.txtB.TabIndex = 6;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(185, 57);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(52, 27);
            this.txtC.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "ax²";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "bx";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "c";
            // 
            // txtX1
            // 
            this.txtX1.Enabled = false;
            this.txtX1.Location = new System.Drawing.Point(42, 109);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(67, 27);
            this.txtX1.TabIndex = 11;
            // 
            // txtX2
            // 
            this.txtX2.Enabled = false;
            this.txtX2.Location = new System.Drawing.Point(130, 109);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(71, 27);
            this.txtX2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "x\'";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "x\'\'";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(42, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 229);
            this.panel1.TabIndex = 15;
            // 
            // txtXv
            // 
            this.txtXv.Enabled = false;
            this.txtXv.Location = new System.Drawing.Point(40, 166);
            this.txtXv.Name = "txtXv";
            this.txtXv.Size = new System.Drawing.Size(67, 27);
            this.txtXv.TabIndex = 16;
            // 
            // txtYv
            // 
            this.txtYv.Enabled = false;
            this.txtYv.Location = new System.Drawing.Point(130, 166);
            this.txtYv.Name = "txtYv";
            this.txtYv.Size = new System.Drawing.Size(71, 27);
            this.txtYv.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Xv";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(130, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Yv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtYv);
            this.Controls.Add(this.txtXv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtX1;
        private TextBox txtX2;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private TextBox txtXv;
        private TextBox txtYv;
        private Label label8;
        private Label label9;
    }
}