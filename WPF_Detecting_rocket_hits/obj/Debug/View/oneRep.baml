   M S B A M L   `   `   `  ����=  9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE  5      T PWPF_Detecting_rocket_hits, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PL.ViewPL.View 5         PL.View.oneRep   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +BEclr-namespace:BE;assembly=BE     5      'localclr-namespace:PL.View     5        � 	Resources  5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $e _pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml?�6%   �� 5      $v ppack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.orange.xaml?�6%   �� 5      $u opack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Indigo.xaml?�6%   %    5      .��5      � ���	#7FEACCAB � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��108* �6   �� 5      $
��359* �6   .+�5!   
   �� -   5         ��Name$ nameTxt��5!      $��1��6v   $��0��6�   $��Stretch=�6�   $
��10,7q�6�   ��6&   �� *NameReporter+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���6�   Z� �� 5"   
   -   5        $ dateRep��5"      $��1��6p   $��1��6�   $��Stretch=�6�   $
��10,7q�6�   ��6%   �� *	DateRep+$ TwoWay=�$ PropertyChanged=���6�   Z� �� 5#   
   -   5        $ 	streetTxt��5#      $��1��6r   $��2��6�   $��Stretch=�6�   $
��10,7q�6�   ��6'   �� *	Address+$ TwoWay=�$ PropertyChanged=���6�   Z� �� 5$   
   -   5        $ cityTxt��5$      $��1��6m   $��3��6}   $��Stretch=�6�   $
��10,7q�6�   ��6%   �� *City+$ TwoWay=�$ PropertyChanged=���6�   Z� �� 5%   
   -   5        $ boomsTxt��5%      $��1��6p   $��4��6�   $��Stretch=�6�   $
��10,7q�6�   ��6&   �� *BoomsN+$ TwoWay=�$ PropertyChanged=���6�   Z� �� 5&   
   -   5        $ intensityTxt��5&      $��1��6z   $��5��6�   $��Stretch=�6�   ��6+   �� *	Intensity+$ TwoWay=�$ PropertyChanged=�6�   �� 5(   
   $
��Wrap=�6   $��name:��6*   $��0��69   $��0��6J   $��16(�6W   $��Center=�6e   �� 5)   
   $
��Wrap=�6   $��time:��6)   $��0��67   $��1��6H   $��16(�6U   $��Center=�6c   �� 5*   
   $
��Wrap=�6   $��street:��6)   $��0��68   $��2��6I   $��16(�6V   $��Center=�6d   �� 5+   
   $
��Wrap=�6   $��city:��6)   $��0��66   $��3��6F   $��16(�6S   $��Center=�6a   �� 5,   
   $
��Wrap=�6   $��num of hits:��6)   $��0��6=   $��4��6N   $��16(�6[   $��Center=�6i   �� 5-   
   $
��Wrap=�6   $��
intensity:��6)   $��0��6;   $��5��6K   $��16(�6X   $��Center=�6f   50      51      