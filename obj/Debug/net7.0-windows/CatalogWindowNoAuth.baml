   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L5clr-namespace:System.Diagnostics;assembly=WindowsBaseSystem.Diagnostics 5      !    WpfApp1.CatalogWindowNoAuth   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   Fdiag5clr-namespace:System.Diagnostics;assembly=WindowsBase     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � Title$  Register��5
   	   $	��600��6   $	��800��6'   .��5      � ���	#ffdadada.+�5   
   �� $	��400��6   $��15q�6    
�������$��Center=�6?    �� Padding$ 30q�6Z   $	��550��6g    �� CornerRadius$ 20��6v    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ 	LightGray��63      ShadowDepth$ 0Q�6E   ._�5      �� $
��Auto=�6   .��5      �� .+�5      �� $��Register��6   $��30(�6,   $
��Bold"�6:   $��0,0,0,20q�6L   6`   � 5      $��0,0,0,20q�6   .+�5      �� -   5        $
��Left=�5      $��Register��68   6b   �� 5      -   5        $��Right=�5      $��login��69      MaterialDesignFlatButton#��[  6I   6�   5      �� 5      -   5         ��Name$
 list��5      $��False��6)   ��5      �� 5      .R�5      � $��20q�6#   $	��400��6/    � ColumnDefinitions 5   "   �� 5   &   $
��Auto �67   �� 5   &   $��40 �67   �� 5    &   $
��Auto �67   �� 5!   &   $
��Auto �67   	 � RowDefinitions	 5#   "   �� 5$   &   $
��Auto �64   �� 5%   &   $
��Auto �64   .+�5)   "   �� $	��150��6(   $	��150��64   $��0��6A   $��0��6Q   ��6^   �� *
ImageUrl+�� 5,   "   $��Center=�5-      
 �� TextAlignment$
 Center=�6+   $	��150��5.      $
��Wrap=�6   $��Center=�5/      $	��5 5q�6-   $��26(�50      $��0��6   $��1��6.   ��5,   ,   �� *ProductName+ �� TargetNullValue$ ProductName is null��50   .   �� 53   "   $��2��54      $��	5 5 5 15 q�6    $��Center=�55      $��26(�6-   $
��Bold"�6;   ��53   ,   �� *Price+$ Producprice is null��$55   R   �� 58   "   -   5        $��2��58   )   $��1��69   $��5q�6F   $��Center=�6Q   $��Right=�6l   .��5:   &   ��  �� Orientation$ 
Horizontal=�61   .+�5<   *   �� $
��🛒��64   $��20(�6>   $��Center=�6L   �� 5>   *   $��Add to Cart��64   $��Center=�6G   $��5,0,0,0q�6b   5?   '   5@   #   �� 5C   "   $��3��5D      $��0��6    $��14(�6-   $��Right=�6;   ��5C   ,   �� *QuantityAvailable+$ Productavailebale is null��left5D   ]   5E      5I      5K      5M      5N      5O      5P      5Q      