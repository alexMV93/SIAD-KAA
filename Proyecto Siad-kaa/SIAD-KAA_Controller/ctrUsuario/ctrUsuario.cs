using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIAD_KAA_Entities.Conexion;
using SIAD_KAA_BussinessLogic.Usuarios;

namespace SIAD_KAA_Controller.ctrUsuario
{
    public class ctrUsuario
    {
        blUsuarios _blUsuario = new blUsuarios();
        public SP_VERIFICAR_USUARIOResult fncListarUsuario(string varUsuario, string varContraseña)
        {
            SP_VERIFICAR_USUARIOResult _usuario = new SP_VERIFICAR_USUARIOResult();
            
            _usuario = _blUsuario.logicListarUsuario(varUsuario, varContraseña);
            return _usuario;

        }

        public List<SP_TIPOS_MENU_POR_USUARIOResult> fncListarTipoPaginaPorRol(short varRol)
        {
            List<SP_TIPOS_MENU_POR_USUARIOResult> _listaTipos = new List<SP_TIPOS_MENU_POR_USUARIOResult>();
            _listaTipos = _blUsuario.logicCargarTiposDeMenuPorRol(varRol);
            return _listaTipos;

        }

        public List<SP_LISTAR_PAGINAS_POR_TIPOResult> fncListarPaginasPorTipo(string varTipo, short varRol)
        {
            List<SP_LISTAR_PAGINAS_POR_TIPOResult> _listaPaginas = _blUsuario.logicCargarPaginasPorTipo(varTipo, varRol);
            return _listaPaginas;
        }
    }
}
