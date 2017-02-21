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
using SIAD_KAA_Entities.Conexion;
using SIAD_KAA_Controller.ctrUsuario;

using SIAD_KAA.Controles.Personalizados;

namespace SIAD_KAA
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static SP_VERIFICAR_USUARIOResult _usuario;
        
        public MainWindow(SP_VERIFICAR_USUARIOResult _pUsuario)
        {
            InitializeComponent();
            _usuario = _pUsuario;
            cargar();

            txtHora.Text = System.DateTime.Now.Date.ToLongDateString();
        }

        public void cargar()
        {
            if (_usuario.PK_USUARIO != 0)
            {
                MenuItem _opcionUsuario = new MenuItem();
                _opcionUsuario.Header = "_" + _usuario.USU_USUARIO;
                MenuItem _salir = new MenuItem();
                _salir.Header = "_ Cerrar Sesión";
                Image g = new Image();
                g.Source = (ImageSource)Application.Current.FindResource("bmiCerrarSesion");
                _salir.Icon = g;
                _salir.Click += _salir_Click;
                _opcionUsuario.Items.Add(_salir);
                menMenuPrincipal.Items.Add(_opcionUsuario);
            }
            ctrUsuario _ctrUsuario = new ctrUsuario();
            List<SP_TIPOS_MENU_POR_USUARIOResult> _listaTipos = _ctrUsuario.fncListarTipoPaginaPorRol(_usuario.PK_ROL);
            if (_listaTipos.Count > 0)
            {
                foreach (SP_TIPOS_MENU_POR_USUARIOResult item in _listaTipos)
                {
                    MenuItem _opcion = new MenuItem();
                _opcion.Header = "_"+item.PAG_TIPO;
                List<SP_LISTAR_PAGINAS_POR_TIPOResult> _listaPaginas = _ctrUsuario.fncListarPaginasPorTipo(item.PAG_TIPO, _usuario.PK_ROL);
                if (_listaPaginas.Count > 0)
                {
                    foreach (SP_LISTAR_PAGINAS_POR_TIPOResult itemMenu in _listaPaginas)
                    {
                        MenuItem opcionMenu = new MenuItem();
                        opcionMenu.Header = "_"+itemMenu.PAG_NOMBRE;
                        //opcionMenu.Icon = (ImageSource)Application.Current.FindResource(itemMenu.PAG_ICONO);
                        Image g = new Image();
                        g.Source = (ImageSource)Application.Current.FindResource(itemMenu.PAG_ICONO);
                       
                        opcionMenu.Icon = g;
                        opcionMenu.Tag = itemMenu.PAG_RUTA;
                        opcionMenu.Click += opcionMenu_Click;
                        _opcion.Items.Add(opcionMenu);
                    }
                    
                }
                
                menMenuPrincipal.Items.Add(_opcion);
                }
            }
            //for (int i = 0; i < 5; i++)
            //{
            //    MenuItem _opcion = new MenuItem();
            //    _opcion.Header = "_Seguridad";
            //    MenuItem p = new MenuItem();
            //    p.Header = "_prueba";
            //    _opcion.Items.Add(p);
            //    menMenuPrincipal.Items.Add(_opcion);
            //}
           
        }

        void _salir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        void opcionMenu_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menu = (MenuItem)sender;
            frmNavegador.Content = null;
            frmNavegador.Navigate(new Uri("/MainWindow.xaml", UriKind.RelativeOrAbsolute));
            frmNavegador.Navigate(new Uri(menu.Tag.ToString(), UriKind.RelativeOrAbsolute));
        }
    }
}
