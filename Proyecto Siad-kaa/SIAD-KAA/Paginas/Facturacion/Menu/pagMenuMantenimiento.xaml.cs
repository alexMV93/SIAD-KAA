using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using SIAD_KAA_Entities.Entidades;
using SIAD_KAA_Controller.ctrMenu;
using SIAD_KAA_Controller.ctrPorciones;
using SIAD_KAA_Controller.ctrRestaurantes;
using SIAD_KAA_Controller.ctrTiposMenu;
using SIAD_KAA_Controller.ParametrosGenerales;
using SIAD_KAA_Entities.Conexion;


namespace SIAD_KAA.Paginas.Facturacion.Menu
{
    /// <summary>
    /// Lógica de interacción para pageMenuMantenimiento.xaml
    /// </summary>
    public partial class pagMenuMantenimiento : Page
    {

        #region Variables
        byte[] varImagen = new byte[0];
        int varVerificacion = 0;
        BitmapDecoder varBitCoder;
        string _usuario = MainWindow._usuario.USU_USUARIO.ToString();
        ctrMenu _ctrMenu = new ctrMenu();
        ctrRestaurantes _ctrRestaurantes = new ctrRestaurantes();
        ctrPorciones _ctrPorciones = new ctrPorciones();
        ctrTiposMenu _ctrTiposMenu = new ctrTiposMenu();
        ctrParametroGeneral _ctrParametroGeneral = new ctrParametroGeneral();
        Entidad_SIAD_MENUS _menuSeleccionado = pagMenu._productoSeleccionado;
        SP_LISTAR_PARAMETRO_GENERAL_POR_NOMBREResult _parametroGeneral_IVI;

        List<SP_LISTAR_RESTAURANTESResult> _restaurantes = new List<SP_LISTAR_RESTAURANTESResult>();

        List<SP_LISTAR_PORCIONESResult> _porciones = new List<SP_LISTAR_PORCIONESResult>();

        List<SP_LISTAR_TIPOS_MENUResult> _tiposMenu = new List<SP_LISTAR_TIPOS_MENUResult>();


        SP_LISTAR_RESTAURANTESResult _restaurante = new SP_LISTAR_RESTAURANTESResult();
        int _accion = pagMenu._accion;

        #endregion

        #region Eventos
        public pagMenuMantenimiento()
        {
            InitializeComponent();
            this.Loaded += pagMenuMantenimiento_Loaded;
        }

        void pagMenuMantenimiento_Loaded(object sender, RoutedEventArgs e)
        {
            CargarCombos();

            _parametroGeneral_IVI = _ctrParametroGeneral.fncListarMenu("I.V.I");

            if (_accion == 2)
                fncCargarMenu();

        }

        private void btnSeleccionarImagen_Click(object sender, RoutedEventArgs e)
        {
            fncCargarImagen();
        }
        #endregion

        #region Metodos

        private void CargarCombos()
        {
            _restaurantes = _ctrRestaurantes.fncListarRestaurantes();
            if (_restaurantes.Count > 0)
                cbxRestaurante.ItemsSource = _restaurantes;

            _porciones = _ctrPorciones.fncListarPorciones();
            if (_porciones.Count > 0)
                cbxPorcion.ItemsSource = _porciones;

             _tiposMenu = _ctrTiposMenu.fncListarTiposMenu();
            if (_tiposMenu.Count > 0)
                cbxTipoMenu.ItemsSource = _tiposMenu;
        }
        private void fncCargarImagen()
        {
            try
            {
                varImagen = null;
                OpenFileDialog varVentanaBusqueda = new OpenFileDialog();
                varVentanaBusqueda.Filter = "Imagenes jpg(*.jpg)|*.jpg|All files(*.*)|*.*";
                if (varVentanaBusqueda.ShowDialog() == true)
                {
                    using (Stream stream = varVentanaBusqueda.OpenFile())
                    {
                        varBitCoder = BitmapDecoder.Create(stream, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.OnLoad);
                        ImageBrush myBrush = new ImageBrush();
                        myBrush.ImageSource = varBitCoder.Frames[0];
                        myBrush.Stretch = Stretch.UniformToFill;
                        imgImagenProducto.Source = myBrush.ImageSource;
                    }
                }
                else
                {
                    imgImagenProducto.Source = null;
                }
                if (imgImagenProducto.Source != null)
                {
                    System.IO.FileStream varFileStream;
                    varFileStream = new System.IO.FileStream(varVentanaBusqueda.FileName, System.IO.FileMode.Open);
                    varImagen = new byte[Convert.ToInt32(varFileStream.Length.ToString())];
                    varFileStream.Read(varImagen, 0, varImagen.Length);
                    varVerificacion = 1;
                }
            }
            catch { }
        }

