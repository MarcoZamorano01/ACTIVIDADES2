using GESTIONVENTAS.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTIONVENTAS.DAL
{
    public class ProductoDal
    {
        public DataTable ListaProductoDal()//todos los productos
        {
            string cosulta = "select * from productos";
            DataTable Lista = conexion.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        }
        public PRODUCTO ObtenerProductoId(int Id)//obtener id
        {
            string consulta = "select * from productos where idproducto=" + Id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            PRODUCTO p = new PRODUCTO();
            if (tabla.Rows.Count > 0)
            {
                p.IdProducto = Convert.ToInt32(tabla.Rows[0]["IdProducto"]);
                p.NombreProducto = tabla.Rows[0]["NombreProducto"].ToString();
                p.PrecioUnitario = Convert.ToDecimal(tabla.Rows[0]["PrecioUnitario"]);
                
            }
            return p;
        }
        public DataTable ListaProductoSeleccionadoDal(int id)//mostrar solo los productos seleccionados
        {
            string cosulta = "select * from productos where idproducto="+id;
            DataTable Lista = conexion.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        }
        public DataTable ListaProductosTotalesDal(int id)//mostrar total por los productos seleccionados
        {
            string cosulta = "SELECT SUM(PRECIOUNITARIO) AS TOTAL\r\nFROM PRODUCTOS\r\nWHERE IDPRODUCTO = "+ id;
            DataTable Lista = conexion.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        }
    }
}
