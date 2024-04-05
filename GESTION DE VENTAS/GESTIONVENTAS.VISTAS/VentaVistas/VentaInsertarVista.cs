using GESTIONVENTAS.BSS;
using GESTIONVENTAS.MODELOS;
using GESTIONVENTAS.VISTAS.ProductoVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTIONVENTAS.VISTAS.VentaVistas
{
    public partial class VentaInsertarVista : Form
    {
        public VentaInsertarVista()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();
        ProductoBss bssPro = new ProductoBss();
        public static int IdProductoSelecionado = 0;
        private void VentaInsertarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bssPro.ListaProductoSeleccionadoBss(IdProductoSelecionado);
            dataGridView2.DataSource = bssPro.ListaProductoTotalBss(IdProductoSelecionado);
        }

        private void button1_Click(object sender, EventArgs e)//agregar productos
        {
            ProductoListarVista fr = new ProductoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                PRODUCTO producto = bssPro.ObtenerProductoIdBss(IdProductoSelecionado);
                dataGridView1.DataSource = producto.IdProducto.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)//guardar
        {

        }
    }
}
