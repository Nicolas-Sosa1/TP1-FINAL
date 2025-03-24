using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_18
{
    public partial class FormEjercicio3 : Form
    {
        FormPrincipal formPrincipal;
        public FormEjercicio3(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void FormEjercicio3_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrincipal.Show();
        }

        private void FormEjercicio3_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string genero = rbMasculino.Checked ? "Masculino" : "Femenino";
            string estadoCivil = rbSoltero.Checked ? "Soltero" : "Casado";


            lblResultados.Text = "Usted seleccionó los siguientes elementos: \r\n" +
                "Sexo: " + genero +
                "\r\nEstado Civil: " + estadoCivil +
                "\r\nOficio: \r\n";

            foreach(string item in clbOficio.CheckedItems)
            {
                lblResultados.Text += item + "\r\n";
            }

        }
    }
}
