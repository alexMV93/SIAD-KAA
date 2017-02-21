using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SIAD_KAA_Controller.ctrTiposMenu;
using SIAD_KAA_Controller.ctrMenu;
using SIAD_KAA_Entities.Conexion;
using SIAD_KAA_Entities.Entidades;
using SIAD_KAA.Controles.Personalizados;

namespace SIAD_KAA.Paginas.Facturacion.Menu
{
    /// <summary>
    /// Lógica de interacción para pagMenu.xaml
    /// </summary>
    public partial class pagMenu : Page
    {
        #region Variables
        ctrTiposMenu _ctrTiposMenu = new ctrTiposMenu();
        ctrMenu _ctrMenu = new ctrMenu();
        public static Entidad_SIAD_MENUS _productoSeleccionado = new Entidad_SIAD_MENUS();
        public static int _accion;//1 registrar, 2 modificar
        #endregion
        public pagMenu()
        {
            InitializeComponent();
            frmNavegadorMenu.Content = null;
            this.Loaded += pagMenu_Loaded;
        }

        void pagMenu_Loaded(object sender, RoutedEventArgs e)
        {
            List<SP_LISTAR_TIPOS_MENUResult> _tiposMenu = _ctrTiposMenu.fncListarTiposMenu();
            if (_tiposMenu.Count > 0)
                cbxTipoMenu.ItemsSource = _tiposMenu;

            cargarProductos();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            //frmNavegadorMenu.Visibility = System.Windows.Visibility.Visible;
            _accion = 1;
            this.NavigationService.Navigate(new Uri("/Paginas/Facturacion/Menu/pagMenuMantenimiento.xaml", UriKind.RelativeOrAbsolute));
            //frmNavegadorMenu.Navigate(new Uri("/Paginas/Facturacion/Menu/pagMenuMantenimiento.xaml", UriKind.RelativeOrAbsolute));
        }

        private void cargarProductos()
        {
            wrpProductos.Children.Clear();
            List<Entidad_SIAD_MENUS> _listaMenu = new List<Entidad_SIAD_MENUS>();
            short _varTipoMenu = 0;
            string _varNombre = "";
            if (cbxTipoMenu.SelectedValue != null)
                _varTipoMenu = (short)(cbxTipoMenu.SelectedValue);
            if (cbxMenu.SelectedValue != null)
                _varNombre = cbxMenu.SelectedValue.ToString();
            _listaMenu = _ctrMenu.fncListarMenu(_varTipoMenu, _varNombre);
            if (_listaMenu.Count > 0)
            {
                foreach (Entidad_SIAD_MENUS varProducto in _listaMenu)
                {
                    ccMenu _producto = new ccMenu();
                    _producto.DataContext = varProducto;
                    _producto.MouseDoubleClick += _producto_MouseDoubleClick;
                    _producto.Click += _producto_Click;
                    wrpProductos.Children.Add(_producto);
                }
            }
        }

        void _producto_Click(object sender, RoutedEventArgs e)
        {
            ccMenu _producto = (ccMenu)sender;
            _productoSeleccionado = null;
            _productoSeleccionado = _producto.DataContext as Entidad_SIAD_MENUS;
        }

        void _producto_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            _accion = 2;
            this.NavigationService.Navigate(new Uri("/Paginas/Facturacion/Menu/pagMenuMantenimiento.xaml", UriKind.RelativeOrAbsolute));
        }

        private void cbxTipoMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbxMenu.ItemsSource = null;
            List<SP_LISTAR_MENU_POR_TIPO_MENUResult> _menu = _ctrMenu.fncListarMenuPorTipoMenu((short)(cbxTipoMenu.SelectedValue));
            if (_menu.Count > 0)
                cbxMenu.ItemsSource = _menu;

            cargarProductos();
        }

        private void cbxMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cargarProductos();
        }

        
    }
}
