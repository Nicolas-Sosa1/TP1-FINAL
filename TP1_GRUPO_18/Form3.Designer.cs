namespace TP1_GRUPO_18
{
    partial class FormEjercicio2
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
            this.grbIngresoDatos = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grbElementos = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lbNombresAgregados = new System.Windows.Forms.ListBox();
            this.grbIngresoDatos.SuspendLayout();
            this.grbElementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbIngresoDatos
            // 
            this.grbIngresoDatos.Controls.Add(this.btnAgregar);
            this.grbIngresoDatos.Controls.Add(this.lblApellido);
            this.grbIngresoDatos.Controls.Add(this.lblNombre);
            this.grbIngresoDatos.Controls.Add(this.txtApellido);
            this.grbIngresoDatos.Controls.Add(this.txtNombre);
            this.grbIngresoDatos.Location = new System.Drawing.Point(12, 12);
            this.grbIngresoDatos.Name = "grbIngresoDatos";
            this.grbIngresoDatos.Size = new System.Drawing.Size(258, 399);
            this.grbIngresoDatos.TabIndex = 0;
            this.grbIngresoDatos.TabStop = false;
            this.grbIngresoDatos.Text = "Ingreso de Datos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(63, 237);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(147, 36);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(17, 192);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(72, 18);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(17, 154);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(96, 189);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(156, 20);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 155);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // grbElementos
            // 
            this.grbElementos.Controls.Add(this.btnBorrar);
            this.grbElementos.Controls.Add(this.lbNombresAgregados);
            this.grbElementos.Location = new System.Drawing.Point(278, 12);
            this.grbElementos.Name = "grbElementos";
            this.grbElementos.Size = new System.Drawing.Size(258, 399);
            this.grbElementos.TabIndex = 1;
            this.grbElementos.TabStop = false;
            this.grbElementos.Text = "Elementos";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(83, 355);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(95, 36);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lbNombresAgregados
            // 
            this.lbNombresAgregados.FormattingEnabled = true;
            this.lbNombresAgregados.Location = new System.Drawing.Point(17, 25);
            this.lbNombresAgregados.Name = "lbNombresAgregados";
            this.lbNombresAgregados.Size = new System.Drawing.Size(224, 316);
            this.lbNombresAgregados.TabIndex = 0;
            // 
            // FormEjercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 423);
            this.Controls.Add(this.grbElementos);
            this.Controls.Add(this.grbIngresoDatos);
            this.Name = "FormEjercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombre y apellido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEjercicio2_FormClosed);
            this.Load += new System.EventHandler(this.FormEjercicio2_Load);
            this.grbIngresoDatos.ResumeLayout(false);
            this.grbIngresoDatos.PerformLayout();
            this.grbElementos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbIngresoDatos;
        private System.Windows.Forms.GroupBox grbElementos;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ListBox lbNombresAgregados;
        private System.Windows.Forms.Button btnAgregar;
    }
}