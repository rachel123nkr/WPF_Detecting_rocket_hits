   M S B A M L   `   `   `  ����T  PWPF_Detecting_rocket_hits, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PL.ViewPL.View  5   	       PL.View.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:PL.View     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Login��5	   	   $	��500��6   $	��350��6$    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   $��Segoe UI Emoji)�5   	    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $e _pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml?�6%   �� 5      $v ppack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.orange.xaml?�6%   �� 5      $u opack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Indigo.xaml?�6%   %    5      .��5      � .+�5   
   �� $	��240��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFDD9B42��6#   � 5      $ 	#FFF79208��6#   	 � Offset$	 1Q�65   � 5      $ 	#FFF1972C��6#   $	 0.546Q�65   5       5"      )  #MaterialDesignThemes.Wpf.DialogHost  5$   
   -   5        
  Name$
 	dialogBox��5$   $      IsOpen .     DialogContent 5%      �� 5&      $��15q�6    �� Orientation$ Vertical=�6)   .+�5'      �� -   5         ��Name$ TextInDialog��5'       $��14(�66   $��30q�6D   6R   �� 5(      $��OK��6   $��16(�6*      CloseDialogCommand#��Z 68   6|   5)      5+      � 51   
   $
��Left=�6   $��Bottom=�6*   $��	35,0,0,40q�6E   $	��300��6X   $	��280��6f   
�������.+�52      �� $	��280��6   $��0,0,0,-5q�6%   
�������.@�53      �� $��LOGIN��6   $��Center=�6?   $	��Top=�6\   
�������$��18(�6�   $	��138��6�   $��37��6�   $��0,-2,0.4,-3q�6�   ��6)   Z� .��54      � $��0,10,0,0q�6   .+�55      �� $��Center=�6%   $��15q�6@   .+�56      �� -   5         ��Name$ email_login��56   &   $
��0,10q�6;   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	USER NAME��6I    %  !MaterialDesignFloatingHintTextBox#��[  6t   $��Champagne & Limousines)�6�   $��18(�6�   G� 57      -   5         G�Name$ password_login��57   *   $
��0,10q�6B   $ PASSWORD��6P    ) %MaterialDesignFloatingHintPasswordBox#��[ 6z   $��Champagne & Limousines)�6�   $��18(�6�   �� 58      -   5         ��Name$ LOGIN��58   %   $	��150��64   $��Center=�6@   $��Bottom=�6]   $��LOGIN��6x   6�   59      5:      5;      �� 5<      $��SIGN UP��6   $��Center=�6+   $	��Top=�6H   
�������$��18(�6r   
�������$	��138��6�   $��32��6�   $��0.4,-2,0,-6q�6�   .��5=      � .+�5>      �� $��Center=�6%   $��15q�6@   .+�5?      �� -   5        $ email_submit��5?   &   $
��0,10q�6<   $ 	USER NAME��6J   #��[  6u   $��Champagne & Limousines)�6�   $��18(�6�   G� 5@      -   5        $ password_submit��5@   *   $
��0,10q�6C   $ PASSWORD��6Q   #��[ 6{   $��Champagne & Limousines)�6�   $��18(�6�   �� 5A      $	��0,5q�6+   $ PASSWORD��68   $��Champagne & Limousines)�6c   $��18(�6�   .@�5B   "   �� -   5         ��Name$ call_center��5B   +   $��Call Center��6@   $	��0,5q�6V   �� 5C   "   -	   5        $ analyst��5C   +   $��analyst��6<   $	��0,5q�6N   5D      �� 5E      -
   5        $ SIGN_UP��5E   %   $	��150��66   $��Center=�6B   $��Bottom=�6_   $��SIGN UP��6z   6�   5F      5H      5J      5K      5L      � 5M   
   -   5         �Name$
 logo��5M      $��100,25,59,355.4q�6   $��0��67   .+�5P      �� $
��Left=�6   $��	21,-5,0,0q�64   $
��Wrap=�6G   $
��HITS��6[   $	��Top=�6g   $��58��6   $	��144��6�   $��36(�6�    �� TextAlignment$ Center=�6�   $��MV Boli)�6�   
�������$��2��6�   �� 5Q      $
��Left=�6   $��53,40,-8.8,0q�63   $
��Wrap=�6I   $��Detecting rocket hits��6]   $	��Top=�6z   $��Segoe Print)�6�   $��50��6�   $	��127��6�   $��14(�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   
�������$��2��6  �� 5S      $
��Left=�6   $	��Top=�61   $k��eC:\WPF_Detecting_rocket_hits\WPF_Detecting_rocket_hits\WPF_Detecting_rocket_hits\image\logo_white.png��6J   $ 0.5,0.5&�6�   $��93��6�   $��	-10,2,0,0q�6�   $��82��6�    J� OpacityMask 5T      �� 5U      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5V      � $ Black��6'   $	 0Q�65   � 5W      $ White��6'   $	 1Q�65   5X      z�5Z      V� 5[      .~�5\      �� �� 5]      �� 5^       �� Angle$ 19.904Q�6*   T� 5_      5`      5b      5d      5f      5g      