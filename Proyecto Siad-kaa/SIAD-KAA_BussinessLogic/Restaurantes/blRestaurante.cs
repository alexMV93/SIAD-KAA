using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIAD_KAA_Entities.Conexion;

namespace SIAD_KAA_BussinessLogic.Restaurantes
{
    public class blRestaurante
    {
        #region Variables
        List<SP_LISTAR_RESTAURANTESResult> _listaRestaurantes = new List<SP_LISTAR_RESTAURANTESResult>();
        SIAD_KAABaseDatosDataContext varDataContext = new SIAD_KAABaseDatosDataContext();
        #endregion

        #region Metodos
        public List<SP_LISTAR_RESTAURANTESResult> logicListarRestaurantes()
        {
            try
            {
                _listaRestaurantes = varDataContext.SP_LISTAR_RESTAURANTES().ToList();
            }
            catch { }
            return _listaRestaurantes;
        }

        public void logicModificarRestaurante(SIAD_RESTAURANTE _varRestaurante)
        {
            try
            {
                varDataContext.SP_MODIFCAR_CODIGO_MENU_RESTAURANTE(_varRestaurante.PK_RESTAURANTE,
                                                                    _varRestaurante.RES_CODIGO_MENU,
                                                                    _varRestaurante.RES_MODIFICADO_POR);
            }
            catch { }
        }

        #endregion
    }
}
