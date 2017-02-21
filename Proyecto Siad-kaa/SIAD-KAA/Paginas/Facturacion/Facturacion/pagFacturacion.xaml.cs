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
using SIAD_KAA_Controller.ctrMesas;
using SIAD_KAA_Entities.Conexion;
using SIAD_KAA.Controles.Personalizados;

namespace SIAD_KAA.Paginas.Facturacion.Facturacion
{
    /// <summary>
    /// Lógica de interacción para pagFacturacion.xaml
    /// </summary>
    public partial class pagFacturacion : Page
    {

        #region Variables
        List<SP_LISTAR_MESASResult> _listaMesas = new List<SP_LISTAR_MESASResult>();
        ctrMesa _ctrMesas = new ctrMesa();
        public static SP_LISTAR_MESASResult _mesaSeleccionada = new SP_LISTAR_MESASResult();
        #endregion

        public pagFacturacion()
        {
            InitializeComponent();
            this.Loaded += pagFacturacion_Loaded;
        }

        void pagFacturacion_Loaded(object sender, RoutedEventArgs e)
        {
            fncListarMesas();
        }

        #region Metodos
        private void fncListarMesas()
        {
            wrpMesas.Children.Clear();
            _listaMesas = _ctrMesas.fncListarMesas();
            if (_listaMesas.Count > 0)
            {
                foreach (SP_LISTAR_MESASResult _mesasSeleccionadas in _listaMesas)
                {
                    ccMesa _mesa = new ccMesa();
                    _mesa.MES_IMAGEN = (ImageSource)Application.Current.FindResource("bmiprueba"+_mesasSeleccionadas.MES_NUMERO);
                    var bc = new BrushConverter();
                    if(_mesasSeleccionadas.MES_ESTADO_ACTUAL == "DISPONIBLE")
                        _mesa.Background = (Brush)bc.ConvertFrom("#FF008000");
                    else
                        _mesa.Background = (Brush)bc.ConvertFrom("#FFBF2222");
                    _mesa.DataContext = _mesasSeleccionadas;
                    _mesa.Click += _mesa_Click;
                    wrpMesas.Children.Add(_mesa);
                }
            }
        }

        void _mesa_Click(object sender, RoutedEventArgs e)
        {
            ccMesa _mesa = (ccMesa)sender;
            _mesaSeleccionada = null;
            _mesaSeleccionada = _mesa.DataContext as SP_LISTAR_MESASResult;
            this.NavigationService.Navigate(new Uri("/Paginas/Facturacion/Pedidos/pagPedidos.xaml", UriKind.RelativeOrAbsolute));
        }
        #endregion
    }
}
