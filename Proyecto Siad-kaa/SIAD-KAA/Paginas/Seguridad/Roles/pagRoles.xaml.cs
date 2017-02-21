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

namespace SIAD_KAA.Paginas.Seguridad
{
    /// <summary>
    /// Lógica de interacción para pagRoles.xaml
    /// </summary>
    public partial class pagRoles : Page
    {
        public pagRoles()
        {
            InitializeComponent();
        }

        private void ButtonsDemoChip_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Chip clicked.");
        }

        private void ButtonsDemoChip_DeleteClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Chip delete clicked.");
        }
    }
}
