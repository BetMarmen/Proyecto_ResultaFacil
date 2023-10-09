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
    public partial class MenuOpciones : Form
    {
        public MenuOpciones()
        {
            InitializeComponent();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            RegistroInventario inventario= new RegistroInventario();
            this.Hide();
            inventario.ShowDialog();
            this.Close();
        }
    }
}
