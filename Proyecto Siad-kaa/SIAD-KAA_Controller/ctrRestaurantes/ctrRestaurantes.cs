using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIAD_KAA_BussinessLogic.Restaurantes;
using SIAD_KAA_Entities.Conexion;

namespace SIAD_KAA_Controller.ctrRestaurantes
{
    public class ctrRestaurantes
    {
        #region Variables
        blRestaurante _blRestaurantes = new blRestaurante();
        #endregion

        #region Metodos
        public List<SP_LISTAR_RESTAURANTESResult> fncListarRestaurantes()
        {
            List<SP_LISTAR_RESTAURANTESResult> _restaurantes = new List<SP_LISTAR_RESTAURANTESResult>();

            _restaurantes = _blRestaurantes.logicListarRestaurantes();
            return _restaurantes;

        }

        public void fncModificarCodigoRestaurante(SIAD_RESTAURANTE _varRestaurante)
        {
            _blRestaurantes.logicModificarRestaurante(_varRestaurante);
        }

        #endregion
    }
}
