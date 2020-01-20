namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PartidaLarga = new System.Windows.Forms.RadioButton();
            this.Contraseña = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.conectados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.TextBox();
            this.puerto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LogIn = new System.Windows.Forms.Button();
            this.NombreBox1 = new System.Windows.Forms.TextBox();
            this.PassBox1 = new System.Windows.Forms.TextBox();
            this.NombreBox2 = new System.Windows.Forms.TextBox();
            this.PassBox2 = new System.Windows.Forms.TextBox();
            this.CiudadBox2 = new System.Windows.Forms.TextBox();
            this.registrarse = new System.Windows.Forms.Button();
            this.EdadBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.BuscaBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.chatlabel = new System.Windows.Forms.Label();
            this.mensaje1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnInvitación = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.mensaje2 = new System.Windows.Forms.Label();
            this.chatBox2 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnRechazar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(50, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(17, 13);
            label1.TabIndex = 18;
            label1.Text = "IP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(707, 107);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(53, 13);
            label4.TabIndex = 28;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(716, 183);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(44, 13);
            label5.TabIndex = 29;
            label5.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(707, 221);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(53, 13);
            label6.TabIndex = 30;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(720, 261);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(32, 13);
            label7.TabIndex = 31;
            label7.Text = "Edad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(720, 303);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(40, 13);
            label8.TabIndex = 32;
            label8.Text = "Ciudad";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(716, 72);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(44, 13);
            label9.TabIndex = 33;
            label9.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(116, 31);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(164, 20);
            this.nombre.TabIndex = 3;
            this.nombre.Text = "Marc";
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(53, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.PartidaLarga);
            this.groupBox1.Controls.Add(this.Contraseña);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(25, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 202);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // PartidaLarga
            // 
            this.PartidaLarga.AutoSize = true;
            this.PartidaLarga.Location = new System.Drawing.Point(116, 112);
            this.PartidaLarga.Name = "PartidaLarga";
            this.PartidaLarga.Size = new System.Drawing.Size(151, 17);
            this.PartidaLarga.TabIndex = 7;
            this.PartidaLarga.TabStop = true;
            this.PartidaLarga.Text = "Duración partida más larga";
            this.PartidaLarga.UseVisualStyleBackColor = true;
            this.PartidaLarga.CheckedChanged += new System.EventHandler(this.PartidaLarga_CheckedChanged);
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Location = new System.Drawing.Point(116, 68);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(109, 17);
            this.Contraseña.TabIndex = 8;
            this.Contraseña.TabStop = true;
            this.Contraseña.Text = "Dame contraseña";
            this.Contraseña.UseVisualStyleBackColor = true;
            this.Contraseña.CheckedChanged += new System.EventHandler(this.Bonito_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(53, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 32);
            this.button3.TabIndex = 10;
            this.button3.Text = "Desconectar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(761, 358);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(119, 45);
            this.btnAbrir.TabIndex = 13;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.button5_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.conectados});
            this.dataGridView1.Location = new System.Drawing.Point(382, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(143, 160);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // conectados
            // 
            this.conectados.HeaderText = "Column1";
            this.conectados.Name = "conectados";
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(113, 40);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(113, 20);
            this.IP.TabIndex = 16;
            this.IP.Text = "147.83.117.22";
            // 
            // puerto
            // 
            this.puerto.Location = new System.Drawing.Point(113, 66);
            this.puerto.Name = "puerto";
            this.puerto.Size = new System.Drawing.Size(113, 20);
            this.puerto.TabIndex = 17;
            this.puerto.Text = "50001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Puerto";
            // 
            // LogIn
            // 
            this.LogIn.Location = new System.Drawing.Point(780, 21);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(75, 23);
            this.LogIn.TabIndex = 20;
            this.LogIn.Text = "Log In";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click_1);
            // 
            // NombreBox1
            // 
            this.NombreBox1.Location = new System.Drawing.Point(780, 69);
            this.NombreBox1.Name = "NombreBox1";
            this.NombreBox1.Size = new System.Drawing.Size(100, 20);
            this.NombreBox1.TabIndex = 21;
            this.NombreBox1.Text = "MarcG";
            // 
            // PassBox1
            // 
            this.PassBox1.Location = new System.Drawing.Point(780, 104);
            this.PassBox1.Name = "PassBox1";
            this.PassBox1.Size = new System.Drawing.Size(100, 20);
            this.PassBox1.TabIndex = 22;
            this.PassBox1.Text = "123";
            // 
            // NombreBox2
            // 
            this.NombreBox2.Location = new System.Drawing.Point(780, 180);
            this.NombreBox2.Name = "NombreBox2";
            this.NombreBox2.Size = new System.Drawing.Size(100, 20);
            this.NombreBox2.TabIndex = 23;
            // 
            // PassBox2
            // 
            this.PassBox2.Location = new System.Drawing.Point(780, 218);
            this.PassBox2.Name = "PassBox2";
            this.PassBox2.Size = new System.Drawing.Size(100, 20);
            this.PassBox2.TabIndex = 24;
            // 
            // CiudadBox2
            // 
            this.CiudadBox2.Location = new System.Drawing.Point(780, 300);
            this.CiudadBox2.Name = "CiudadBox2";
            this.CiudadBox2.Size = new System.Drawing.Size(100, 20);
            this.CiudadBox2.TabIndex = 25;
            // 
            // registrarse
            // 
            this.registrarse.Location = new System.Drawing.Point(795, 140);
            this.registrarse.Name = "registrarse";
            this.registrarse.Size = new System.Drawing.Size(75, 23);
            this.registrarse.TabIndex = 26;
            this.registrarse.Text = "Registrarse";
            this.registrarse.UseVisualStyleBackColor = true;
            this.registrarse.Click += new System.EventHandler(this.registrarse_Click);
            // 
            // EdadBox2
            // 
            this.EdadBox2.Location = new System.Drawing.Point(780, 258);
            this.EdadBox2.Name = "EdadBox2";
            this.EdadBox2.Size = new System.Drawing.Size(100, 20);
            this.EdadBox2.TabIndex = 27;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(252, 72);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 28);
            this.button5.TabIndex = 34;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // BuscaBox1
            // 
            this.BuscaBox1.Location = new System.Drawing.Point(252, 40);
            this.BuscaBox1.Name = "BuscaBox1";
            this.BuscaBox1.Size = new System.Drawing.Size(110, 20);
            this.BuscaBox1.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Control";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(545, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(140, 160);
            this.listBox1.TabIndex = 37;
            // 
            // chatBox
            // 
            this.chatBox.Location = new System.Drawing.Point(545, 214);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(140, 20);
            this.chatBox.TabIndex = 38;
            this.chatBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chatlabel
            // 
            this.chatlabel.AutoSize = true;
            this.chatlabel.Location = new System.Drawing.Point(579, 12);
            this.chatlabel.Name = "chatlabel";
            this.chatlabel.Size = new System.Drawing.Size(60, 13);
            this.chatlabel.TabIndex = 39;
            this.chatlabel.Text = "Chat global";
            // 
            // mensaje1
            // 
            this.mensaje1.AutoSize = true;
            this.mensaje1.Location = new System.Drawing.Point(592, 193);
            this.mensaje1.Name = "mensaje1";
            this.mensaje1.Size = new System.Drawing.Size(47, 13);
            this.mensaje1.TabIndex = 40;
            this.mensaje1.Text = "Mensaje";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(582, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 41;
            this.button4.Text = "Enviar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnInvitación
            // 
            this.btnInvitación.Location = new System.Drawing.Point(252, 107);
            this.btnInvitación.Name = "btnInvitación";
            this.btnInvitación.Size = new System.Drawing.Size(110, 23);
            this.btnInvitación.TabIndex = 42;
            this.btnInvitación.Text = "Invitar";
            this.btnInvitación.UseVisualStyleBackColor = true;
            this.btnInvitación.Click += new System.EventHandler(this.btnInvitación_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(424, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Chat privado";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(382, 214);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(143, 147);
            this.listBox2.TabIndex = 44;
            // 
            // mensaje2
            // 
            this.mensaje2.AutoSize = true;
            this.mensaje2.Location = new System.Drawing.Point(424, 364);
            this.mensaje2.Name = "mensaje2";
            this.mensaje2.Size = new System.Drawing.Size(47, 13);
            this.mensaje2.TabIndex = 45;
            this.mensaje2.Text = "Mensaje";
            // 
            // chatBox2
            // 
            this.chatBox2.Location = new System.Drawing.Point(385, 383);
            this.chatBox2.Name = "chatBox2";
            this.chatBox2.Size = new System.Drawing.Size(140, 20);
            this.chatBox2.TabIndex = 46;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(416, 409);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 47;
            this.button7.Text = "Enviar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(582, 325);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 48;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnRechazar
            // 
            this.btnRechazar.Location = new System.Drawing.Point(582, 369);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(75, 23);
            this.btnRechazar.TabIndex = 49;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.UseVisualStyleBackColor = true;
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(911, 472);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.chatBox2);
            this.Controls.Add(this.mensaje2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnInvitación);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.mensaje1);
            this.Controls.Add(this.chatlabel);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BuscaBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(label9);
            this.Controls.Add(label8);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(this.EdadBox2);
            this.Controls.Add(this.registrarse);
            this.Controls.Add(this.CiudadBox2);
            this.Controls.Add(this.PassBox2);
            this.Controls.Add(this.NombreBox2);
            this.Controls.Add(this.PassBox1);
            this.Controls.Add(this.NombreBox1);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(label1);
            this.Controls.Add(this.puerto);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Tag = "NombreBox1.Text";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PartidaLarga;
        private System.Windows.Forms.RadioButton Contraseña;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn conectados;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox puerto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.TextBox NombreBox1;
        private System.Windows.Forms.TextBox PassBox1;
        private System.Windows.Forms.TextBox NombreBox2;
        private System.Windows.Forms.TextBox PassBox2;
        private System.Windows.Forms.TextBox CiudadBox2;
        private System.Windows.Forms.Button registrarse;
        private System.Windows.Forms.TextBox EdadBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox BuscaBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox chatBox;
        private System.Windows.Forms.Label chatlabel;
        private System.Windows.Forms.Label mensaje1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnInvitación;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label mensaje2;
        private System.Windows.Forms.TextBox chatBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnRechazar;
    }
}

