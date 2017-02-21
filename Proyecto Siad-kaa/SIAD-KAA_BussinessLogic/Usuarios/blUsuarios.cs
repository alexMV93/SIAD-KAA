using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using SIAD_KAA_Entities.Conexion;

namespace SIAD_KAA_BussinessLogic.Usuarios
{
    public class blUsuarios
    {

        #region Variables

        
        SP_VERIFICAR_USUARIOResult _usuario = new SP_VERIFICAR_USUARIOResult();
        List<SP_TIPOS_MENU_POR_USUARIOResult> _listaTiposMenu = new List<SP_TIPOS_MENU_POR_USUARIOResult>();
        List<SP_LISTAR_PAGINAS_POR_TIPOResult> _listaPaginas = new List<SP_LISTAR_PAGINAS_POR_TIPOResult>();
        SIAD_KAABaseDatosDataContext varDataContext = new SIAD_KAABaseDatosDataContext();
        #endregion

        #region Metodos
        public SP_VERIFICAR_USUARIOResult logicListarUsuario(string varUsuario, string varContraseña)
        {
            try
            {
                _usuario = varDataContext.SP_VERIFICAR_USUARIO(varUsuario, varContraseña).Single();
            }
            catch { }
            return _usuario;
        }

        public List<SP_TIPOS_MENU_POR_USUARIOResult> logicCargarTiposDeMenuPorRol(short varRol)
        {
            try
            {
                _listaTiposMenu = varDataContext.SP_TIPOS_MENU_POR_USUARIO(varRol).ToList();
            }
            catch { }
            return _listaTiposMenu;
        }

        public List<SP_LISTAR_PAGINAS_POR_TIPOResult> logicCargarPaginasPorTipo(string varTipo, short varRol)
        {
            try 
            {
                _listaPaginas = varDataContext.SP_LISTAR_PAGINAS_POR_TIPO(varTipo, varRol).ToList();
            }
            catch { }
            return _listaPaginas;
        }
        #endregion
    }
}
