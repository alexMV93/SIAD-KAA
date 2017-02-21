using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIAD_KAA_Entities.Conexion;
using SIAD_KAA_Entities.Entidades;

namespace SIAD_KAA_BussinessLogic.Menu
{
    public class blMenu
    {
        #region Variables
        SIAD_KAABaseDatosDataContext varDataContext = new SIAD_KAABaseDatosDataContext();
        
        #endregion

        #region Metodos

        public void logicRegistrarMenu(Entidad_SIAD_MENUS varMenu)
        {
            try
            {
                varDataContext.SP_REGISTRAR_MENU(varMenu.PK_PORCION, 
                                                 varMenu.PK_RESTAURANTE, 
                                                 varMenu.PK_TIPO_MENU, 
                                                 varMenu.MEN_CODIGO, 
                                                 varMenu.MEN_NOMBRE, 
                                                 varMenu.MEN_IMAGEN, 
                                                 varMenu.MEN_PRECIO, 
                                                 varMenu.MEN_PRECIO_IVI, 
                                                 varMenu.MEN_DESCUENTO, 
                                                 varMenu.MEN_ESTADO, 
                                                 varMenu.MEN_USUARIO);
            }
            catch { }
        }

        public void logicModificarMenu(Entidad_SIAD_MENUS varMenu)
        {
            try
            {
                varDataContext.SP_MODIFICAR_MENU(varMenu.PK_MENU,
                                                 varMenu.PK_PORCION,
                                                 varMenu.PK_RESTAURANTE,
                                                 varMenu.MEN_NOMBRE,
                                                 varMenu.MEN_IMAGEN,
                                                 varMenu.MEN_PRECIO,
                                                 varMenu.MEN_PRECIO_IVI,
                                                 varMenu.MEN_DESCUENTO,
                                                 varMenu.MEN_ESTADO,
                                                 varMenu.MEN_USUARIO);
            }
            catch { }
        }

        public void logicEliminarMenu(short varPkMenu)
        {
            try
            {
                varDataContext.SP_ELIMINAR_MENU(varPkMenu);
            }
            catch { }
        }

        public List<SP_LISTAR_MENU_POR_TIPO_MENUResult> logicListarMenuPorTipoMenu(short varTipoMenu)
        {
            List<SP_LISTAR_MENU_POR_TIPO_MENUResult> _listaMenu = new List<SP_LISTAR_MENU_POR_TIPO_MENUResult>();
            try
            {
                _listaMenu = varDataContext.SP_LISTAR_MENU_POR_TIPO_MENU(varTipoMenu).ToList();
            }
            catch { }
            return _listaMenu;
        }

        public List<Entidad_SIAD_MENUS> logicListarMenu(short varTipoMenu, string varMenNombre)
        {
            List<SP_LISTAR_MENUResult> _listaMenu = new List<SP_LISTAR_MENUResult>();
            List<Entidad_SIAD_MENUS> _listaEntidadMenu = new List<Entidad_SIAD_MENUS>();
            try
            {
                _listaMenu = varDataContext.SP_LISTAR_MENU(varTipoMenu, varMenNombre).ToList();
                _listaEntidadMenu = logicConvertirSpEnSiadMenu(_listaMenu);

            }
            catch { }
            return _listaEntidadMenu;
        }


        public Entidad_SIAD_MENUS logicListarMenuPorPk(short varPkMenu)
        {
            SP_LISTAR_MENU_POR_PKResult _Menu = new SP_LISTAR_MENU_POR_PKResult();
            Entidad_SIAD_MENUS _EntidadMenu = new Entidad_SIAD_MENUS();
            try
            {
                _Menu = varDataContext.SP_LISTAR_MENU_POR_PK(varPkMenu).FirstOrDefault();
                _EntidadMenu = logicConvertirSpMenuEnSiadMenu(_Menu);

            }
            catch { }
            return _EntidadMenu;
        }

        private List<Entidad_SIAD_MENUS> logicConvertirSpEnSiadMenu(List<SP_LISTAR_MENUResult> _listaMenu)
        {
            List<Entidad_SIAD_MENUS> _listaMenus = new List<Entidad_SIAD_MENUS>();
            foreach (SP_LISTAR_MENUResult _varMenu in _listaMenu)
            {
                Entidad_SIAD_MENUS _entidadMenu = new Entidad_SIAD_MENUS();
                _entidadMenu.PK_MENU = _varMenu.PK_MENU;
                _entidadMenu.PK_RESTAURANTE = _varMenu.PK_RESTAURANTE;
                _entidadMenu.PK_PORCION = _varMenu.PK_PORCION;
                _entidadMenu.PK_TIPO_MENU = _varMenu.PK_TIPO_MENU;
                _entidadMenu.MEN_NOMBRE = _varMenu.MEN_NOMBRE;
                _entidadMenu.MEN_IMAGEN = (byte[])(_varMenu.MEN_IMAGEN.ToArray());
                _entidadMenu.MEN_PRECIO = _varMenu.MEN_PRECIO;
                _entidadMenu.MEN_PRECIO_IVI = _varMenu.MEN_PRECIO_IVI;
                _entidadMenu.MEN_DESCUENTO = _varMenu.MEN_DESCUENTO;
                _entidadMenu.MEN_PRECIO_IVI_STRING = "₡" + _entidadMenu.MEN_PRECIO_IVI.ToString();
                _entidadMenu.MEN_CODIGO = _varMenu.MEN_CODIGO;
                _listaMenus.Add(_entidadMenu);
            }
            return _listaMenus;
        }


        private Entidad_SIAD_MENUS logicConvertirSpMenuEnSiadMenu(SP_LISTAR_MENU_POR_PKResult _Menu)
        {
                Entidad_SIAD_MENUS _entidadMenu = new Entidad_SIAD_MENUS();
                _entidadMenu.PK_MENU = _Menu.PK_MENU;
                _entidadMenu.PK_RESTAURANTE = _Menu.PK_RESTAURANTE;
                _entidadMenu.PK_PORCION = _Menu.PK_PORCION;
                _entidadMenu.PK_TIPO_MENU = _Menu.PK_TIPO_MENU;
                _entidadMenu.MEN_NOMBRE = _Menu.MEN_NOMBRE;
                _entidadMenu.MEN_IMAGEN = (byte[])(_Menu.MEN_IMAGEN.ToArray());
                _entidadMenu.MEN_PRECIO = _Menu.MEN_PRECIO;
                _entidadMenu.MEN_PRECIO_IVI = _Menu.MEN_PRECIO_IVI;
                _entidadMenu.MEN_PRECIO_IVI_STRING = "₡" + _entidadMenu.MEN_PRECIO_IVI.ToString();
                _entidadMenu.MEN_CODIGO = _Menu.MEN_CODIGO;
            return _entidadMenu;
        }
        #endregion
    }
}
