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

namespace SIAD_KAA.Controles.Personalizados
{
    public class ccMesa : Button
    {
        static ccMesa()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccMesa), new FrameworkPropertyMetadata(typeof(ccMesa)));
        }

        public static readonly DependencyProperty varImagenMesa = DependencyProperty.Register("MES_IMAGEN", typeof(ImageSource), typeof(ccMesa), new UIPropertyMetadata(null));
        public static DependencyProperty varNumeroMesa = DependencyProperty.Register("MES_NUMERO", typeof(int), typeof(ccMesa), new UIPropertyMetadata(NumeroMesa));
        public static DependencyProperty varEstadoActual = DependencyProperty.Register("MES_ESTADO_ACTUAL", typeof(string), typeof(ccMesa), new UIPropertyMetadata(EstadoActual));

        public ImageSource MES_IMAGEN
        {
            get { return (ImageSource)this.GetValue(varImagenMesa); }
            set { SetValue(varImagenMesa, value); }
        }
        public int MES_NUMERO
        {
            get { return (int)GetValue(varNumeroMesa); }
            set { SetValue(varNumeroMesa, value); }
        }

        public string MES_ESTADO_ACTUAL
        {
            get { return (string)GetValue(varEstadoActual); }
            set { SetValue(varEstadoActual, value); }
        }

        private static void NumeroMesa(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ccMesa varProducto = (ccMesa)d;
            varProducto.MES_NUMERO = Convert.ToInt32(e.NewValue);
        }

        private static void EstadoActual(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ccMesa varPrecioProducto = (ccMesa)d;
            varPrecioProducto.MES_ESTADO_ACTUAL = e.NewValue as string;
        }
    }
}
