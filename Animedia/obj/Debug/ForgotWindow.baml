   M S B A M L   `   `   `  ����C  ?Animedia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AnimediaAnimedia  5   	       Animedia.ForgotWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Animedia     5   	   -   5        $	��400��5   	   $	��350��6     � WindowStartupLocation$  CenterScreen=�6"    � WindowStyle$
 None=�5
   	    � AllowsTransparency . 
������  � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ Styles.xaml?�6%   %    5      .��5      ��  �� CornerRadius$ 15��6   ��5   
   �� 5       �� Opacity$ 1Q�6    �� ImageSource$ /Images/back-image.jpg��6%   	 j� Stretch$
	 None=�6J   ._�5   
   � .+�5      �� -   5        
 ��Name$
 PulsatingBorder��5   J   $ 10��6   $��3q�6'    J� Opacity$
 0.95Q�6;   ��5       �� 5!       �� ResourceKey$ GradientBorderBrush��6%   ��5%      �� 5&      $ GradientMainBackground��6%    � Triggers 5*      :� 5+       :� RoutedEvent$ Border.Loaded��6#   .[�5,      �� .��5-      ��  g� RepeatBehavior$ Forever��6)   .��5/   "   t�  �� TargetProperty$ BorderThickness�50   !    t� From$ 2X�51   !   	 t� To$ 4X�6*    g� Duration$ 0:0:1D�61    g� AutoReverse . 6B   52      53      54      57      �� 59      $-��'Востановление пароля��6   
�������$��10(�6K   $��
Montserrat)�5:       $��0��68   $	��Top=�6H   $��	10,10,0,0q�6`   �� 5<      $	��Top=�6   $��Right=�61   $��7q�6M    �� Orientation$ 
Horizontal=�6X   .+�5>      �� -   5         ��Name$ MinimizeBtn��5>      $��0q�6/   $	��─��6C   
�������$��16(�6b   $��
Montserrat)�5?       � Cursor$
 Hand��6-   $��1��6;      MinimizeBtnStyle#��[  6c     MinimizeBtnTemplate#��[ 6�   6�   �� 5A      -   5        $ CloseBtn��5A      $	��Top=�6+   $��Right=�6C   $��7q�6_   $��0q�6j   $	��✕��6~   
�������$��16(�6�   $��
Montserrat)�5B      $
 Hand��6-   $��1��6;     CloseBtnStyle#��[ 6`   #��[ 6�   6�   5D      �� 5G      $��Center=�6   $��0,0,0,30q�66   $��Center=�6H   $	��220��6c   $ Vertical=�6r   .+�5I      �� $��/Images/Logo.png��6   $��50��62   $��50��6=   �� 5K      $��Animedia Studio��6   
�������$��20(�6F   $��Medium"�5L      $��
Montserrat)�6)   $��Center=�6A   �� 5O      $B��<Введите почту или номер телефона��6   
�������$��14(�6Z   $��Medium"�5P      $��
Montserrat)�60   $��0,10,0,0q�6H   �� 5R      -   5         ��Name$ ForgotTb��5R      $��14(�6,   $��Medium"�6:   $��0,5,0,0q�6O   $��3q�6`   $��
Montserrat)�5S      
������� �� 
CaretBrush
 �����
�������$��28��5T   1   
������ $��3q�6V   .��5V   o   5W      �� 5Z      -   5         ��Name$ 	ForgotBtn��5Z   �   $)��#Востановить пароль��6   $��0,20,0,0q�66   
�������$��15(�6_   $
��Bold"�6m   $
 Hand��6     HeaderTextStyle#��[ 5[   A   $��Center=�6j   �� 5^      -   5        $ BackBtn��5^   `   $��
Назад��6   
�������$��0,10,0,0q�6@   $
 Hand��6R   $��10(�6r   #��[ 5_   ?   $��Center=�6h   5c      5e      5g      5i      