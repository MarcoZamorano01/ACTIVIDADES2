using GESTIONVENTAS.DAL;
using GESTIONVENTAS.MODELOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTIONVENTAS.BSS
{
    public class VentaBss
    {
        VentaDal dal = new VentaDal();

        public void InsertarClienteBss(VENTA venta)
        {
            dal.InsertarVentaDal(venta);
        }
    }
}
