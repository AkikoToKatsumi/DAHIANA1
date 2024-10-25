
namespace Dahiana
{
    partial class Mantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenimiento));
            this.Titulo = new System.Windows.Forms.Label();
            this.Nombre_texto = new System.Windows.Forms.Label();
            this.apellido_texto = new System.Windows.Forms.Label();
            this.telefono_texto = new System.Windows.Forms.Label();
            this.direccion_texto = new System.Windows.Forms.Label();
            this.correo_texto = new System.Windows.Forms.Label();
            this.sexo_texto = new System.Windows.Forms.Label();
            this.identidad_texto = new System.Windows.Forms.Label();
            this.documento = new System.Windows.Forms.TextBox();
            this.correo = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.sexo = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.Guadar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.imagenmujer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenmujer)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Thistle;
            this.Titulo.Font = new System.Drawing.Font("Script MT Bold", 35.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.Violet;
            this.Titulo.Location = new System.Drawing.Point(427, 19);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(269, 57);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "DAHIANA";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Nombre_texto
            // 
            this.Nombre_texto.AutoSize = true;
            this.Nombre_texto.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Nombre_texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nombre_texto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Nombre_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_texto.ForeColor = System.Drawing.Color.Azure;
            this.Nombre_texto.Location = new System.Drawing.Point(366, 135);
            this.Nombre_texto.Name = "Nombre_texto";
            this.Nombre_texto.Size = new System.Drawing.Size(88, 20);
            this.Nombre_texto.TabIndex = 2;
            this.Nombre_texto.Text = "NOMBRE:";
            this.Nombre_texto.Click += new System.EventHandler(this.label2_Click);
            // 
            // apellido_texto
            // 
            this.apellido_texto.AutoSize = true;
            this.apellido_texto.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.apellido_texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.apellido_texto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.apellido_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido_texto.ForeColor = System.Drawing.Color.Azure;
            this.apellido_texto.Location = new System.Drawing.Point(360, 174);
            this.apellido_texto.Name = "apellido_texto";
            this.apellido_texto.Size = new System.Drawing.Size(94, 20);
            this.apellido_texto.TabIndex = 3;
            this.apellido_texto.Text = "APELLIDO:";
            this.apellido_texto.Click += new System.EventHandler(this.apellido_texto_Click);
            // 
            // telefono_texto
            // 
            this.telefono_texto.AutoSize = true;
            this.telefono_texto.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.telefono_texto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.telefono_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono_texto.ForeColor = System.Drawing.Color.Azure;
            this.telefono_texto.Location = new System.Drawing.Point(352, 213);
            this.telefono_texto.Name = "telefono_texto";
            this.telefono_texto.Size = new System.Drawing.Size(102, 18);
            this.telefono_texto.TabIndex = 4;
            this.telefono_texto.Text = "TELEFONO:";
            this.telefono_texto.Click += new System.EventHandler(this.label4_Click);
            // 
            // direccion_texto
            // 
            this.direccion_texto.AutoSize = true;
            this.direccion_texto.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.direccion_texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.direccion_texto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.direccion_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion_texto.ForeColor = System.Drawing.Color.Azure;
            this.direccion_texto.Location = new System.Drawing.Point(347, 285);
            this.direccion_texto.Name = "direccion_texto";
            this.direccion_texto.Size = new System.Drawing.Size(107, 20);
            this.direccion_texto.TabIndex = 5;
            this.direccion_texto.Text = "DIRRECION:";
            // 
            // correo_texto
            // 
            this.correo_texto.AutoSize = true;
            this.correo_texto.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.correo_texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.correo_texto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.correo_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo_texto.ForeColor = System.Drawing.Color.Azure;
            this.correo_texto.Location = new System.Drawing.Point(366, 251);
            this.correo_texto.Name = "correo_texto";
            this.correo_texto.Size = new System.Drawing.Size(88, 20);
            this.correo_texto.TabIndex = 6;
            this.correo_texto.Text = "CORREO:";
            this.correo_texto.Click += new System.EventHandler(this.label6_Click);
            // 
            // sexo_texto
            // 
            this.sexo_texto.AutoSize = true;
            this.sexo_texto.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.sexo_texto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sexo_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexo_texto.ForeColor = System.Drawing.Color.Azure;
            this.sexo_texto.Location = new System.Drawing.Point(394, 320);
            this.sexo_texto.Name = "sexo_texto";
            this.sexo_texto.Size = new System.Drawing.Size(59, 18);
            this.sexo_texto.TabIndex = 7;
            this.sexo_texto.Text = "SEXO:";
            // 
            // identidad_texto
            // 
            this.identidad_texto.AutoSize = true;
            this.identidad_texto.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.identidad_texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.identidad_texto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.identidad_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identidad_texto.ForeColor = System.Drawing.Color.Azure;
            this.identidad_texto.Location = new System.Drawing.Point(313, 355);
            this.identidad_texto.Name = "identidad_texto";
            this.identidad_texto.Size = new System.Drawing.Size(244, 20);
            this.identidad_texto.TabIndex = 8;
            this.identidad_texto.Text = "DOCUMENTO DE IDENTIDAD:";
            this.identidad_texto.Click += new System.EventHandler(this.label8_Click);
            // 
            // documento
            // 
            this.documento.BackColor = System.Drawing.Color.Silver;
            this.documento.Location = new System.Drawing.Point(558, 355);
            this.documento.Multiline = true;
            this.documento.Name = "documento";
            this.documento.Size = new System.Drawing.Size(232, 20);
            this.documento.TabIndex = 9;
            // 
            // correo
            // 
            this.correo.BackColor = System.Drawing.Color.Silver;
            this.correo.Location = new System.Drawing.Point(455, 251);
            this.correo.Multiline = true;
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(332, 20);
            this.correo.TabIndex = 10;
            this.correo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // direccion
            // 
            this.direccion.BackColor = System.Drawing.Color.Silver;
            this.direccion.Location = new System.Drawing.Point(455, 285);
            this.direccion.Multiline = true;
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(332, 20);
            this.direccion.TabIndex = 11;
            // 
            // sexo
            // 
            this.sexo.BackColor = System.Drawing.Color.Silver;
            this.sexo.Location = new System.Drawing.Point(455, 319);
            this.sexo.Multiline = true;
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(332, 20);
            this.sexo.TabIndex = 12;
            // 
            // apellido
            // 
            this.apellido.BackColor = System.Drawing.Color.Silver;
            this.apellido.Location = new System.Drawing.Point(455, 174);
            this.apellido.Multiline = true;
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(332, 20);
            this.apellido.TabIndex = 13;
            // 
            // telefono
            // 
            this.telefono.BackColor = System.Drawing.Color.Silver;
            this.telefono.Location = new System.Drawing.Point(455, 212);
            this.telefono.Multiline = true;
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(332, 20);
            this.telefono.TabIndex = 14;
            this.telefono.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.Color.Silver;
            this.nombre.Location = new System.Drawing.Point(455, 135);
            this.nombre.Multiline = true;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(332, 20);
            this.nombre.TabIndex = 15;
            // 
            // Guadar
            // 
            this.Guadar.BackColor = System.Drawing.Color.Gray;
            this.Guadar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Guadar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guadar.ForeColor = System.Drawing.Color.White;
            this.Guadar.Location = new System.Drawing.Point(623, 415);
            this.Guadar.Name = "Guadar";
            this.Guadar.Size = new System.Drawing.Size(75, 23);
            this.Guadar.TabIndex = 16;
            this.Guadar.Text = "Guardar";
            this.Guadar.UseVisualStyleBackColor = false;
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.DarkRed;
            this.cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.ForeColor = System.Drawing.Color.White;
            this.cancelar.Location = new System.Drawing.Point(713, 415);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 17;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            // 
            // imagenmujer
            // 
            this.imagenmujer.BackColor = System.Drawing.Color.Violet;
            this.imagenmujer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagenmujer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagenmujer.Image = global::Dahiana.Properties.Resources.spa;
            this.imagenmujer.Location = new System.Drawing.Point(0, -1);
            this.imagenmujer.Name = "imagenmujer";
            this.imagenmujer.Size = new System.Drawing.Size(303, 454);
            this.imagenmujer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imagenmujer.TabIndex = 1;
            this.imagenmujer.TabStop = false;
            this.imagenmujer.Click += new System.EventHandler(this.imagenmujer_Click);
            // 
            // Mantenimiento
            // 
            this.AccessibleName = "Dahiana";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.Guadar);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.documento);
            this.Controls.Add(this.identidad_texto);
            this.Controls.Add(this.sexo_texto);
            this.Controls.Add(this.correo_texto);
            this.Controls.Add(this.direccion_texto);
            this.Controls.Add(this.telefono_texto);
            this.Controls.Add(this.apellido_texto);
            this.Controls.Add(this.Nombre_texto);
            this.Controls.Add(this.imagenmujer);
            this.Controls.Add(this.Titulo);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro_clientes_mantenimiento";
            this.Load += new System.EventHandler(this.Mantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenmujer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.PictureBox imagenmujer;
        private System.Windows.Forms.Label Nombre_texto;
        private System.Windows.Forms.Label apellido_texto;
        private System.Windows.Forms.Label telefono_texto;
        private System.Windows.Forms.Label direccion_texto;
        private System.Windows.Forms.Label correo_texto;
        private System.Windows.Forms.Label sexo_texto;
        private System.Windows.Forms.Label identidad_texto;
        private System.Windows.Forms.TextBox documento;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox sexo;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button Guadar;
        private System.Windows.Forms.Button cancelar;
    }
}

