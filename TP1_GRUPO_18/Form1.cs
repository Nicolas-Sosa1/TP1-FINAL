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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            lblIntegrantes.Text = "Integrantes:\r\n" + "                    Integrante 1\r\n" +
                "                    Integrante 2\r\n" + "                    Integrante 3\r\n" +
                "                    Integrante 4\r\n" + "                    Integrante 5\r\n" +
                "                    Integrante 6\r\n";


        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            FormEjercicio3 formEjercicio3 = new FormEjercicio3(this);
            formEjercicio3.Show();
            this.Hide();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {

            FormEjercicio2 formEjercicio2 = new FormEjercicio2(this);
            formEjercicio2.Show();
            this.Hide();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            FormEjercicio1 formEjercicio1 = new FormEjercicio1(this);
            formEjercicio1.Show();
            this.Hide();
        }
    }
}
