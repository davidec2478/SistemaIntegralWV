﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordVision.ec.Web.Areas.Soporte.Models
{
    public class DonanteViewModel
    {
        public int Id { get; set; }
        public string IDHubspot { get; set; }

        public DateTime FechaConversion { get; set; }

        public int Canal { get; set; }
        public string Responsable { get; set; }
        public int Tipo { get; set; }
        public int Categoria { get; set; }
        public int Campana { get; set; }
        public int EstadoDonante { get; set; }

        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public int Genero { get; set; }
        public int Cedula { get; set; }
        public string RUC { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public int Region { get; set; }
        public int Provincia { get; set; }

        public int Ciudad { get; set; }
        public string Direccion { get; set; }
        public string TelefonoConvencional { get; set; }
        public string TelefonoCelular { get; set; }
        public bool WhatsApp { get; set; }
        public string Email { get; set; }
        public int FrecuenciaDonacion { get; set; }
        public int Cantidad { get; set; }
        public DateTime MesInicialDebito { get; set; }

        public int FormaPago { get; set; }
        public string NumReferencia { get; set; }
        public int TipoCuenta { get; set; }
        public string NumeroCuenta { get; set; }
        public int TiposTarjetasCredito { get; set; }
        public string NumeroTarjeta { get; set; }

        public DateTime FechaCaducidad { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int Banco { get; set; }

    }
}