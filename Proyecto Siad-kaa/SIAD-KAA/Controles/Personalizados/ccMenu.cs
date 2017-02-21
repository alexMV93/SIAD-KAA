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
    
    public class ccMenu : Button
    {
        static ccMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccMenu), new FrameworkPropertyMetadata(typeof(ccMenu)));
        }

        public static readonly DependencyProperty varImagenProducto = DependencyProperty.Register("MEN_IMAGEN", typeof(ImageSource), typeof(ccMenu), new UIPropertyMetadata(null));
        public static DependencyProperty varNombreProducto = DependencyProperty.Register("MEN_NOMBRE", typeof(string), typeof(ccMenu), new UIPropertyMetadata(NombreProd));
        public static DependencyProperty varPrecioProducto = DependencyProperty.Register("MEN_PRECIO_IVI", typeof(string), typeof(ccMenu), new UIPropertyMetadata(PrecioProd));

        public ImageSource MEN_IMAGEN
        {
            get { return (ImageSource)this.GetValue(varImagenProducto); }
            set { SetValue(varImagenProducto, value); }
        }
        public string MEN_NOMBRE
        {
            get { return (string)GetValue(varNombreProducto); }
            set { SetValue(varNombreProducto, value); }
        }

        public string MEN_PRECIO_IVI
        {
            get { return (string)GetValue(varPrecioProducto); }
            set { SetValue(varPrecioProducto, value); }
        }

        private static void NombreProd(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ccMenu varProducto = (ccMenu)d;
            varProducto.MEN_NOMBRE = e.NewValue as string;
        }
        
        private static void PrecioProd(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ccMenu varPrecioProducto = (ccMenu)d;
            varPrecioProducto.MEN_PRECIO_IVI = e.NewValue as string;
        }
    }
}
