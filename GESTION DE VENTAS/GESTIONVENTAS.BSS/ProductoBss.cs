using GESTIONVENTAS.DAL;
using GESTIONVENTAS.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTIONVENTAS.BSS
{
    public class ProductoBss
    {
        ProductoDal dal = new ProductoDal();
        public DataTable ListaProductoBss()
        {
            return dal.ListaProductoDal();
        }
        public PRODUCTO ObtenerProductoIdBss(int id)
        {
            return dal.ObtenerProductoId(id);
        }
        public DataTable ListaProductoTotalBss(int id)
        {
            return dal.ListaProductosTotalesDal(id);
        }
        public DataTable ListaProductoSeleccionadoBss(int id)
        {
            return dal.ListaProductoSeleccionadoDal(id);
        }
    }
}
