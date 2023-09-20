﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre de la bodega es requerida")]
        [MaxLength(60, ErrorMessage = "Nombre debe ser maximo 60 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Descripcion es requerida")]
        [MaxLength(100, ErrorMessage = "Descripcion debe ser maximo 100 caracteres")]
        public string Descripcion { get; set;}

        [Required(ErrorMessage = "agregalo perro")]
        public string Estado { get; set;}
    }
}
