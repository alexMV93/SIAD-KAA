   M S B A M L   `   `   `  ����  SIAD-KAA5    /SIAD_KAA.Paginas.Facturacion.Pedidos.PagPedidos   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=2.2.0.725, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5	      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5
         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ 
PagPedidos��5      .��5      � .+�5   
   � -   5         �Name$ grdEncabezado��5      $��60��6&   $y�Hidden=�62   $	��Top=�6F   .+�5      �� -   5         ��Name$ 	txbTitulo��5      $
��Wrap=�6+   $��Pedidos��6?   $	��Top=�6N   $��32(�6f    �� TextAlignment$ Center=�6t   $��0,10,0,0q�6�   ���	#FF3A4447$��Segoe UI Semibold)�6�   ��6�   Z� 6�   F� 5      ����~t��\�Ѭb&/P��	���	#FF3A4447$��3��6T   $��
40,55,40,0q�6_    �� Stretch$
 Fill=�6s   ���	#FF3A4447$	��Top=�6�   $��2��6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$		 dtg��5   �   $	��600��6   $��250,100,0,0q�6   $��Visible=�65   ��. 
   CanUserSortColumns
 .    AutoGenerateColumns .  -  'MaterialDesignThemes.Wpf.DataGridAssist   CellPadding$ 13 8 8 8q�5         ColumnHeaderPadding$ 8q�6L   $��1q�6�   $
��Left=�6�   $	��450��6�   $	��Top=�6�      GridLinesVisibility$ 
Horizontal=�6�      AlternatingRowBackground �	#FF3A7E4F
�������   CanUserResizeRows .  ��5   �   �� *Items3+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6%      
IsReadOnly .    Header$
 Code��5+   -    0 ,MaterialDesignDataGridTextColumnEditingStyle1  +System.Windows.Controls.DataGridBoundColumn   EditingElementStyle# [ 5,   -      Binding 5*   C   �� *	PK_MESA+5,   -   9  3MaterialDesignThemes.Wpf.MaterialDataGridTextColumn  5/      $	 100 6<    . $
 Name��50   9    5 1MaterialDesignDataGridTextColumnPopupEditingStyle# [ 51   9    5/   Z   �� *
MES_NUMERO+51   9     54      $	 200 6<    . $ Description��55   9      	MaxLength$	 255��56   9   # [ 57   9    54   Z   �� *MES_DESCRIPCION+57   9     59      $	 100 6<    . $ Numeric��5:   9   # [ 5;   9    59   Z   �� *MES_ESTADO_ACTUAL+   HeaderStyle 5<      �� 5=       �� 
TargetType=	  7System.Windows.Controls.Primitives.DataGridColumnHeader" 	 6     & "MaterialDesignDataGridColumnHeader �� BasedOn# [ 6K   .�5>      ��  �� Property � �� �� Value$ Right=�6D   5?         ElementStyle 5A      �� 5B      " ��6    .�5C      ��  � ��$ Right=�6D   5D      5F      5J      5L      5M      