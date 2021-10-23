﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordVision.ec.Domain.Contracts;

namespace WordVision.ec.Domain.Entities.Soporte
{
    public class Comunicacion : AuditableEntity
    {
        public int NumSolicitud { get; set; }

        public int TipoSolicitud { get; set; }

        public int AreaSolicitante { get; set; }

        public DateTime? FechaSolicitud { get; set; }
        public decimal Presupuesto { get; set; }
        public string DisponibilidadPresupuestaria { get; set; }
        public string AutorizacióndelLíderInmediato { get; set; }
        public string Informativo { get; set; }

        public int Responsable { get; set; }

        public int NumdeTicketTI { get; set; }

        public string NombredelEvento { get; set; }
        public DateTime? FechadelEvento { get; set; }
        public DateTime? HoradelEvento { get; set; }

        public string LugarEvento { get; set; }
        public string ObjetivodelEvento { get; set; }
        public string PúblicoObjetivo { get; set; }
        public int NúmerodeParticipantesEstimado { get; set; }
        public bool TransmisiónVirtual { get; set; }
        public string GuionMinuto_a_MinutoEvento { get; set; }
        public string LogosSociosInvolucrados { get; set; }
        public string PersonasAutoridadesAsistirán { get; set; }
        public string PersonalWVInvolucrado { get; set; }
        public string SituacionesInteresParaWorldVision { get; set; }

        public string SociosQuienesInteractuar { get; set; }
        public DateTime? FechaRequiereProducto { get; set; }
        public string DescripciónProducto { get; set; }
        public string ObjetivoProducto { get; set; }
        public string PublicoObjetivo { get; set; }
        public string MensajeClave { get; set; }
        public string DocumentoBasedeTrabajo { get; set; }

        public int IdSolicitud { get; set; }
        public virtual Solicitud Solicitudes { get; set; }
    }
}