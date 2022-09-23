﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Request.FuenteImagenes
{
    public class AgregarActualizarFuenteImagenRequest
    {
        public AgregarActualizarFuenteImagenRequest() { }
        public string Codigo { get; set; }
        public string EmpresaCodigo { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Valor { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public string Descripcion { get; set; }
    }
}
