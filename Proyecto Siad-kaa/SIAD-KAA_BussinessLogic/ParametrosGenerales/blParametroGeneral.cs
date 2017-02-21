using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIAD_KAA_Entities.Conexion;
using SIAD_KAA_Entities.Entidades;

namespace SIAD_KAA_BussinessLogic.ParametrosGenerales
{
    public class blParametroGeneral
    {

        #region Variables
        SIAD_KAABaseDatosDataContext varDataContext = new SIAD_KAABaseDatosDataContext();

        #endregion

        public SP_LISTAR_PARAMETRO_GENERAL_POR_NOMBREResult logicListarParametroGeneralPorNombre(string varPgeNombre)
        {
            SP_LISTAR_PARAMETRO_GENERAL_POR_NOMBREResult _parametroGeneral = new SP_LISTAR_PARAMETRO_GENERAL_POR_NOMBREResult();
            try
            {
                _parametroGeneral = varDataContext.SP_LISTAR_PARAMETRO_GENERAL_POR_NOMBRE(varPgeNombre).FirstOrDefault();
            }
            catch { }
            return _parametroGeneral;
        }
    }
}
