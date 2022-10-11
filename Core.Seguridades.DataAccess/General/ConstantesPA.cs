using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.DataAccess.General
{
    public static class ConstantesPA
    {
        public const string CodigoRetorno = "@CodigoRetorno";

        /// <summary>
        /// Proceidmiento para autenticar una credencial acceso
        /// </summary>
        public static class PA_SEG_AUTENTICAR_CREDENCIALES_ACCESO
        {
            public const string PA_NOMBRE = "PA_SEG_VALIDAR_CREDENCIALES_ACCESO";
            public const string PARAM_USUARIO = "@Usuario";
            public const string PARAM_CLAVE = "@Clave";
        }

        /// <summary>
        /// Procedimiento para verificar si existe una credencial de acceso
        /// </summary>
        public static class PA_SEG_VALIDAAR_CREDENCIALES_ACCESO_EXISTE
        {
            public const string PA_NOMBRE = "PA_SEG_VALIDAR_CREDENCIALES_ACCESO_EXISTE";
            public const string PARAM_USUARIO = "@Usuario";
            public const string PARAM_CLAVE = "@Clave";
            public const string PARAM_TIPO = "@TipoCodigo";
            public const string PATAM_ENTIDAD = "@EntidadId";
        }

        /// <summary>
        /// Procedimiento para insertar una entidad credencial acceso
        /// </summary>
        public static class PA_SEG_INSERTAR_CREDENCIALES_ACCESO
        {
            public const string PA_NOMBRE = "PA_SEG_INSERTAR_CREDENCIALES_ACCESO";
            public const string PARAM_USUARIO = "@Usuario";
            public const string PARAM_CLAVE = "@Clave";
            public const string PARAM_TIPO = "@TipoCodigo";
            public const string PARAM_CODIGO_ENTIDAD = "@EntidadId";            
        }

        /// <summary>
        /// Procedimiento almacenado para actualizar entidad credencial acceso
        /// </summary>
        public static class PA_SEG_ACTUALIZAR_CREDENCIALES_ACCESO
        {
            public const string PA_NOMBRE = "PA_SEG_ACTUALIZAR_CREDENCIALES_ACCESO";
            public const string PARAM_CREDENCIAL_ID = "@CredencialId";
            public const string PARAM_USUARIO = "@Usuario";
            public const string PARAM_CLAVE = "@Clave";
            public const string PARAM_TIPO = "@TipoCodigo";
            public const string PATAM_ENTIDAD = "@EntidadId";
        }
    }
}
