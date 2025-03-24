namespace TP1_GRUPO_18
{
    partial class FormEjercicio3
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
            this.clbOficio = new System.Windows.Forms.CheckedListBox();
            this.grbSexo = new System.Windows.Forms.GroupBox();
            this.grbEstadoCivil = new System.Windows.Forms.GroupBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblResultados = new System.Windows.Forms.Label();
            this.rbFemenibo = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbSoltero = new System.Windows.Forms.RadioButton();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.grbSexo.SuspendLayout();
            this.grbEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbOficio
            // 
            this.clbOficio.FormattingEnabled = true;
            this.clbOficio.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.clbOficio.Location = new System.Drawing.Point(165, 158);
            this.clbOficio.Name = "clbOficio";
            this.clbOficio.Size = new System.Drawing.Size(222, 109);
            this.clbOficio.TabIndex = 0;
            // 
            // grbSexo
            // 
            this.grbSexo.Controls.Add(this.rbMasculino);
            this.grbSexo.Controls.Add(this.rbFemenibo);
            this.grbSexo.Location = new System.Drawing.Point(44, 30);
            this.grbSexo.Name = "grbSexo";
            this.grbSexo.Size = new System.Drawing.Size(200, 100);
            this.grbSexo.TabIndex = 1;
            this.grbSexo.TabStop = false;
            this.grbSexo.Text = "Sexo";
            // 
            // grbEstadoCivil
            // 
            this.grbEstadoCivil.Controls.Add(this.rbSoltero);
            this.grbEstadoCivil.Controls.Add(this.rbCasado);
            this.grbEstadoCivil.Location = new System.Drawing.Point(315, 30);
            this.grbEstadoCivil.Name = "grbEstadoCivil";
            this.grbEstadoCivil.Size = new System.Drawing.Size(200, 100);
            this.grbEstadoCivil.TabIndex = 2;
            this.grbEstadoCivil.TabStop = false;
            this.grbEstadoCivil.Text = "Estado Civil";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(165, 297);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(222, 29);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar lo que se seleccionó";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.Location = new System.Drawing.Point(44, 352);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(0, 24);
            this.lblResultados.TabIndex = 4;
            // 
            // rbFemenibo
            // 
            this.rbFemenibo.AutoSize = true;
            this.rbFemenibo.Checked = true;
            this.rbFemenibo.Location = new System.Drawing.Point(7, 20);
            this.rbFemenibo.Name = "rbFemenibo";
            this.rbFemenibo.Size = new System.Drawing.Size(71, 17);
            this.rbFemenibo.TabIndex = 0;
            this.rbFemenibo.TabStop = true;
            this.rbFemenibo.Text = "Femenino";
            this.rbFemenibo.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(7, 43);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbSoltero
            // 
            this.rbSoltero.AutoSize = true;
            this.rbSoltero.Location = new System.Drawing.Point(6, 43);
            this.rbSoltero.Name = "rbSoltero";
            this.rbSoltero.Size = new System.Drawing.Size(58, 17);
            this.rbSoltero.TabIndex = 3;
            this.rbSoltero.Text = "Soltero";
            this.rbSoltero.UseVisualStyleBackColor = true;
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Checked = true;
            this.rbCasado.Location = new System.Drawing.Point(6, 20);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(61, 17);
            this.rbCasado.TabIndex = 2;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // FormEjercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 563);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.grbEstadoCivil);
            this.Controls.Add(this.grbSexo);
            this.Controls.Add(this.clbOficio);
            this.Name = "FormEjercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEjercicio3_FormClosed);
            this.Load += new System.EventHandler(this.FormEjercicio3_Load);
            this.grbSexo.ResumeLayout(false);
            this.grbSexo.PerformLayout();
            this.grbEstadoCivil.ResumeLayout(false);
            this.grbEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbOficio;
        private System.Windows.Forms.GroupBox grbSexo;
        private System.Windows.Forms.GroupBox grbEstadoCivil;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenibo;
        private System.Windows.Forms.RadioButton rbSoltero;
        private System.Windows.Forms.RadioButton rbCasado;
    }
}