﻿using GESTIONVENTAS.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTIONVENTAS.VISTAS.DetalleVentaVistas
{
    public partial class DetalleVentaListarVista : Form
    {
        public DetalleVentaListarVista()
        {
            InitializeComponent();
        }
        DetalleVentaBss bss = new DetalleVentaBss();
        private void DetalleVentaListarVista_Load(object sender, EventArgs e)
        {
            ///dataGridView1.DataSource = bss.ListaDetalleVentaBss();
        }
    }
}
