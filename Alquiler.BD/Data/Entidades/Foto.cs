﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.BD.Data.Entidades
{
    public class Foto
    {

        public int Id { get; set; }


        public string Fotos { get; set; }



        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

    }
}
