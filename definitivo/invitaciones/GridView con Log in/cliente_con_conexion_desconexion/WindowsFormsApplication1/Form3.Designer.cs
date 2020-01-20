namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.LogIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreBox1 = new System.Windows.Forms.TextBox();
            this.contraBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Registrarse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.edadBox2 = new System.Windows.Forms.TextBox();
            this.contraBox2 = new System.Windows.Forms.TextBox();
            this.nombreBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ciudadBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LogIn
            // 
            this.LogIn.Location = new System.Drawing.Point(123, 190);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(75, 23);
            this.LogIn.TabIndex = 0;
            this.LogIn.Text = "Entrar";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicia Sesión";
            // 
            // nombreBox1
            // 
            this.nombreBox1.Location = new System.Drawing.Point(112, 75);
            this.nombreBox1.Name = "nombreBox1";
            this.nombreBox1.Size = new System.Drawing.Size(114, 20);
            this.nombreBox1.TabIndex = 2;
            this.nombreBox1.Text = "MarcG";
            this.nombreBox1.TextChanged += new System.EventHandler(this.nombreBox1_TextChanged);
            // 
            // contraBox1
            // 
            this.contraBox1.Location = new System.Drawing.Point(112, 135);
            this.contraBox1.Name = "contraBox1";
            this.contraBox1.Size = new System.Drawing.Size(114, 20);
            this.contraBox1.TabIndex = 3;
            this.contraBox1.Text = "123";
            this.contraBox1.TextChanged += new System.EventHandler(this.contraBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // Registrarse
            // 
            this.Registrarse.Location = new System.Drawing.Point(359, 278);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(75, 23);
            this.Registrarse.TabIndex = 7;
            this.Registrarse.Text = "Registrarse";
            this.Registrarse.UseVisualStyleBackColor = true;
            this.Registrarse.Click += new System.EventHandler(this.Registrarse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Edad";
            // 
            // edadBox2
            // 
            this.edadBox2.Location = new System.Drawing.Point(343, 189);
            this.edadBox2.Name = "edadBox2";
            this.edadBox2.Size = new System.Drawing.Size(114, 20);
            this.edadBox2.TabIndex = 9;
            this.edadBox2.TextChanged += new System.EventHandler(this.edadBox1_TextChanged);
            // 
            // contraBox2
            // 
            this.contraBox2.Location = new System.Drawing.Point(343, 131);
            this.contraBox2.Name = "contraBox2";
            this.contraBox2.Size = new System.Drawing.Size(114, 20);
            this.contraBox2.TabIndex = 10;
            this.contraBox2.TextChanged += new System.EventHandler(this.contraBox2_TextChanged_1);
            // 
            // nombreBox2
            // 
            this.nombreBox2.Location = new System.Drawing.Point(343, 75);
            this.nombreBox2.Name = "nombreBox2";
            this.nombreBox2.Size = new System.Drawing.Size(114, 20);
            this.nombreBox2.TabIndex = 11;
            this.nombreBox2.TextChanged += new System.EventHandler(this.nombreBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Contraseña";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ciudad";
            // 
            // ciudadBox2
            // 
            this.ciudadBox2.Location = new System.Drawing.Point(343, 240);
            this.ciudadBox2.Name = "ciudadBox2";
            this.ciudadBox2.Size = new System.Drawing.Size(114, 20);
            this.ciudadBox2.TabIndex = 15;
            this.ciudadBox2.TextChanged += new System.EventHandler(this.ciudadBox2_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(518, 370);
            this.Controls.Add(this.ciudadBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nombreBox2);
            this.Controls.Add(this.contraBox2);
            this.Controls.Add(this.edadBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Registrarse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contraBox1);
            this.Controls.Add(this.nombreBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogIn);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreBox1;
        private System.Windows.Forms.TextBox contraBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Registrarse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edadBox2;
        private System.Windows.Forms.TextBox contraBox2;
        private System.Windows.Forms.TextBox nombreBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ciudadBox2;
    }
}