        private void fncRegistrarMenu()
        {
            try 
            {
                Entidad_SIAD_MENUS _menu = new Entidad_SIAD_MENUS();
                _menu.PK_PORCION = (short)(cbxPorcion.SelectedValue);
                _menu.PK_RESTAURANTE = (short)(cbxRestaurante.SelectedValue);
                _menu.PK_TIPO_MENU = (short)(cbxTipoMenu.SelectedValue);
                _menu.MEN_NOMBRE = txtNombre.Text.ToUpper();
                _menu.MEN_PRECIO = Convert.ToDecimal(txtPrecio.Text);
                _menu.MEN_PRECIO_IVI = Convert.ToDecimal(txtPrecioConIVI.Text);
                if (txtDescuento.Text == "")
                    _menu.MEN_DESCUENTO = 0;
                else
                    _menu.MEN_DESCUENTO = Convert.ToDecimal(txtDescuento.Text);
                _menu.MEN_IMAGEN = varImagen;
                _menu.MEN_ESTADO = "A";
                _menu.MEN_CODIGO = txtCodigo.Text.ToString().ToUpper();
                _menu.MEN_USUARIO = _usuario;
                _ctrMenu.fncRegistrarMenu(_menu,1);

                SIAD_RESTAURANTE _siadRestaurante = new SIAD_RESTAURANTE();
                _siadRestaurante.PK_RESTAURANTE = _restaurante.PK_RESTAURANTE;
                _siadRestaurante.RES_CODIGO_MENU = (Convert.ToInt32(_restaurante.RES_CODIGO_MENU) + 1).ToString();
                _siadRestaurante.RES_MODIFICADO_POR = _usuario;
                _ctrRestaurantes.fncModificarCodigoRestaurante(_siadRestaurante);

                this.NavigationService.Navigate(new Uri("/Paginas/Facturacion/Menu/pagMenu.xaml", UriKind.RelativeOrAbsolute));

                
            }
            catch { }
        }

        private void fncCargarMenu()
        {
            if (_menuSeleccionado.PK_MENU != 0)
            {
                cbxRestaurante.SelectedValue = _menuSeleccionado.PK_RESTAURANTE.ToString();
                cbxPorcion.SelectedValue = _menuSeleccionado.PK_PORCION.ToString();
                cbxTipoMenu.SelectedValue = _menuSeleccionado.PK_TIPO_MENU.ToString();
                txtNombre.Text = _menuSeleccionado.MEN_NOMBRE.ToString();
                txtCodigo.Text = _menuSeleccionado.MEN_CODIGO.ToString();
                txtPrecio.Text = _menuSeleccionado.MEN_PRECIO.ToString();
                txtPrecioConIVI.Text = _menuSeleccionado.MEN_PRECIO_IVI.ToString();
                txtDescuento.Text = _menuSeleccionado.MEN_DESCUENTO.ToString();

                cbxTipoMenu.IsEnabled = false;
            }
        }

