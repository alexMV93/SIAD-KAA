using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIAD_KAA_Entities.Conexion;
using SIAD_KAA_BussinessLogic.ParametrosGenerales;
using SIAD_KAA_Entities.Entidades;

namespace SIAD_KAA_Controller.ParametrosGenerales
{
    public class ctrParametroGeneral
    {

        #region Variables
        blParametroGeneral _blParametroGeneral = new blParametroGeneral();
        #endregion

        public SP_LISTAR_PARAMETRO_GENERAL_POR_NOMBREResult fncListarMenu(string varPgeNombre)
        {
            SP_LISTAR_PARAMETRO_GENERAL_POR_NOMBREResult _parametroGeneral = new SP_LISTAR_PARAMETRO_GENERAL_POR_NOMBREResult();
            try
            {
                _parametroGeneral = _blParametroGeneral.logicListarParametroGeneralPorNombre(varPgeNombre);
            }
            catch { }
            return _parametroGeneral;
        }

    }
}
