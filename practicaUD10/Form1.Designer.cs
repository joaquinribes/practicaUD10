
namespace practicaUD10
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
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tApellidos = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tTelefono = new System.Windows.Forms.TextBox();
            this.Lnombre = new System.Windows.Forms.Label();
            this.lApellidos = new System.Windows.Forms.Label();
            this.lTelefono = new System.Windows.Forms.Label();
            this.lListasocios = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(165, 92);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(100, 20);
            this.tNombre.TabIndex = 0;
            // 
            // tApellidos
            // 
            this.tApellidos.Location = new System.Drawing.Point(370, 92);
            this.tApellidos.Name = "tApellidos";
            this.tApellidos.Size = new System.Drawing.Size(100, 20);
            this.tApellidos.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(220, 208);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(456, 177);
            this.textBox3.TabIndex = 2;
            // 
            // tTelefono
            // 
            this.tTelefono.Location = new System.Drawing.Point(566, 92);
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.Size = new System.Drawing.Size(100, 20);
            this.tTelefono.TabIndex = 3;
            // 
            // Lnombre
            // 
            this.Lnombre.AutoSize = true;
            this.Lnombre.Location = new System.Drawing.Point(109, 99);
            this.Lnombre.Name = "Lnombre";
            this.Lnombre.Size = new System.Drawing.Size(50, 13);
            this.Lnombre.TabIndex = 4;
            this.Lnombre.Text = "Nombre: ";
            // 
            // lApellidos
            // 
            this.lApellidos.AutoSize = true;
            this.lApellidos.Location = new System.Drawing.Point(309, 99);
            this.lApellidos.Name = "lApellidos";
            this.lApellidos.Size = new System.Drawing.Size(55, 13);
            this.lApellidos.TabIndex = 5;
            this.lApellidos.Text = "Apellidos: ";
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Location = new System.Drawing.Point(505, 99);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(35, 13);
            this.lTelefono.TabIndex = 6;
            this.lTelefono.Text = "Móvil:";
            // 
            // lListasocios
            // 
            this.lListasocios.AutoSize = true;
            this.lListasocios.Location = new System.Drawing.Point(109, 208);
            this.lListasocios.Name = "lListasocios";
            this.lListasocios.Size = new System.Drawing.Size(68, 13);
            this.lListasocios.TabIndex = 7;
            this.lListasocios.Text = "Lista socios: ";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(601, 143);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 9;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.lListasocios);
            this.Controls.Add(this.lTelefono);
            this.Controls.Add(this.lApellidos);
            this.Controls.Add(this.Lnombre);
            this.Controls.Add(this.tTelefono);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tApellidos);
            this.Controls.Add(this.tNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tApellidos;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tTelefono;
        private System.Windows.Forms.Label Lnombre;
        private System.Windows.Forms.Label lApellidos;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.Label lListasocios;
        private System.Windows.Forms.Button Guardar;
    }
}

