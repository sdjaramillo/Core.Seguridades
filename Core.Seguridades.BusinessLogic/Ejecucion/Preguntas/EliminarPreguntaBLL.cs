﻿using Core.Seguridades.DataAccess.Preguntas;
using Core.Seguridades.Model.Transaccion.Transaccional.Preguntas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Preguntas
{
    public static class EliminarPreguntaBLL
    {
        public static void EliminarPregunta(PreguntaTrx objetoTransacional)
        {
            EliminarPreguntaDAL.Execute(objetoTransacional);
        }
    }
}
