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
    public partial class FormEjercicio2 : Form
    {
        FormPrincipal formPrincipal;
        public FormEjercicio2(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void FormEjercicio2_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrincipal.Show();
        }

        private void FormEjercicio2_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) ||  // Letras mayúsculas (A-Z)
                (e.KeyChar >= 97 && e.KeyChar <= 122) || // Letras minúsculas (a-z)
                (e.KeyChar == 8))  // Backspace (para borrar)
            {
                e.Handled = false; // Permite el ingreso
            }
            else
            {
                e.Handled = true; // Bloquea cualquier otra tecla
            }

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) ||  // Letras mayúsculas (A-Z)
                (e.KeyChar >= 97 && e.KeyChar <= 122) || // Letras minúsculas (a-z)
                (e.KeyChar == 8))  // Backspace (para borrar)
                 {
                    e.Handled = false; // Permite el ingreso
                 }
            else
            {
                e.Handled = true; // Bloquea cualquier otra tecla
            }

         }

        
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() != "" && txtApellido.Text.Trim() != "")
            {
                string nuevoItem = txtNombre.Text.ToLower() + " " + txtApellido.Text.ToLower();

                bool existe = false;

                foreach (string Item in lbNombresAgregados.Items)
                {
                    if (Item.ToLower() == nuevoItem)
                    {
                        existe = true;
                        break;
                    }


                }

                if (existe == false)
                {
                    lbNombresAgregados.Items.Add(nuevoItem);
                }
                else
                {
                    MessageBox.Show("El nombre y apellido ya estan en el ListBox", "Atención");
                    txtNombre.Clear();
                    txtApellido.Clear();
                }

                List<string> itemsOrdenados = new List<string>();

                foreach (string item in lbNombresAgregados.Items)
                {
                    itemsOrdenados.Add(item);
                }

                itemsOrdenados.Sort();
                lbNombresAgregados.Items.Clear();

                foreach (string item in itemsOrdenados)
                {
                    lbNombresAgregados.Items.Add(item.ToString());
                }

                txtNombre.Clear();
                txtApellido.Clear();
            }


            else if (txtNombre.Text == "" && txtApellido.Text != "")
            {
                MessageBox.Show("Debe ingresar un nombre", "Atención");
            }
            else if (txtNombre.Text != "" && txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar un apellido", "Atención");
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre y apellido", "Atención");
            }

            
        }


    }
}

