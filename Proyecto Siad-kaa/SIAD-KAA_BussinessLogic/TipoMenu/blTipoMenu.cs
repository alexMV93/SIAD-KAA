using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIAD_KAA_Entities.Conexion;

namespace SIAD_KAA_BussinessLogic.TipoMenu
{
    public class blTipoMenu
    {
        #region Variables

        SIAD_KAABaseDatosDataContext varDataContext = new SIAD_KAABaseDatosDataContext();
        List<SP_LISTAR_TIPOS_MENUResult> _listaTiposMenu = new List<SP_LISTAR_TIPOS_MENUResult>();
        #endregion

        #region Metodos
        public List<SP_LISTAR_TIPOS_MENUResult> logicListarTiposMenu()
        {
            try
            {
                _listaTiposMenu = varDataContext.SP_LISTAR_TIPOS_MENU().ToList();
            }
            catch { }
            return _listaTiposMenu;
        }
        #endregion
    }
}
