using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIAD_KAA_Entities.Conexion;

namespace SIAD_KAA_BussinessLogic.Mesas
{
    public class blMesa
    {

        #region Variables
        SIAD_KAABaseDatosDataContext varDataContext = new SIAD_KAABaseDatosDataContext();

        #endregion

        public List<SP_LISTAR_MESASResult> logicListarMesas()
        {
            List<SP_LISTAR_MESASResult> _listaMesas = new List<SP_LISTAR_MESASResult>();
            try
            {
                _listaMesas = varDataContext.SP_LISTAR_MESAS().ToList();
            }
            catch { }
            return _listaMesas;
        }
    }
}
