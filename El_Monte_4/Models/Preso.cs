﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace El_Monte_4.Models
{
    [Table ("Presos")]
    public class Preso
    {
    
        public int Id { get; set; }
        public string Rut { get; set; }

        public string  Nombre { get; set; }
        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Domicilio { get; set; }

        public bool Sexo { get; set; }

		

		//public Condena Condena { get; set; }


	}
}