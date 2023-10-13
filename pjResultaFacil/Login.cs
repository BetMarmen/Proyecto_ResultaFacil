using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjResultaFacil
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnInicioSecion_Click(object sender, EventArgs e)
        {
            string usuario = "Administrador"; // Usuario predeterminado
            string contraseña = "ResultaFacil"; // Contraseña predeterminada

            if (txtUser.Text == usuario && txtPass.Text == contraseña)
            {
                MenuOpciones menu = new MenuOpciones();
                this.Hide();
                menu.ShowDialog();
                this.Close();
               
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos","LOGIN");
            }
            
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
                txtUser.Text = "";
            txtUser.ForeColor = Color.LightGray;
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
                txtPass.Text = "";
            txtPass.ForeColor = Color.LightGray;
            txtPass.UseSystemPasswordChar = true;
           
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
