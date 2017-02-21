using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIAD_KAA_Entities.Conexion;
using SIAD_KAA_BussinessLogic.Porciones;

namespace SIAD_KAA_Controller.ctrPorciones
{
    public class ctrPorciones
    {
        #region Variables
        blPorciones _blPorciones = new blPorciones();
        #endregion

        #region Metodos
        public List<SP_LISTAR_PORCIONESResult> fncListarPorciones()
        {
            List<SP_LISTAR_PORCIONESResult> _porciones = new List<SP_LISTAR_PORCIONESResult>();

            _porciones = _blPorciones.logicListarPorciones();
            return _porciones;

        }
        #endregion
    }
}
