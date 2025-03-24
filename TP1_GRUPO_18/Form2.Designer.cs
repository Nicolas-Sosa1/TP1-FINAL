namespace TP1_GRUPO_18
{
    partial class FormEjercicio1
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAgregarUno = new System.Windows.Forms.Button();
            this.btnAgregarTodos = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIngreseNombre = new System.Windows.Forms.TextBox();
            this.lbNombresAgregados = new System.Windows.Forms.ListBox();
            this.lbRecibeNombre = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(427, 46);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 26);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAgregarUno
            // 
            this.btnAgregarUno.Location = new System.Drawing.Point(236, 202);
            this.btnAgregarUno.Name = "btnAgregarUno";
            this.btnAgregarUno.Size = new System.Drawing.Size(67, 31);
            this.btnAgregarUno.TabIndex = 1;
            this.btnAgregarUno.Text = ">";
            this.btnAgregarUno.UseVisualStyleBackColor = true;
            this.btnAgregarUno.Click += new System.EventHandler(this.btnAgregarUno_Click);
            // 
            // btnAgregarTodos
            // 
            this.btnAgregarTodos.Location = new System.Drawing.Point(236, 258);
            this.btnAgregarTodos.Name = "btnAgregarTodos";
            this.btnAgregarTodos.Size = new System.Drawing.Size(67, 31);
            this.btnAgregarTodos.TabIndex = 2;
            this.btnAgregarTodos.Text = ">>";
            this.btnAgregarTodos.UseVisualStyleBackColor = true;
            this.btnAgregarTodos.Click += new System.EventHandler(this.btnAgregarTodos_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(24, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(139, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Ingrese un nombre:";
            // 
            // txtIngreseNombre
            // 
            this.txtIngreseNombre.Location = new System.Drawing.Point(166, 50);
            this.txtIngreseNombre.Name = "txtIngreseNombre";
            this.txtIngreseNombre.Size = new System.Drawing.Size(255, 20);
            this.txtIngreseNombre.TabIndex = 4;
            this.txtIngreseNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngreseNombre_KeyPress);
            // 
            // lbNombresAgregados
            // 
            this.lbNombresAgregados.FormattingEnabled = true;
            this.lbNombresAgregados.Location = new System.Drawing.Point(27, 136);
            this.lbNombresAgregados.Name = "lbNombresAgregados";
            this.lbNombresAgregados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbNombresAgregados.Size = new System.Drawing.Size(184, 238);
            this.lbNombresAgregados.TabIndex = 5;
            // 
            // lbRecibeNombre
            // 
            this.lbRecibeNombre.FormattingEnabled = true;
            this.lbRecibeNombre.Location = new System.Drawing.Point(329, 136);
            this.lbRecibeNombre.Name = "lbRecibeNombre";
            this.lbRecibeNombre.Size = new System.Drawing.Size(184, 238);
            this.lbRecibeNombre.TabIndex = 6;
            // 
            // FormEjercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 423);
            this.Controls.Add(this.lbRecibeNombre);
            this.Controls.Add(this.lbNombresAgregados);
            this.Controls.Add(this.txtIngreseNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAgregarTodos);
            this.Controls.Add(this.btnAgregarUno);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FormEjercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombres";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEjercicio1_FormClosed);
            this.Load += new System.EventHandler(this.FormEjercicio1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAgregarUno;
        private System.Windows.Forms.Button btnAgregarTodos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIngreseNombre;
        private System.Windows.Forms.ListBox lbNombresAgregados;
        private System.Windows.Forms.ListBox lbRecibeNombre;
    }
}