﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WordVision.ec.Web.Areas.Registro.Models
{
    public class ColaboradorViewModel
    {
        public int Id { get; set; }

        public string Apellidos { get; set; }

        public string ApellidoMaterno { get; set; }

        public string PrimerNombre { get; set; }

        public string SegundoNombre { get; set; }

        public string Identificacion { get; set; }

        public string Email { get; set; }
        public string Cargo { get; set; }

        public string Area { get; set; }
       
        public string LugarTrabajo { get; set; }

        public string ActPoliticas { get; set; }
        public string ActDocumentos { get; set; }
        public string ActDatos { get; set; }
    }
}
