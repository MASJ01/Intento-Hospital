namespace Proyecto_Hospital
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Añadir = new System.Windows.Forms.Button();
            this.BTN_ELIMINAR = new System.Windows.Forms.Button();
            this.List_Nombres = new System.Windows.Forms.ListBox();
            this.List_Edad = new System.Windows.Forms.ListBox();
            this.List_Ocupacion = new System.Windows.Forms.ListBox();
            this.List_Tipo_Sangre = new System.Windows.Forms.ListBox();
            this.LBL_Nombre = new System.Windows.Forms.Label();
            this.LBL_Num_Afiliac = new System.Windows.Forms.Label();
            this.TXT_Num_Afilic = new System.Windows.Forms.TextBox();
            this.LBL_Edad = new System.Windows.Forms.Label();
            this.LBL_Ocupacion = new System.Windows.Forms.Label();
            this.LBL_Tipo_Sangre = new System.Windows.Forms.Label();
            this.LBL_Padecimiento = new System.Windows.Forms.Label();
            this.LBL_Alergias = new System.Windows.Forms.Label();
            this.LBL_Peso = new System.Windows.Forms.Label();
            this.LBL_Altura = new System.Windows.Forms.Label();
            this.LBL_Sustancia = new System.Windows.Forms.Label();
            this.TXT_Edad = new System.Windows.Forms.TextBox();
            this.TXT_Ocupacion = new System.Windows.Forms.TextBox();
            this.TXT_Tipo_Sangre = new System.Windows.Forms.TextBox();
            this.TXT_Padecimiento = new System.Windows.Forms.TextBox();
            this.TXT_Alergias = new System.Windows.Forms.TextBox();
            this.TXT_Peso = new System.Windows.Forms.TextBox();
            this.TXT_Altura = new System.Windows.Forms.TextBox();
            this.TXT_Sustancia_Consume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.List_Padecimiento = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Limipiar = new System.Windows.Forms.Button();
            this.TXT_Nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1072, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acerca de";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(224, 425);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 11;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(224, 175);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 10;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(224, 238);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 9;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Añadir
            // 
            this.Añadir.Location = new System.Drawing.Point(224, 115);
            this.Añadir.Name = "Añadir";
            this.Añadir.Size = new System.Drawing.Size(75, 23);
            this.Añadir.TabIndex = 8;
            this.Añadir.Text = "Añadir";
            this.Añadir.UseVisualStyleBackColor = true;
            this.Añadir.Click += new System.EventHandler(this.Añadir_Click);
            // 
            // BTN_ELIMINAR
            // 
            this.BTN_ELIMINAR.Location = new System.Drawing.Point(224, 300);
            this.BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            this.BTN_ELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_ELIMINAR.TabIndex = 12;
            this.BTN_ELIMINAR.Text = "Eliminar";
            this.BTN_ELIMINAR.UseVisualStyleBackColor = true;
            this.BTN_ELIMINAR.Click += new System.EventHandler(this.BTN_ELIMINAR_Click);
            // 
            // List_Nombres
            // 
            this.List_Nombres.FormattingEnabled = true;
            this.List_Nombres.Location = new System.Drawing.Point(406, 42);
            this.List_Nombres.Name = "List_Nombres";
            this.List_Nombres.Size = new System.Drawing.Size(158, 290);
            this.List_Nombres.TabIndex = 14;
            this.List_Nombres.SelectedIndexChanged += new System.EventHandler(this.List_Nombres_SelectedIndexChanged);
            // 
            // List_Edad
            // 
            this.List_Edad.FormattingEnabled = true;
            this.List_Edad.Location = new System.Drawing.Point(647, 42);
            this.List_Edad.Name = "List_Edad";
            this.List_Edad.Size = new System.Drawing.Size(151, 290);
            this.List_Edad.TabIndex = 15;
            // 
            // List_Ocupacion
            // 
            this.List_Ocupacion.FormattingEnabled = true;
            this.List_Ocupacion.Location = new System.Drawing.Point(406, 364);
            this.List_Ocupacion.Name = "List_Ocupacion";
            this.List_Ocupacion.Size = new System.Drawing.Size(161, 290);
            this.List_Ocupacion.TabIndex = 16;
            // 
            // List_Tipo_Sangre
            // 
            this.List_Tipo_Sangre.FormattingEnabled = true;
            this.List_Tipo_Sangre.Location = new System.Drawing.Point(647, 364);
            this.List_Tipo_Sangre.Name = "List_Tipo_Sangre";
            this.List_Tipo_Sangre.Size = new System.Drawing.Size(151, 290);
            this.List_Tipo_Sangre.TabIndex = 17;
            // 
            // LBL_Nombre
            // 
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Nombre.Location = new System.Drawing.Point(41, 96);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(65, 19);
            this.LBL_Nombre.TabIndex = 18;
            this.LBL_Nombre.Text = "Nombre";
            // 
            // LBL_Num_Afiliac
            // 
            this.LBL_Num_Afiliac.AutoSize = true;
            this.LBL_Num_Afiliac.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Num_Afiliac.Location = new System.Drawing.Point(8, 36);
            this.LBL_Num_Afiliac.Name = "LBL_Num_Afiliac";
            this.LBL_Num_Afiliac.Size = new System.Drawing.Size(152, 19);
            this.LBL_Num_Afiliac.TabIndex = 19;
            this.LBL_Num_Afiliac.Text = "Número de Afiliación";
            // 
            // TXT_Num_Afilic
            // 
            this.TXT_Num_Afilic.Location = new System.Drawing.Point(26, 58);
            this.TXT_Num_Afilic.Name = "TXT_Num_Afilic";
            this.TXT_Num_Afilic.Size = new System.Drawing.Size(106, 20);
            this.TXT_Num_Afilic.TabIndex = 21;
            // 
            // LBL_Edad
            // 
            this.LBL_Edad.AutoSize = true;
            this.LBL_Edad.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Edad.Location = new System.Drawing.Point(54, 156);
            this.LBL_Edad.Name = "LBL_Edad";
            this.LBL_Edad.Size = new System.Drawing.Size(42, 19);
            this.LBL_Edad.TabIndex = 22;
            this.LBL_Edad.Text = "Edad";
            // 
            // LBL_Ocupacion
            // 
            this.LBL_Ocupacion.AutoSize = true;
            this.LBL_Ocupacion.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Ocupacion.Location = new System.Drawing.Point(41, 219);
            this.LBL_Ocupacion.Name = "LBL_Ocupacion";
            this.LBL_Ocupacion.Size = new System.Drawing.Size(80, 19);
            this.LBL_Ocupacion.TabIndex = 23;
            this.LBL_Ocupacion.Text = "Ocupacion";
            // 
            // LBL_Tipo_Sangre
            // 
            this.LBL_Tipo_Sangre.AutoSize = true;
            this.LBL_Tipo_Sangre.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Tipo_Sangre.Location = new System.Drawing.Point(22, 281);
            this.LBL_Tipo_Sangre.Name = "LBL_Tipo_Sangre";
            this.LBL_Tipo_Sangre.Size = new System.Drawing.Size(111, 19);
            this.LBL_Tipo_Sangre.TabIndex = 24;
            this.LBL_Tipo_Sangre.Text = "Tipo de Sangre";
            // 
            // LBL_Padecimiento
            // 
            this.LBL_Padecimiento.AutoSize = true;
            this.LBL_Padecimiento.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Padecimiento.Location = new System.Drawing.Point(31, 339);
            this.LBL_Padecimiento.Name = "LBL_Padecimiento";
            this.LBL_Padecimiento.Size = new System.Drawing.Size(101, 19);
            this.LBL_Padecimiento.TabIndex = 25;
            this.LBL_Padecimiento.Text = "Padecimiento";
            // 
            // LBL_Alergias
            // 
            this.LBL_Alergias.AutoSize = true;
            this.LBL_Alergias.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Alergias.Location = new System.Drawing.Point(42, 394);
            this.LBL_Alergias.Name = "LBL_Alergias";
            this.LBL_Alergias.Size = new System.Drawing.Size(64, 19);
            this.LBL_Alergias.TabIndex = 26;
            this.LBL_Alergias.Text = "Alergias";
            // 
            // LBL_Peso
            // 
            this.LBL_Peso.AutoSize = true;
            this.LBL_Peso.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Peso.Location = new System.Drawing.Point(54, 452);
            this.LBL_Peso.Name = "LBL_Peso";
            this.LBL_Peso.Size = new System.Drawing.Size(41, 19);
            this.LBL_Peso.TabIndex = 27;
            this.LBL_Peso.Text = "Peso";
            // 
            // LBL_Altura
            // 
            this.LBL_Altura.AutoSize = true;
            this.LBL_Altura.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Altura.Location = new System.Drawing.Point(54, 509);
            this.LBL_Altura.Name = "LBL_Altura";
            this.LBL_Altura.Size = new System.Drawing.Size(50, 19);
            this.LBL_Altura.TabIndex = 28;
            this.LBL_Altura.Text = "Altura";
            // 
            // LBL_Sustancia
            // 
            this.LBL_Sustancia.AutoSize = true;
            this.LBL_Sustancia.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Sustancia.Location = new System.Drawing.Point(12, 565);
            this.LBL_Sustancia.Name = "LBL_Sustancia";
            this.LBL_Sustancia.Size = new System.Drawing.Size(136, 19);
            this.LBL_Sustancia.TabIndex = 29;
            this.LBL_Sustancia.Text = "Sustancia Consume";
            // 
            // TXT_Edad
            // 
            this.TXT_Edad.Location = new System.Drawing.Point(26, 178);
            this.TXT_Edad.Name = "TXT_Edad";
            this.TXT_Edad.Size = new System.Drawing.Size(106, 20);
            this.TXT_Edad.TabIndex = 30;
            // 
            // TXT_Ocupacion
            // 
            this.TXT_Ocupacion.Location = new System.Drawing.Point(26, 241);
            this.TXT_Ocupacion.Name = "TXT_Ocupacion";
            this.TXT_Ocupacion.Size = new System.Drawing.Size(106, 20);
            this.TXT_Ocupacion.TabIndex = 31;
            // 
            // TXT_Tipo_Sangre
            // 
            this.TXT_Tipo_Sangre.Location = new System.Drawing.Point(26, 303);
            this.TXT_Tipo_Sangre.Name = "TXT_Tipo_Sangre";
            this.TXT_Tipo_Sangre.Size = new System.Drawing.Size(106, 20);
            this.TXT_Tipo_Sangre.TabIndex = 32;
            // 
            // TXT_Padecimiento
            // 
            this.TXT_Padecimiento.Location = new System.Drawing.Point(26, 361);
            this.TXT_Padecimiento.Name = "TXT_Padecimiento";
            this.TXT_Padecimiento.Size = new System.Drawing.Size(106, 20);
            this.TXT_Padecimiento.TabIndex = 33;
            // 
            // TXT_Alergias
            // 
            this.TXT_Alergias.Location = new System.Drawing.Point(26, 416);
            this.TXT_Alergias.Name = "TXT_Alergias";
            this.TXT_Alergias.Size = new System.Drawing.Size(106, 20);
            this.TXT_Alergias.TabIndex = 34;
            // 
            // TXT_Peso
            // 
            this.TXT_Peso.Location = new System.Drawing.Point(26, 474);
            this.TXT_Peso.Name = "TXT_Peso";
            this.TXT_Peso.Size = new System.Drawing.Size(106, 20);
            this.TXT_Peso.TabIndex = 35;
            // 
            // TXT_Altura
            // 
            this.TXT_Altura.Location = new System.Drawing.Point(26, 531);
            this.TXT_Altura.Name = "TXT_Altura";
            this.TXT_Altura.Size = new System.Drawing.Size(106, 20);
            this.TXT_Altura.TabIndex = 36;
            // 
            // TXT_Sustancia_Consume
            // 
            this.TXT_Sustancia_Consume.Location = new System.Drawing.Point(26, 587);
            this.TXT_Sustancia_Consume.Name = "TXT_Sustancia_Consume";
            this.TXT_Sustancia_Consume.Size = new System.Drawing.Size(106, 20);
            this.TXT_Sustancia_Consume.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Lista Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(676, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Lista Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Lista Ocupacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(645, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Lista Tipo de Sangre";
            // 
            // List_Padecimiento
            // 
            this.List_Padecimiento.FormattingEnabled = true;
            this.List_Padecimiento.Location = new System.Drawing.Point(897, 238);
            this.List_Padecimiento.Name = "List_Padecimiento";
            this.List_Padecimiento.Size = new System.Drawing.Size(152, 290);
            this.List_Padecimiento.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(894, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Lista Padecimiento";
            // 
            // BTN_Limipiar
            // 
            this.BTN_Limipiar.Location = new System.Drawing.Point(224, 361);
            this.BTN_Limipiar.Name = "BTN_Limipiar";
            this.BTN_Limipiar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Limipiar.TabIndex = 46;
            this.BTN_Limipiar.Text = "Limpiar";
            this.BTN_Limipiar.UseVisualStyleBackColor = true;
            this.BTN_Limipiar.Click += new System.EventHandler(this.BTN_Limipiar_Click);
            // 
            // TXT_Nombre
            // 
            this.TXT_Nombre.Location = new System.Drawing.Point(26, 118);
            this.TXT_Nombre.Name = "TXT_Nombre";
            this.TXT_Nombre.Size = new System.Drawing.Size(106, 20);
            this.TXT_Nombre.TabIndex = 47;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1163, 668);
            this.Controls.Add(this.TXT_Nombre);
            this.Controls.Add(this.BTN_Limipiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.List_Padecimiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT_Sustancia_Consume);
            this.Controls.Add(this.TXT_Altura);
            this.Controls.Add(this.TXT_Peso);
            this.Controls.Add(this.TXT_Alergias);
            this.Controls.Add(this.TXT_Padecimiento);
            this.Controls.Add(this.TXT_Tipo_Sangre);
            this.Controls.Add(this.TXT_Ocupacion);
            this.Controls.Add(this.TXT_Edad);
            this.Controls.Add(this.LBL_Sustancia);
            this.Controls.Add(this.LBL_Altura);
            this.Controls.Add(this.LBL_Peso);
            this.Controls.Add(this.LBL_Alergias);
            this.Controls.Add(this.LBL_Padecimiento);
            this.Controls.Add(this.LBL_Tipo_Sangre);
            this.Controls.Add(this.LBL_Ocupacion);
            this.Controls.Add(this.LBL_Edad);
            this.Controls.Add(this.TXT_Num_Afilic);
            this.Controls.Add(this.LBL_Num_Afiliac);
            this.Controls.Add(this.LBL_Nombre);
            this.Controls.Add(this.List_Tipo_Sangre);
            this.Controls.Add(this.List_Ocupacion);
            this.Controls.Add(this.List_Edad);
            this.Controls.Add(this.List_Nombres);
            this.Controls.Add(this.BTN_ELIMINAR);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Añadir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROYECTO HOSPITAL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Añadir;
        private System.Windows.Forms.Button BTN_ELIMINAR;
        private System.Windows.Forms.ListBox List_Nombres;
        private System.Windows.Forms.ListBox List_Edad;
        private System.Windows.Forms.ListBox List_Ocupacion;
        private System.Windows.Forms.ListBox List_Tipo_Sangre;
        private System.Windows.Forms.Label LBL_Nombre;
        private System.Windows.Forms.Label LBL_Num_Afiliac;
        private System.Windows.Forms.TextBox TXT_Num_Afilic;
        private System.Windows.Forms.Label LBL_Edad;
        private System.Windows.Forms.Label LBL_Ocupacion;
        private System.Windows.Forms.Label LBL_Tipo_Sangre;
        private System.Windows.Forms.Label LBL_Padecimiento;
        private System.Windows.Forms.Label LBL_Alergias;
        private System.Windows.Forms.Label LBL_Peso;
        private System.Windows.Forms.Label LBL_Altura;
        private System.Windows.Forms.Label LBL_Sustancia;
        private System.Windows.Forms.TextBox TXT_Edad;
        private System.Windows.Forms.TextBox TXT_Ocupacion;
        private System.Windows.Forms.TextBox TXT_Tipo_Sangre;
        private System.Windows.Forms.TextBox TXT_Padecimiento;
        private System.Windows.Forms.TextBox TXT_Alergias;
        private System.Windows.Forms.TextBox TXT_Peso;
        private System.Windows.Forms.TextBox TXT_Altura;
        private System.Windows.Forms.TextBox TXT_Sustancia_Consume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox List_Padecimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Limipiar;
        private System.Windows.Forms.TextBox TXT_Nombre;
    }
}

