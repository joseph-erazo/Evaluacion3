﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Usuario
    {

        public string Codigo { get; set; } 
        public string Nombre { get; set; } 
        public string ClaveDeIngreso { get; set; }
        public bool Estado { get; set; }

        public Usuario()
        {
        }

        public Usuario(string codigo, string nombre, string claveDeIngreso, bool estado)
        {
            Codigo = codigo;
            Nombre = nombre;
            ClaveDeIngreso = claveDeIngreso;
            Estado = estado;
        }
    }
}
