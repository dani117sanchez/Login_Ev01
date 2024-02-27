using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Login_Ev01.Models
{
        public class Usuario
        {
            public int IdUsuario { get; set; }
            [Required(ErrorMessage = "Ingrese Correo")]
            public string Correo { get; set; }
            [Required(ErrorMessage = "Ingrese Clave")]
            public string Clave { get; set; }
            public string ConfirmarClave { get; set; }

        }
    
}
