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
    public partial class FormEjercicio1 : Form
    {
        FormPrincipal formPrincipal;
        public FormEjercicio1(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void FormEjercicio1_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrincipal.Show();
        }

        private void FormEjercicio1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarUno_Click(object sender, EventArgs e)
        {
            if (lbNombresAgregados.SelectedItem != null)
            {
                string[] itemSelecionados = new string[lbNombresAgregados.SelectedItems.Count];

                for (int i = 0; i < lbNombresAgregados.SelectedItems.Count; i++)
                {
                    itemSelecionados[i] = lbNombresAgregados.SelectedItems[i].ToString();
                }

                foreach (string item in itemSelecionados)
                {
                    lbRecibeNombre.Items.Add(item);
                    lbNombresAgregados.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un item", "Atención");
            }

        }

        private void btnAgregarTodos_Click(object sender, EventArgs e)
        {
            if (lbNombresAgregados.Items.Count > 0)
            {
                foreach (string item in lbNombresAgregados.Items)
                {
                    lbRecibeNombre.Items.Add(item);
                }

                lbNombresAgregados.Items.Clear();
            }
            else
            {
                MessageBox.Show("Debe haber al menos un item en la listBox", "Atención");
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtIngreseNombre.Text.Trim() != "")
            {
                string nuevoItem = txtIngreseNombre.Text.ToLower();

                bool existe = false;

                foreach (string item in lbNombresAgregados.Items)
                {
                    if(item.ToLower() == nuevoItem)
                    {
                        existe = true;
                        break;
                    }
                }

                if(existe == false)
                {
                    lbNombresAgregados.Items.Add(nuevoItem);
                }
                else if (existe== true)
                {
                    MessageBox.Show("El nombre que ingreso ya esta en la ListBox", "Atención");
                }
            }


            else
            {
                MessageBox.Show("Debe ingresar un Nombre", "Atención");
            }
                txtIngreseNombre.Clear();
        }

        private void txtIngreseNombre_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
