using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIAD_KAA_Entities.Conexion;
using SIAD_KAA_BussinessLogic.TipoMenu;

namespace SIAD_KAA_Controller.ctrTiposMenu
{
    public class ctrTiposMenu
    {
        #region Variables
        blTipoMenu _blTiposMenu = new blTipoMenu();
        #endregion

        #region Metodos
        public List<SP_LISTAR_TIPOS_MENUResult> fncListarTiposMenu()
        {
            List<SP_LISTAR_TIPOS_MENUResult> _tiposMenu = new List<SP_LISTAR_TIPOS_MENUResult>();

            _tiposMenu = _blTiposMenu.logicListarTiposMenu();
            return _tiposMenu;

        }
        #endregion
    }
}