        private void fncModificarMenu()
        {
            try
            {
                Entidad_SIAD_MENUS _menu = new Entidad_SIAD_MENUS();
                _menu.PK_MENU = _menuSeleccionado.PK_MENU;
                _menu.PK_PORCION = Convert.ToInt16(cbxPorcion.SelectedValue);
                _menu.PK_RESTAURANTE = Convert.ToInt16(cbxRestaurante.SelectedValue);
                _menu.MEN_NOMBRE = txtNombre.Text.ToUpper();
                _menu.MEN_PRECIO = Convert.ToDecimal(txtPrecio.Text);
                _menu.MEN_PRECIO_IVI = Convert.ToDecimal(txtPrecioConIVI.Text);
                _menu.MEN_DESCUENTO = Convert.ToDecimal(txtDescuento.Text);
                if(varVerificacion == 0)
                    _menu.MEN_IMAGEN = _menuSeleccionado.MEN_IMAGEN;
                else
                    _menu.MEN_IMAGEN = varImagen;
                _menu.MEN_ESTADO = "A";
                _menu.MEN_USUARIO = _usuario;
                _ctrMenu.fncRegistrarMenu(_menu, 2);

                this.NavigationService.Navigate(new Uri("/Paginas/Facturacion/Menu/pagMenu.xaml", UriKind.RelativeOrAbsolute));


            }
            catch { }
        }

        private void fncCalcularIVI()
        {
            if (_parametroGeneral_IVI != null)
            {
                decimal varPrecio = Convert.ToDecimal(txtPrecio.Text);
                decimal varPorcentaje = (varPrecio * Convert.ToDecimal(_parametroGeneral_IVI.PGE_DESCRIPCION)) / 100;
                varPrecio = varPrecio + varPorcentaje;
                txtPrecioConIVI.Text = varPrecio.ToString();
            }
        }

        private void fncObtenerCodigo()
        {
            if (cbxTipoMenu.SelectedValue != null && _accion == 1)
            {
                int varTipoMenu = Convert.ToInt32(cbxTipoMenu.SelectedValue);
                SP_LISTAR_TIPOS_MENUResult _tipo = new SP_LISTAR_TIPOS_MENUResult();
                string _varCodigo;
                foreach (SP_LISTAR_TIPOS_MENUResult varTipo in _tiposMenu)
                {
                    if (varTipo.PK_TIPO_MENU == varTipoMenu)
                    {
                        _tipo = varTipo;
                    }
                }
                _varCodigo = _tipo.TIM_CODIGO.ToString().ToUpper();

                for (int i = 0; i < _restaurantes.Count; i++)
                {
                    if (i == 0)
                        _restaurante = _restaurantes[i];
                }

                _varCodigo = _varCodigo + "-" + (Convert.ToInt32(_restaurante.RES_CODIGO_MENU) + 1).ToString();
                txtCodigo.Text = _varCodigo.ToString();
            }
        }
        #endregion

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if (_accion == 1)
            {
                if (cbxPorcion.SelectedValue != null && cbxRestaurante.SelectedValue != null
                    && cbxTipoMenu.SelectedValue != null && txtNombre.Text != null
                    && txtPrecio.Text != null && varImagen != null
                    && txtCodigo.Text != null && txtPrecioConIVI.Text != null)
                {
                    fncRegistrarMenu();
                }
            }
            if (_accion == 2)
            {
                if (cbxPorcion.SelectedValue != null && cbxRestaurante.SelectedValue != null
                    && txtNombre.Text != null && txtPrecio.Text != null && txtPrecioConIVI.Text != null)
                {
                    fncModificarMenu();
                }
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Paginas/Facturacion/Menu/pagMenu.xaml", UriKind.RelativeOrAbsolute));
        }

        private void cbxTipoMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            fncObtenerCodigo();
        }

        private void txtPrecio_TextChanged(object sender, TextChangedEventArgs e)
        {
            fncCalcularIVI();
        }
    }
}
