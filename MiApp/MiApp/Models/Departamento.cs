﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MiApp.Models
{
    public class Departamento
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        public string NombreDepartamento  { get; set; }

        //public List<provincia> provincias { get; set;}

        
    }
}