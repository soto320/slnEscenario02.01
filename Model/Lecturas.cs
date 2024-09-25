﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Lecturas
    {
        public string Descripcion { get; set; }
        public double Temperatura { get; set; }
        public double Centigrados { get => Descripcion == "F" ?(Temperatura - 32)*5/9: Temperatura; }
    }
}
