   M S B A M L   `   `   `  ����T  PWPF_Detecting_rocket_hits, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLPL  5   	   !clr-namespace:PL.ViewPL.View  5	   	   U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 6c       PL.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesing1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   localclr-namespace:PL  5   	    Viewclr-namespace:PL.View  5	   	   X TXceed.Wpf.Toolkit, Version=3.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  6,   >Wpf4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  6c     � Title$
  HITS��5   	    � 	Resources 5      ��%    5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��35* �6   �� 5      $
��480* �6    � ColumnDefinitions 5   
   �� 5      $	��85* �6   �� 5      $
��250* �6   .+�5   
   � $��2��6   ���	#FFFF9600$��0,0,-0.4,0.6q�6;   $��0��6Q   � 5   
   ���	#FFF3CC84$��2��6(    5       �� 5!      $	��90* �6    �� 5"      $
��350* �6    .+�5&      � -   5         �Name$
 logo��5&   +   $��	20,0,0,20q�6    5'      �� 5(      $	��82* �6(   �� 5)      $	��13* �6(   .+�5+      �� $
��Left=�6!   $��	21,-5,0,0q�6<   $
��Wrap=�6O   $
��HITS��6c   $	��Top=�6o   $��58��6�   $	��144��6�   $��36(�6�    �� TextAlignment$ Center=�6�   $��MV Boli)�6�   ���	#FFC25A1F6�   �� 5,      $
��Left=�6    $��53,40,-8.8,0q�6;   $
��Wrap=�6Q   $��Detecting rocket hits��6e   $	��Top=�6�   $��Segoe Print)�6�   $��50��6�   $	��127��6�   $��14(�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   ���	#FFCD701E$��2��6  �� 5-      $
��Left=�6   $	��Top=�69   $i��cC:\WPF_Detecting_rocket_hits\WPF_Detecting_rocket_hits\WPF_Detecting_rocket_hits\image\logo_2_2.png��6R   $ 0.5,0.5&�6�   $��93��6�   $��	-10,2,0,0q�6�   $��82��6�   $��2��6	   J� OpacityMask 5.      �� 5/       �� EndPoint$ 0.5,1&�62   	 �� 
StartPoint$	 0.5,0&�6C   .��50   "   � 
 � Color$
 Black��6/    � Offset$ 0Q�6=   � 51   "   $
 White��6/   $ 1Q�6=   52      z�54      V� 55      .~�56   "   �� �� 57   "   �� 58   "    �� Angle$ 19.904Q�62   T� 59   "   5:      5<      5=      �� 5@      ���	#FFF3CC84$��1��62   .+�5B      �� $��60��6   ���	#3FDFA65A$��0,1,0,0q�6C   .��5C      �� -   5         ��Name$ reportingBtn��5C   )   $��60��6   $��2��6@      ButtonStyleNew#���   6�   $��Center=�6�   ��6M   �� *	RepBtnCom+{�6k   �� *TheUser.CellCenter+.��5D      ��  �� Orientation$ 
Horizontal=�6%   $��43��6>   $	��204��6J   .+�5E      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$
 Plus=�66   $��30��6B   $��30��6M   $��Center=�6Y   $��5q�6t   �� 5F      $��Add Reporting��6(   $��22(�6=   $��Center=�6K   $
��20 0q�6f   5G      5H      5I      �� 5K      $��60��6   ���	#3FDFA65A$��0,1,0,0q�6C   .��5L      �� -   5        $ 
fallingBtn��5L   )   $��60��6   $��Center=�6>   $��3��6\   #���   6�   $��Center=�6�   ��6i   �� *
FallBtnCom+{�6�   �� *CellCenter.Analyst+.��5M      �� $ 
Horizontal=�6%   .+�5N        $ 
PlusCircle=�66   $��30��6H   $��30��6S   $��Center=�6_   $��5q�6z   �� 5O      $��Add Falling��6(   $��22(�6;   $��Center=�6I   $
��20 0q�6d   5P      5Q      5S      �� 5U      $��60��6   ���	#3FDFA65A$��0,1,0,0q�6C   .��5V      �� -   5        $ 	searchBtn��5V   )   $��60��6   $��Center=�6<   $��4��6Z   #���   6�   $��Center=�6�   ��6g   �� *
MapsBtnCom+{�6�   �� *CellCenter.Analyst+.��5W      �� $ 
Horizontal=�6%   .+�5X        $	 Map=�66   $��30��6A   $��30��6L   $��Center=�6X   $��5q�6s   �� 5Y      $��Search & maps��6(   $��22(�6A   $��Center=�6O   $
��20 0q�6j   5Z      5[      5\      �� 5]      $��60��6    ���	#3FDFA65A$��0,1,0,0q�6D   .��5^      �� -   5        $ 	analysBtn��5^   )   $��60��6   $��Center=�6=   $��5��6Z   #���   6�   $��Center=�6�   ��6h   �� *AnalysisBtnCom+{�6�   �� *CellCenter.Analyst+.��5_      �� $ 
Horizontal=�6%   .+�5`        $ Information=�66   $��30��6I   $��30��6T   $��Center=�6`   $��5q�6{   �� 5a      $��Analysis��6(   $��22(�68   $��Center=�6F   $
��20 0q�6a   5b      5c      5e      �� 5f      $��60��6    $��0,0,0,0q�6,   ���	#7FDFA65A$��0,3,0,1q�6U   .��5g      �� -   5        $��60��5g      $��6��6)   $��Center=�66   #���   6k   $��Center=�6�   .��5i      �� $ 
Horizontal=�6%   .+�5j        $ Logout=�66   $��25��6D   $��25��6O   $��Center=�6[   $��5q�6v   �� 5k      $��logout��6(   $��20(�66   $��Center=�6D   $
��20 0q�6_   5l      5m      5o      5r      5t      � 5v   
   $��1��6   
�������$��0.4,0,-0.4,-0.4q�64   $��1��6M   $��1��6^   .+�5x      �� -   5         ��Name$ shell��5x      
�������.��5y      � .+�5z      �� -   5         ��Name$ 
welcomeTxt��5z       $��36(�64   $��
Wide Latin)�6X   $��welcome��6q   $��Center=�6�   ��6B   Z� 6�   5{      5|      5}      5      5�      