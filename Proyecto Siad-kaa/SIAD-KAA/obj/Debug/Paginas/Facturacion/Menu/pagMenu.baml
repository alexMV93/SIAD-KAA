   M S B A M L   `   `   `  ����C  ?SIAD-KAA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:SIAD_KAA.Controles.Personalizados!SIAD_KAA.Controles.Personalizados  5      /    )SIAD_KAA.Paginas.Facturacion.Menu.pagMenu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=2.2.0.725, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      DPersonalizados/clr-namespace:SIAD_KAA.Controles.Personalizados  5         MaterialDesignBody#���   5      $��Regular"�5	      $��13(�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ pagMenu��5      .��5      � ��. .+�5      � -   5         �Name$ grdEncabezado��5   	   $��60��6    $	��Top=�6,   .+�5      �� -   5         ��Name$ 	txbTitulo��5      $
��Wrap=�6"   $
��Menu��66   $	��Top=�6B   $��32(�6Z    �� TextAlignment$ Center=�6h   $��0,10,0,0q�6   ���	#FF3A4447$��Segoe UI Semibold)�6�   ��6�   Z� 6�   F� 5      ����~t��\�Ѭb&/P��	���	#FF3A4447$��3��6K   $��
40,55,40,0q�6V    �� Stretch$
 Fill=�6j   ���	#FF3A4447$	��Top=�6�   $��2��6�   5      � 5      -   5        $ 	grdCuerpo��5   	   ��. $��Visible=�6A   $��0,65,0,0q�6t   .+�5      � $��100,10,100,0q�6   $	��Top=�6)   ��. $��50��6f   ���	#FFE1E5F0.+�5      �� -   5        	 ��Name$	 cbxTipoMenu��5      
 �� DisplayMemberPath$
 
TIM_NOMBRE��6`    �� SelectedValuePath$ PK_TIPO_MENU��6   $��45��6�   $	��200��6�   $	��Top=�6�    �� 
IsEditable . $��Segoe UI)�6�   $��16(�6�   
���   �)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tipo de Menú��6   & "MaterialDesignFloatingHintComboBox#��[ 6G  $��15,0,0,0q�6�  $
��Left=�6�  5      �� 5      -   5        $	 cbxMenu��5      $
 
MEN_NOMBRE��6X   $ 
MEN_NOMBRE��6w   $��45��6�   $	��Top=�6�    . $��Segoe UI)�6�   $��16(�6�   
���   �$ Nombre del producto��6  #��[ 68  $��244.5,0,0,0q�6t  $
��Left=�6�  $	��305��6�  �� 5!      -   5         ��Name$ 
btnAgregar��5!        MaterialDesignFlatButton#���  6F   $��40��5"      ���	#FF165978$	��Top=�6)   $	��145��6A   $��Right=�6M   $��5q�6i   $��Segoe UI)�6}   $��18(�6�   $��0,5,0,0q�6�   ��5#      �� 5$       �� Color$ 	#FF33C333��6    �� Opacity$
 0.95Q�6*   .��5&      ��  �� Orientation$ 
Horizontal=�6   $	��120��6+   $��30��67   $��Center=�6C   $��Center=�6`   .+�5'      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.2.0.725, Culture=neutral, PublicKeyToken=null]]   Kind$ PlusBox=�6    
�������$��25��6B   $��25��6M   $��Center=�6Y   $��Center=�6t   �� 5(      $��8 0 0 0q�6   $��Center=�6#   
�������$��Segoe UI)�6Q   $��18(�6g   �� 6v   $�Agregar��6z   6�   5)      5*      5+      �� 5,      -   5         ��Name$ svrListaProductos��5,   '   $y�Visible=�6   $
��Auto=�6B   $��100,70,100,40q�6e   ���	#FF3C8781$��0q�6�   ��6�   Z� .��5-      � -   5         �Name$ wrpProductos��5-       � Orientation$ 
Horizontal=�6&   $
��Auto=�6?   ��.  J� Opacity$	 0.8Q�6�   ���	#FFE1E5F05K      5L      5T       � 5U      -	   5          �Name$ frmNavegadorMenu��5U   
   $y�Hidden=�6$   #���  68     � NavigationUIVisibility$ Hidden=�6l   $��0,0,0,0q�6�   5W      5X      