﻿using GESTIONVENTAS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTIONVENTAS.BSS
{
    public class DetalleVentaBss
    {
        DetalleVentaDal dal = new DetalleVentaDal();

        public DataTable ListaDetalleVentaBss(int id) 
        {
            return dal.ListaDetelleVentaDal(id);
        }
    }
}
