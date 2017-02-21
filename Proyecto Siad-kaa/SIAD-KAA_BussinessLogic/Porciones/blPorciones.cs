using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIAD_KAA_Entities.Conexion;

namespace SIAD_KAA_BussinessLogic.Porciones
{
    public class blPorciones
    {
        #region Variables
        List<SP_LISTAR_PORCIONESResult> _listaPorciones = new List<SP_LISTAR_PORCIONESResult>();
        SIAD_KAABaseDatosDataContext varDataContext = new SIAD_KAABaseDatosDataContext();
        #endregion

        #region Metodos
        public List<SP_LISTAR_PORCIONESResult> logicListarPorciones()
        {
            try
            {
                _listaPorciones = varDataContext.SP_LISTAR_PORCIONES().ToList();
            }
            catch { }
            return _listaPorciones;
        }
        #endregion
    }
}
