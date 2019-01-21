﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   
    public class Usuarios
    {
        [Key]

        public int UsuariosId { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Usuario { get; set; }
        public string TipodeAcceso { get; set; }
        public string Contraseña { get; set; }
        

        public Usuarios()
        {
            UsuariosId = 0;
            Nombre = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Usuario = string.Empty;
            TipodeAcceso = string.Empty;
            Contraseña = string.Empty;
        }
    }
}