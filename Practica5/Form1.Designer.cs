namespace Practica5
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ce = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.masmenos = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.mas = new System.Windows.Forms.Button();
            this.potencia = new System.Windows.Forms.Button();
            this.cuadrado = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.menos = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.dos = new System.Windows.Forms.Button();
            this.uno = new System.Windows.Forms.Button();
            this.nueve = new System.Windows.Forms.Button();
            this.ocho = new System.Windows.Forms.Button();
            this.siete = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.punto = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.cero = new System.Windows.Forms.Button();
            this.texto = new System.Windows.Forms.TextBox();
            this.por = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.cuatro = new System.Windows.Forms.Button();
            this.entre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ce
            // 
            this.ce.AutoSize = true;
            this.ce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(69)))));
            this.ce.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ce.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ce.Location = new System.Drawing.Point(1, 77);
            this.ce.Name = "ce";
            this.ce.Size = new System.Drawing.Size(86, 60);
            this.ce.TabIndex = 0;
            this.ce.Text = "CE";
            this.ce.UseVisualStyleBackColor = false;
            this.ce.Click += new System.EventHandler(this.ce_Click);
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(69)))));
            this.c.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.c.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.c.ForeColor = System.Drawing.Color.White;
            this.c.Location = new System.Drawing.Point(87, 77);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(86, 60);
            this.c.TabIndex = 1;
            this.c.Text = "C";
            this.c.UseVisualStyleBackColor = false;
            this.c.Click += new System.EventHandler(this.button2_Click);
            // 
            // masmenos
            // 
            this.masmenos.AutoSize = true;
            this.masmenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(69)))));
            this.masmenos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.masmenos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.masmenos.ForeColor = System.Drawing.Color.White;
            this.masmenos.Location = new System.Drawing.Point(173, 77);
            this.masmenos.Name = "masmenos";
            this.masmenos.Size = new System.Drawing.Size(86, 60);
            this.masmenos.TabIndex = 2;
            this.masmenos.Text = "±";
            this.masmenos.UseVisualStyleBackColor = false;
            this.masmenos.Click += new System.EventHandler(this.masmenos_Click);
            // 
            // borrar
            // 
            this.borrar.AutoSize = true;
            this.borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(69)))));
            this.borrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.borrar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.borrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.borrar.Location = new System.Drawing.Point(259, 77);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(86, 60);
            this.borrar.TabIndex = 3;
            this.borrar.Text = "◄";
            this.borrar.UseVisualStyleBackColor = false;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // mas
            // 
            this.mas.AutoSize = true;
            this.mas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(145)))));
            this.mas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mas.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mas.Location = new System.Drawing.Point(259, 138);
            this.mas.Name = "mas";
            this.mas.Size = new System.Drawing.Size(86, 60);
            this.mas.TabIndex = 7;
            this.mas.Text = "+";
            this.mas.UseVisualStyleBackColor = false;
            this.mas.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // potencia
            // 
            this.potencia.AutoSize = true;
            this.potencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(69)))));
            this.potencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.potencia.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.potencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.potencia.Location = new System.Drawing.Point(173, 138);
            this.potencia.Name = "potencia";
            this.potencia.Size = new System.Drawing.Size(86, 60);
            this.potencia.TabIndex = 6;
            this.potencia.Text = "y˟";
            this.potencia.UseVisualStyleBackColor = false;
            this.potencia.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // cuadrado
            // 
            this.cuadrado.AutoSize = true;
            this.cuadrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(69)))));
            this.cuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cuadrado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cuadrado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cuadrado.Location = new System.Drawing.Point(87, 138);
            this.cuadrado.Name = "cuadrado";
            this.cuadrado.Size = new System.Drawing.Size(86, 60);
            this.cuadrado.TabIndex = 5;
            this.cuadrado.Text = "x²";
            this.cuadrado.UseVisualStyleBackColor = false;
            this.cuadrado.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // raiz
            // 
            this.raiz.AutoSize = true;
            this.raiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(69)))));
            this.raiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.raiz.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.raiz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.raiz.Location = new System.Drawing.Point(1, 138);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(86, 60);
            this.raiz.TabIndex = 4;
            this.raiz.Text = "√";
            this.raiz.UseVisualStyleBackColor = false;
            this.raiz.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // menos
            // 
            this.menos.AutoSize = true;
            this.menos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(145)))));
            this.menos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menos.Location = new System.Drawing.Point(259, 199);
            this.menos.Name = "menos";
            this.menos.Size = new System.Drawing.Size(86, 60);
            this.menos.TabIndex = 11;
            this.menos.Text = "-";
            this.menos.UseVisualStyleBackColor = false;
            this.menos.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // tres
            // 
            this.tres.AutoSize = true;
            this.tres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.tres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tres.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tres.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tres.Location = new System.Drawing.Point(173, 199);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(86, 60);
            this.tres.TabIndex = 10;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = false;
            this.tres.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // dos
            // 
            this.dos.AutoSize = true;
            this.dos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.dos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dos.Location = new System.Drawing.Point(87, 199);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(86, 60);
            this.dos.TabIndex = 9;
            this.dos.Text = "2";
            this.dos.UseVisualStyleBackColor = false;
            this.dos.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // uno
            // 
            this.uno.AutoSize = true;
            this.uno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.uno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uno.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uno.Location = new System.Drawing.Point(1, 199);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(86, 60);
            this.uno.TabIndex = 8;
            this.uno.Text = "1";
            this.uno.UseVisualStyleBackColor = false;
            this.uno.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // nueve
            // 
            this.nueve.AutoSize = true;
            this.nueve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.nueve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nueve.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nueve.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nueve.Location = new System.Drawing.Point(173, 321);
            this.nueve.Name = "nueve";
            this.nueve.Size = new System.Drawing.Size(86, 60);
            this.nueve.TabIndex = 14;
            this.nueve.Text = "9";
            this.nueve.UseVisualStyleBackColor = false;
            this.nueve.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // ocho
            // 
            this.ocho.AutoSize = true;
            this.ocho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.ocho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ocho.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ocho.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ocho.Location = new System.Drawing.Point(87, 321);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(86, 60);
            this.ocho.TabIndex = 13;
            this.ocho.Text = "8";
            this.ocho.UseVisualStyleBackColor = false;
            this.ocho.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // siete
            // 
            this.siete.AutoSize = true;
            this.siete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.siete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.siete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.siete.Location = new System.Drawing.Point(1, 321);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(86, 60);
            this.siete.TabIndex = 12;
            this.siete.Text = "7";
            this.siete.UseVisualStyleBackColor = false;
            this.siete.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // igual
            // 
            this.igual.AutoSize = true;
            this.igual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(145)))));
            this.igual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.igual.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.igual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.igual.Location = new System.Drawing.Point(259, 382);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(86, 60);
            this.igual.TabIndex = 19;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            this.igual.Click += new System.EventHandler(this.Igualar);
            // 
            // punto
            // 
            this.punto.AutoSize = true;
            this.punto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.punto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.punto.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.punto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.punto.Location = new System.Drawing.Point(173, 382);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(86, 60);
            this.punto.TabIndex = 18;
            this.punto.Text = ".";
            this.punto.UseVisualStyleBackColor = false;
            this.punto.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button19.Location = new System.Drawing.Point(87, 387);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(0, 0);
            this.button19.TabIndex = 17;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // cero
            // 
            this.cero.AutoSize = true;
            this.cero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.cero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cero.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cero.Location = new System.Drawing.Point(1, 382);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(172, 60);
            this.cero.TabIndex = 16;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = false;
            this.cero.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // texto
            // 
            this.texto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.texto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texto.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.texto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.texto.Location = new System.Drawing.Point(1, 12);
            this.texto.Multiline = true;
            this.texto.Name = "texto";
            this.texto.ReadOnly = true;
            this.texto.Size = new System.Drawing.Size(344, 59);
            this.texto.TabIndex = 20;
            this.texto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // por
            // 
            this.por.AutoSize = true;
            this.por.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(145)))));
            this.por.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.por.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.por.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.por.Location = new System.Drawing.Point(259, 260);
            this.por.Name = "por";
            this.por.Size = new System.Drawing.Size(86, 60);
            this.por.TabIndex = 24;
            this.por.Text = "x";
            this.por.UseVisualStyleBackColor = false;
            this.por.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // seis
            // 
            this.seis.AutoSize = true;
            this.seis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.seis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seis.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.seis.Location = new System.Drawing.Point(173, 260);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(86, 60);
            this.seis.TabIndex = 23;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = false;
            this.seis.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // cinco
            // 
            this.cinco.AutoSize = true;
            this.cinco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.cinco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cinco.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cinco.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cinco.Location = new System.Drawing.Point(87, 260);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(86, 60);
            this.cinco.TabIndex = 22;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = false;
            this.cinco.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // cuatro
            // 
            this.cuatro.AutoSize = true;
            this.cuatro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.cuatro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cuatro.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cuatro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cuatro.Location = new System.Drawing.Point(1, 260);
            this.cuatro.Name = "cuatro";
            this.cuatro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cuatro.Size = new System.Drawing.Size(86, 60);
            this.cuatro.TabIndex = 21;
            this.cuatro.Text = "4";
            this.cuatro.UseVisualStyleBackColor = false;
            this.cuatro.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // entre
            // 
            this.entre.AutoSize = true;
            this.entre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(145)))));
            this.entre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.entre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.entre.Location = new System.Drawing.Point(259, 321);
            this.entre.Name = "entre";
            this.entre.Size = new System.Drawing.Size(86, 60);
            this.entre.TabIndex = 15;
            this.entre.Text = "/";
            this.entre.UseVisualStyleBackColor = false;
            this.entre.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(347, 445);
            this.Controls.Add(this.por);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.cuatro);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.punto);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.cero);
            this.Controls.Add(this.entre);
            this.Controls.Add(this.nueve);
            this.Controls.Add(this.ocho);
            this.Controls.Add(this.siete);
            this.Controls.Add(this.menos);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.dos);
            this.Controls.Add(this.uno);
            this.Controls.Add(this.mas);
            this.Controls.Add(this.potencia);
            this.Controls.Add(this.cuadrado);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.masmenos);
            this.Controls.Add(this.c);
            this.Controls.Add(this.ce);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Calculadora Estandar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ce;
        private Button c;
        private Button masmenos;
        private Button borrar;
        private Button mas;
        private Button potencia;
        private Button cuadrado;
        private Button raiz;
        private Button menos;
        private Button tres;
        private Button dos;
        private Button uno;
        private Button nueve;
        private Button ocho;
        private Button siete;
        private Button igual;
        private Button punto;
        private Button button19;
        private Button cero;
        private TextBox texto;
        private Button por;
        private Button seis;
        private Button cinco;
        private Button cuatro;
        private Button entre;
    }
}