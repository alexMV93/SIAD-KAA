   M S B A M L   `   `   `  ����C  ?SIAD-KAA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:SIAD_KAA.Controles.Personalizados!SIAD_KAA.Controles.Personalizados  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089U QMaterialDesignThemes.Wpf, Version=2.2.0.725, Culture=neutral, PublicKeyToken=null4    .SIAD_KAA.Controles.Personalizados.ccOpcionMenu  �� 
TargetType �� Property �� Value �� 
TargetType'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame	 O� KeyTime
 O� Value ��Name ��Name �Name.   (SIAD_KAA.Controles.Personalizados.ccMenu#  MaterialDesignThemes.Wpf.Card �� Mode �� UpdateSourceTrigger �� TextAlignment �� NotifyOnValidationError �� ValidatesOnExceptions.   (SIAD_KAA.Controles.Personalizados.ccMesa �� RelativeSource�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      FmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      9local/clr-namespace:SIAD_KAA.Controles.Personalizados  5      8d2http://schemas.microsoft.com/expression/blend/2008  6C   Bmc;http://schemas.openxmlformats.org/markup-compatibility/2006  6�   ;ed4http://schemas.microsoft.com/expression/2010/drawing  6�   %V	  '         '  3    '  �    �� 5      "    6
   .�5	   
   ��  � �� 5
      �� 5      "   6"   .R�5      � $��30��6   $	��150��6'    5        5      CommonStates��. 5        
Normal��6"     5      	MouseOver��. 5      �� .��5      U� $ (TextElement.FontSize)�66   $ 	txtNombre��6i   .\�5        $	 0��6.   $
 17.333Q�6:   5      5      5        5      Pressed��6"     5      Disabled��6"   5      .+�5      �� $ 	imgOpcion��6   $
��Left=�6-   $��25��6H   $	��Top=�6T   $��30��6l   �� 5      $ 	txtNombre��6   $
��Wrap=�61   $��Stretch=�6E   $��33,0,0,5q�6a   $	��117��6s   $��25��6   $��16(�6�   � 5      $ grdBarra��6   $��5��6+   $��Bottom=�66   $	��150��6Q   5      5      5!      5"      �� 5$      "   6   .�5%   
   ��  � �� 5&      �� 5'      "  6"   .R�5(        $��207.194��6*   $��8 2 6 8q�6:   $��149.329��6K   .��5)      � $��Stretch=�6   $��0,0,-4,0q�6;   .+�5*      �� $ imgProducto��6$   $
��Fill=�6�   $��20,4.465,20,72q�6�   ��69   �� *
MEN_IMAGEN+$ OneWay=�$ PropertyChanged=�6�   �� 5+      $ 	txtNombre��6(   $
��Wrap=�6;   $��Bottom=�6x   $��Segoe UI)�6�   $��16(�6�   $ Center=�6�   $��42.72��6�   $��10,0,10,28.28q�6�   
���   ���6O   �� *
MEN_NOMBRE+$ TwoWay=�6�   �� 5,      $ 	txtPrecio��6(   $
��Wrap=�6;   $��Bottom=�6�   
�������
��� � �$��Segoe UI)�6�   $��16(�6  $ Center=�6#  $��5,0,10,5q�6:  $
��Bold"�6L  ��6O   �� *MEN_PRECIO_IVI_STRING+$ TwoWay=� .  . 6L  5-      5.      5/      51      52      �� 54      "   6   .�55   
   ��  � �� 56      �� 57      "  6"   .R�58        $��207.194��6*   $��8 2 6 8q�6:   $��149.329��6K   .��59      � $��Stretch=�6   $��0,0,-4,0q�6;   .+�5:      �� $ imgMesa��6$   $
��Fill=�65   $��20,4.465,20,36.28q�6D   ��6_   �� *
MES_IMAGEN+ �� *TemplatedParent+�� 5;      $ txtEstadoActual��6(   $
��Wrap=�6A   $��Bottom=�6�   
�������#��z��6�   $��Segoe UI)�6�   $��16(�6�   $ Center=�6  $��5,0,10,5q�6  $
��Bold"�6*  $��26.28��6<  ��6U   �� *MES_ESTADO_ACTUAL+$ TwoWay=�6<  5<      5=      5>      5@      5A      5B      