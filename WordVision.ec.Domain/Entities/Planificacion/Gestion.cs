﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordVision.ec.Domain.Contracts;

namespace WordVision.ec.Domain.Entities.Planificacion
{
    public class Gestion : AuditableEntity
    {
        [StringLength(15)]
        [Display(Name = "Descripcion AF")]
        public string Descripcion { get; set; }
        [Display(Name = "Año Fiscal")]
        public int Anio { get; set; }

        [StringLength(1)]
        [Display(Name = "Estado de AF")]
        public string Estado { get; set; }
        public int IdEstrategia { get; set; }
        public EstrategiaNacional EstrategiaNacionales { get; set; }

        [ForeignKey("IdGestion")]
        public ICollection<Producto> Productos { get; set; }
    }
}
