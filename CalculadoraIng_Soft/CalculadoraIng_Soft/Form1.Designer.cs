namespace CalculadoraIng_Soft
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
            this.txtdisplayC = new System.Windows.Forms.TextBox();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnraiz = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btnpunto = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdisplayC
            // 
            this.txtdisplayC.Location = new System.Drawing.Point(23, 13);
            this.txtdisplayC.Name = "txtdisplayC";
            this.txtdisplayC.ReadOnly = true;
            this.txtdisplayC.Size = new System.Drawing.Size(220, 20);
            this.txtdisplayC.TabIndex = 0;
            this.txtdisplayC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtdisplayC.TextChanged += new System.EventHandler(this.txtdisplayC_TextChanged);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(12, 51);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(36, 32);
            this.btnborrar.TabIndex = 1;
            this.btnborrar.Text = "CE";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(54, 52);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(34, 31);
            this.btnDiv.TabIndex = 2;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnmul
            // 
            this.btnmul.Location = new System.Drawing.Point(94, 50);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(36, 31);
            this.btnmul.TabIndex = 3;
            this.btnmul.Text = "*";
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.btnmul_Click);
            // 
            // btnsuma
            // 
            this.btnsuma.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnsuma.Location = new System.Drawing.Point(136, 54);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(35, 31);
            this.btnsuma.TabIndex = 4;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 89);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(36, 33);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(54, 89);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(34, 33);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(96, 89);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(34, 33);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnresta
            // 
            this.btnresta.Location = new System.Drawing.Point(137, 89);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(34, 33);
            this.btnresta.TabIndex = 8;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(14, 128);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(34, 33);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(54, 128);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(34, 33);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(96, 128);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(34, 33);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnraiz
            // 
            this.btnraiz.Location = new System.Drawing.Point(136, 128);
            this.btnraiz.Name = "btnraiz";
            this.btnraiz.Size = new System.Drawing.Size(34, 33);
            this.btnraiz.TabIndex = 12;
            this.btnraiz.Text = "√";
            this.btnraiz.UseVisualStyleBackColor = true;
            this.btnraiz.Click += new System.EventHandler(this.btnraiz_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(14, 167);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(34, 33);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(54, 167);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(34, 33);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(96, 167);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(34, 33);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnigual
            // 
            this.btnigual.Location = new System.Drawing.Point(137, 167);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(34, 73);
            this.btnigual.TabIndex = 16;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btnpunto
            // 
            this.btnpunto.Location = new System.Drawing.Point(94, 206);
            this.btnpunto.Name = "btnpunto";
            this.btnpunto.Size = new System.Drawing.Size(34, 33);
            this.btnpunto.TabIndex = 17;
            this.btnpunto.Text = ".";
            this.btnpunto.UseVisualStyleBackColor = true;
            this.btnpunto.Click += new System.EventHandler(this.btnpunto_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(14, 207);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(74, 33);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 252);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnpunto);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnraiz);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.txtdisplayC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdisplayC;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnraiz;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btnpunto;
        private System.Windows.Forms.Button btn0;
    }
}

