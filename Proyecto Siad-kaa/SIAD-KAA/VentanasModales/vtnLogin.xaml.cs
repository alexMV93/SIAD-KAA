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
using System.Windows.Shapes;

using SIAD_KAA_Entities.Conexion;
using SIAD_KAA_Controller.ctrUsuario;


namespace SIAD_KAA.VentanasModales
{
    /// <summary>
    /// Lógica de interacción para vtnLogin.xaml
    /// </summary>
    public partial class vtnLogin : Window
    {
        public static SP_VERIFICAR_USUARIOResult _usuario;

        public vtnLogin()
        {
            InitializeComponent();
            txtUsuario.Text = "admin";
            txtContraseña.Text = "123";
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsuario.Text != String.Empty && txtContraseña.Text != string.Empty)
            {
                ctrUsuario _ctrUsuario = new ctrUsuario();
                _usuario = _ctrUsuario.fncListarUsuario(txtUsuario.Text, txtContraseña.Text);
                if (_usuario.PK_USUARIO != 0)
                {
                    MainWindow _mainWindow = new MainWindow(_usuario);
                    this.Close();
                    _mainWindow.ShowDialog();
                }
            }
            
        }

        
    }
}
