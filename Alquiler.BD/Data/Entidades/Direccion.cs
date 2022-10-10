﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.BD.Data.Entidades
{
    public class Direccion
    {

        public int Id { get; set; }

        public string Localidad { get; set; }

        public string Departamento { get; set; }

        public string Provincia { get; set; }

        public List<Persona> Personas { get; set; }

    }
}
