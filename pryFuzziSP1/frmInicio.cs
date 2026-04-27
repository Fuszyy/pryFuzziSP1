using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFuzziSP1
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        //carga de variables

        string[] arrAdmin = { "Adm", "@1a" };
        string[] arrJohn = { "John", "*2b" };
        string[] arrCeci = { "Ceci", "*@3c" };
        string[] arrGod = { "God", "@#4d" };

        //

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPW.Text == "" || cbxMod.SelectedItem == null)
            {
                MessageBox.Show("Completar los datos", "Error al acceder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (txtName.Text == arrAdmin[0] && txtPW.Text == arrAdmin[1] && cbxMod.SelectedItem != "SIST" || txtName.Text == arrJohn[0] && txtPW.Text == arrJohn[1] && cbxMod.SelectedItem == "SIST" || txtName.Text == arrCeci[0] && txtPW.Text == arrCeci[1] && (cbxMod.SelectedItem == "ADM" || cbxMod.SelectedItem == "VTA") || txtName.Text == arrGod[0] && txtPW.Text == arrGod[1])
            {
                this.Hide();
                frmWelcome welcomeWindow = new frmWelcome();
                welcomeWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Acceso denegado.", "Error al acceder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtPW.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPW_TextChanged(object sender, EventArgs e)
        {
            cbxMod.Enabled = true;
        }
    }
}
