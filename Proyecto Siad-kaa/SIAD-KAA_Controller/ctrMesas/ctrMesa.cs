using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIAD_KAA_Entities.Conexion;
using SIAD_KAA_BussinessLogic.Mesas;

namespace SIAD_KAA_Controller.ctrMesas
{
    public class ctrMesa
    {
        #region Variables
        blMesa _blMesa = new blMesa();
        #endregion

        public List<SP_LISTAR_MESASResult> fncListarMesas()
        {
            List<SP_LISTAR_MESASResult> _listaMesas = new List<SP_LISTAR_MESASResult>();
            try
            {
                _listaMesas = _blMesa.logicListarMesas();
            }
            catch { }
            return _listaMesas;
        }
    }
}
