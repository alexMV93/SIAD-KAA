   M S B A M L   `   `   `  ����  SIAD-KAA<    6SIAD_KAA.Paginas.Facturacion.Menu.pagMenuMantenimiento   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=2.2.0.725, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5	      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5
         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ pagMenuMantenimiento��5      .��5      � .+�5   
   � -   5         �Name$ grdEncabezado��5      $��60��6&   $	��Top=�62   .+�5      �� -   5         ��Name$ 	txbTitulo��5      $
��Wrap=�6+   $��Mantenimiento Menú��6?   $	��Top=�6Y   $��32(�6q    �� TextAlignment$ Center=�6   $��0,10,0,0q�6�   ���	#FF3A4447$��Segoe UI Semibold)�6�   ��6�   Z� 6�   F� 5      ����~t��\�Ѭb&/P��	���	#FF3A4447$��3��6T   $��
40,55,40,0q�6_    �� Stretch$
 Fill=�6s   ���	#FF3A4447$	��Top=�6�   $��2��6�   5      �� 5   
   $��0, 85, 0, 0q�6   $
��Auto=�6,   $��Disabled=�6O   .��5      � $��0,0,0,0q�6   .+�5      � +  %MaterialDesignThemes.Wpf.ShadowAssist	   ShadowDepth$	 Depth5=�6   $��300,30,300,80q�6I   .+�5      �� 
���   �
�������$��0��6<   
 J� Effect
 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 36Q�6/      ShadowDepth$ 15Q�6?      Opacity$ 0.265Q�6P   5      �� 5      -   5         ��Name$ cbxRestaurante��5       �� DisplayMemberPath$ 
RES_NOMBRE��67    �� SelectedValuePath$ PK_RESTAURANTE��6V   $��
30,10,30,0q�6z   $��45��6�   $	��Top=�6�    �� 
IsEditable . $��Segoe UI)�6�   $��16(�6�   
���   �)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Restaurante��6�    & "MaterialDesignFloatingHintComboBox#��[ 6(  5!      �� 5#      -   5        $ cbxTipoMenu��5#      $ 
TIM_NOMBRE��64   
 � Tag$	 POS��6�   $ PK_TIPO_MENU��6�   $��30,60.762,30,0q�6�   $��45��6�   $	��Top=�6�    . $��Segoe UI)�6�   $��16(�6  
���   �$ Tipo de Menú��63  #��[ 6a  5%      �� 5'      -   5        $ 
cbxPorcion��5'      $ 
POR_NOMBRE��63   $ 
PK_PORCION��6R   $��30,116,30,0q�6q   $��45��6�   $	��Top=�6�    . $��Segoe UI)�6�   $��16(�6�   
���   �$ Porción��6�   #��[ 6  5)      �� 5+      -   5         ��Name$ 	txtNombre��5,      $y�Visible=�6)    % !MaterialDesignFloatingHintTextBox#��[ 6>   $��30,173,30,0q�6y   $��45��6�   $	��Top=�6�   $��Segoe UI)�6�   $��16(�6�   
���   �.��6�    5-      �� 5.       �� Orientation$ 
Horizontal=�6)   $��-2 0 0 0q�6B   .+�5/   "   �� $��16(�6,   Nombre del producto6O   50      .��51   :   52      �� 53      -   5        $ 	txtCodigo��54      #��[ 6)   {�.  $��30,236,30,0q�6v   $��45��6�   $	��Top=�6�   $��Segoe UI)�6�   $��16(�6�   
���   �.��6�    55      �� 56      $ 
Horizontal=�6)   $��-2 0 0 0q�6B   .+�57   "   �� $��16(�6,   Código del producto6O   58      .��59   :   5:      �� 5<      -   5        $ 	txtPrecio��5=      #��[ 6M   $��30,298,30,0q�6�   $��45��6�   $	��Top=�6�   $��Segoe UI)�6�   $��16(�6�   
���   �.��6�    5>      �� 5?      $ 
Horizontal=�6)   $��-2 0 0 0q�6B   .+�5@   "   �� $��16(�6,   Precio del producto en ₡6T   5A      .��5B   :   5C      �� 5E      -	   5        $ txtPrecioConIVI��5F      #��[ 6/   {�.  $��30,355,30,0q�6|   $��45��6�   $	��Top=�6�   $��Segoe UI)�6�   $��16(�6�   
���   �.��6�    5G      �� 5H      $ 
Horizontal=�6)   $��-2 0 0 0q�6B   .+�5I   "   �� $��16(�6,   Precio con I.V.I en ₡6Q   5J      .��5K   :   5L      �� 5N      -
   5        $ txtDescuento��5O      #��[ 6,   $��30,410.762,30,0q�6g   $��45��6�   $	��Top=�6�   $��Segoe UI)�6�   $��16(�6�   
���   �.��6�    5P      �� 5Q      $ 
Horizontal=�6)   $��-2 0 0 0q�6B   .+�5R   "   �� $��16(�6,   Descuento del producto6R   5S      .��5T   :   5U      �� 5V      -   5         ��Name$ imgImagenProducto��5V       � ToolTip$. (Visualización de la imagen del Producto��67   $
��Fill=�6j   $��
30,492,0,0q�6y   $4��./SIAD-KAA;component/Imagenes/maxresdefault.jpg��6�   $
��Left=�6�   $	��251��6�   $	��170��6�   $	��Top=�6�   �� 5W      -   5         ��Name$ btnSeleccionarImagen��5W      $��41.253��6;   $% Seleccionar imagen del Producto��6n   $	��...��6�   $��Segoe UI)�6�   $��25(�6�   
�������$��303,620.747,0,0q�6�   $
��Left=�6�   $��50��6  $	��Top=�6  � 5Y      $��50��6   $	��Top=�6'   $��
0,693,0,20q�6?    � ColumnDefinitions 5Z      �� 5[      �� 5\      .+�5^      �� -   5        $ btnRegistrar��5^   6   $y�Visible=�6!   $ Guardar el producto��6L     MaterialDesignFlatButton#���  6�   $
��Auto��5_      ���	#FF165978$��5q�6C   $��Segoe UI)�6W   $��18(�6m   $��	30,4,18,6q�6{   ��5`      �� 5a       �� Color$ 	#FF33C333��6.    �� Opacity$
 0.95Q�6@   .��5c      �� $ 
