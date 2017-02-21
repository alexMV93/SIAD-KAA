using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIAD_KAA_Entities.Conexion;
using SIAD_KAA_BussinessLogic.Menu;
using SIAD_KAA_Entities.Entidades;

namespace SIAD_KAA_Controller.ctrMenu
{
    public class ctrMenu
    {
        #region Variables
        blMenu _blMenu = new blMenu();
        #endregion

        #region Metodos
        public void fncRegistrarMenu(Entidad_SIAD_MENUS varMenu, int varOpcion)
        {
            //registrar(1)
            if(varOpcion == 1)
                _blMenu.logicRegistrarMenu(varMenu);

            //modificar(2)
            if (varOpcion == 2)
                _blMenu.logicModificarMenu(varMenu);

            //eliminar(3)
            if (varOpcion == 3)
                _blMenu.logicEliminarMenu(varMenu.PK_MENU);
        }

        public List<Entidad_SIAD_MENUS> fncListarMenu(short varTipoMenu, string varMenNombre)
        {
            List<Entidad_SIAD_MENUS> _listaMenu = new List<Entidad_SIAD_MENUS>();
            try 
            {
                _listaMenu = _blMenu.logicListarMenu(varTipoMenu, varMenNombre);
            }
            catch { }
            return _listaMenu;
        }

        public List<SP_LISTAR_MENU_POR_TIPO_MENUResult> fncListarMenuPorTipoMenu(short varTipoMenu)
        {
            List<SP_LISTAR_MENU_POR_TIPO_MENUResult> _listaMenu = new List<SP_LISTAR_MENU_POR_TIPO_MENUResult>();
            try
            {
                _listaMenu = _blMenu.logicListarMenuPorTipoMenu(varTipoMenu);
            }
            catch { }
            return _listaMenu;
        }

        public Entidad_SIAD_MENUS fncListarMenuPorPk(short varPkMenu)
        {
            Entidad_SIAD_MENUS _menu = new Entidad_SIAD_MENUS();
            try
            {
                _menu = _blMenu.logicListarMenuPorPk(varPkMenu);
            }
            catch { }
            return _menu;
        }

        #endregion
    }
}
