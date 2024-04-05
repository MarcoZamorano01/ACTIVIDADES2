using GESTIONVENTAS.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTIONVENTAS.VISTAS.ProductoVistas
{
    public partial class ProductoListarVista : Form
    {
        public ProductoListarVista()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void ProductoListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaProductoBss();
        }

        private void button1_Click(object sender, EventArgs e)//seleccionar productos
        {
            VentaVistas.VentaInsertarVista.IdProductoSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);//p
        }
    }
}
