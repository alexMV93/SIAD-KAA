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
    
    public class ccOpcionMenu : Button
    {
        static ccOpcionMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccOpcionMenu), new FrameworkPropertyMetadata(typeof(ccOpcionMenu)));
        }

        public static readonly DependencyProperty ImagenMenu = DependencyProperty.Register("Imagen", typeof(ImageSource), typeof(ccOpcionMenu), new UIPropertyMetadata(null));
        public static DependencyProperty NombreOpcion = DependencyProperty.Register("Nombre", typeof(string), typeof(ccOpcionMenu), new UIPropertyMetadata(NombreOpcionMenu));

        public ImageSource Imagen
        {
            get { return (ImageSource)this.GetValue(ImagenMenu); }
            set { SetValue(ImagenMenu, value); }
        }
        public string Nombre
        {
            get { return (string)GetValue(NombreOpcion); }
            set { SetValue(NombreOpcion, value); }
        }

        private static void NombreOpcionMenu(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ccOpcionMenu nombreOpcionM = (ccOpcionMenu)d;
            nombreOpcionM.Nombre = e.NewValue as string;
        } 
    }
}
