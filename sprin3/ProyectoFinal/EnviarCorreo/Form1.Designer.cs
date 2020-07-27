namespace EnviarCorreo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmisor = new System.Windows.Forms.TextBox();
            this.txtReceptor = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rtbMensaje = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bands & Artists", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TU CORREO*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bands & Artists", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTRASEÑA*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bands & Artists", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "DESTINADO PARA*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bands & Artists", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "ASUNTO*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bands & Artists", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "ADJUNTAR";
            // 
            // txtEmisor
            // 
            this.txtEmisor.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtEmisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmisor.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEmisor.Location = new System.Drawing.Point(469, 134);
            this.txtEmisor.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmisor.Name = "txtEmisor";
            this.txtEmisor.Size = new System.Drawing.Size(313, 22);
            this.txtEmisor.TabIndex = 5;
            this.txtEmisor.Text = "ejemplo@gmail.com";
            this.txtEmisor.TextChanged += new System.EventHandler(this.txtEmisor_TextChanged);
            // 
            // txtReceptor
            // 
            this.txtReceptor.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtReceptor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReceptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceptor.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtReceptor.Location = new System.Drawing.Point(469, 179);
            this.txtReceptor.Margin = new System.Windows.Forms.Padding(4);
            this.txtReceptor.Name = "txtReceptor";
            this.txtReceptor.Size = new System.Drawing.Size(313, 22);
            this.txtReceptor.TabIndex = 6;
            this.txtReceptor.Text = "ejemplo@gmail.com";
            // 
            // txtAsunto
            // 
            this.txtAsunto.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtAsunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsunto.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtAsunto.Location = new System.Drawing.Point(469, 218);
            this.txtAsunto.Margin = new System.Windows.Forms.Padding(4);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(313, 22);
            this.txtAsunto.TabIndex = 7;
            this.txtAsunto.Text = "Ejemplo: Necesito carpintero";
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtRutaArchivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRutaArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaArchivo.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtRutaArchivo.Location = new System.Drawing.Point(469, 259);
            this.txtRutaArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(313, 22);
            this.txtRutaArchivo.TabIndex = 8;
            this.txtRutaArchivo.Text = "CV, Certificados, etc";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(383, 230);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEnviar.FlatAppearance.BorderSize = 0;
            this.BtnEnviar.Font = new System.Drawing.Font("Futura Md BT", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviar.Location = new System.Drawing.Point(100, 430);
            this.BtnEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(241, 40);
            this.BtnEnviar.TabIndex = 10;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = false;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPassword.Location = new System.Drawing.Point(472, 307);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(309, 22);
            this.txtPassword.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rtbMensaje
            // 
            this.rtbMensaje.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtbMensaje.Location = new System.Drawing.Point(469, 354);
            this.rtbMensaje.Margin = new System.Windows.Forms.Padding(4);
            this.rtbMensaje.Name = "rtbMensaje";
            this.rtbMensaje.Size = new System.Drawing.Size(313, 90);
            this.rtbMensaje.TabIndex = 12;
            this.rtbMensaje.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Baron Neue Italic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Contactar usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BtnEnviar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(413, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 486);
            this.panel1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 314);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mensaje*";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(25, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 485);
            this.panel2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(910, 518);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rtbMensaje);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtReceptor);
            this.Controls.Add(this.txtEmisor);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Enviar Correo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmisor;
        private System.Windows.Forms.TextBox txtReceptor;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox rtbMensaje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
    }
}

