﻿namespace WordVision.ec.Application.Features.Registro.Colaboradores.Queries.GetAllCached
{
    public class GetAllColaboradoresCachedResponse
    {
        public int Id { get; set; }
        public string Apellidos { get; set; }
        public string ApellidoMaterno { get; set; }
        public string PrimerNombre { get; set; }

        public string SegundoNombre { get; set; }

        public string Identificacion { get; set; }
        public string Cargo { get; set; }

        public string Area { get; set; }

        public string LugarTrabajo { get; set; }

        public string ActPoliticas { get; set; }
        public string ActDocumentos { get; set; }
        public string ActDatos { get; set; }
    }
}