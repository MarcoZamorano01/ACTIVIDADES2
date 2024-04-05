using GESTIONVENTAS.MODELOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTIONVENTAS.DAL
{
    public class VentaDal
    {
        
        public void InsertarVentaDal(VENTA venta)//insertar
        {
            string consulta = "insert into venta values('" + venta.FechaVenta + "'," + "'" + venta.TotalVenta + "')";
            conexion.Ejecutar(consulta);
        }
    }
}
