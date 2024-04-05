using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTIONVENTAS.DAL
{
    public class DetalleVentaDal
    {
        
        public DataTable ListaDetelleVentaDal(int id)//mostrar los detalles de una venta
        {
            string cosulta = "SELECT P.IDPRODUCTO, P.NOMBREPRODUCTO,DV.CANTIDAD,DV.PRECIOUNITARIO,DV.TOTALDETALLE\r\nFROM DETALLEVENTA DV\r\nINNER JOIN PRODUCTOS P ON P.IDPRODUCTO=DV.IDPRODUCTO\r\nWHERE IDVENTA =" + id;
            DataTable Lista = conexion.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        }
    }
}
