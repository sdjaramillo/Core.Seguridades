﻿using Core.Seguridades.DataAccess.Usuarios;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Usuarios
{
    public class ActualizarUsuarioBLL
    { 
        public static void ActualizarUsuario(UsuarioTrx objetoTransaccional)
        {
            ActualizarUsuarioDAL.Execute(objetoTransaccional);
        }
    }
}
