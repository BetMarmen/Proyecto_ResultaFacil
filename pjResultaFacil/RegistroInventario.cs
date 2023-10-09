using ResultaFacil;
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
    public partial class RegistroInventario : Form
    {
        public RegistroInventario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnregistar_Click(object sender, EventArgs e)
        {
            string productoNuevo = txtProducto.Text;
            double precioNuevo = (double)nuPrecio.Value;
            int cantidadNuevo = (int)nuCantidad.Value;

            bool productoEncontrado = false;

            foreach (DataGridViewRow row in dataInventario.Rows)
            {
                string productoExistente = row.Cells[0].Value?.ToString();

                if (!string.IsNullOrEmpty(productoExistente) && productoExistente == productoNuevo)
                {
                    double? precioExistente = row.Cells[1].Value as double?;
                    int? cantidadExistente = row.Cells[2].Value as int?;

                    if (precioExistente != null && cantidadExistente != null)
                    {
                        // Calcular la media de los precios
                        double media = ((double)precioExistente  + precioNuevo ) / 2;

                        // Actualizar los valores existentes en la fila
                        row.Cells[1].Value = media;
                        row.Cells[2].Value = (int)cantidadExistente + cantidadNuevo;

                        productoEncontrado = true;
                        break;
                    }
                }
            }

            if (!productoEncontrado)
            {
                // Si el producto no existe, agregar una nueva fila
                dataInventario.Rows.Add(productoNuevo, precioNuevo, cantidadNuevo, 1);
            }

        }

        private void cboFormato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFormato.SelectedItem=="EXCEL") Formato.ExportToExcel(dataInventario);
            if (cboFormato.SelectedItem=="PDF") Formato.ExportToPDF(dataInventario);
            if (cboFormato.SelectedItem=="WORD") Formato.ExportToDocX(dataInventario);
            if (cboFormato.SelectedItem=="TXT") Formato.ExportToText(dataInventario);
        }
    }
}
