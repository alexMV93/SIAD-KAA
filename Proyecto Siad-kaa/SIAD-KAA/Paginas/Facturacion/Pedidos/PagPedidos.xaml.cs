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

namespace SIAD_KAA.Paginas.Facturacion.Pedidos
{
    /// <summary>
    /// Lógica de interacción para PagPedidos.xaml
    /// </summary>
    public partial class PagPedidos : Page
    {
        public PagPedidos()
        {
            InitializeComponent();
            this.Loaded += PagPedidos_Loaded;
        }

        void PagPedidos_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                SIAD_MESAS _MESA = new SIAD_MESAS();
                _MESA.PK_MESA = 1;
                _MESA.MES_NUMERO = 1;
                _MESA.MES_DESCRIPCION = "prueba"+i.ToString();
                _MESA.MES_ESTADO_ACTUAL = "dis"+i.ToString();
                _MESA.MES_ESTADO = "A";
                dtg.Items.Add(_MESA);
            }
        }
    }
}