Horizontal=�6%   $	��120��6>   $��30��6J   $��Center=�6V   $��Center=�6s   .+�5d      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.2.0.725, Culture=neutral, PublicKeyToken=null]]   Kind$ ContentSave=�66   
�������$��25��6\   $��25��6g   $��Center=�6s   $��Center=�6�   �� 5e      $��8 0 0 0q�6(   $��Center=�69   
�������$��Segoe UI)�6g   $��18(�6}   �� 6�   $�Guardar��6�   6�   5f      5g      �� 5i      -   5        $ btnCancelar��5i   6   $y�Visible=�6!   $ Cancelar proceso��6K   #���  6�   $
��Auto��5j      ���	#FF165978$��5q�6C   $��Segoe UI)�6W   $��18(�6m   $��	18,4,30,6q�6{   $��1��6�   ��5k      �� 5l      $ 	#FFC11E1E��6.   $
 0.95Q�6@   .��5n      �� $ 
Horizontal=�6%   $	��120��6>   $��30��6J   $��Center=�6V   $��Center=�6s   .+�5o        $ Close=�66   
�������$��25��6V   $��25��6a   $��Center=�6m   $��Center=�6�   �� 5p      $��8 0 0 0q�6(   $��Center=�69   
�������$��Segoe UI)�6g   $��18(�6}   �� 6�   $�Cancelar��6�   6�   5q      5r      5s      5t      5u      5v      5x      5y      