   M S B A M L   `   `   `  ����T  PWPF_Detecting_rocket_hits, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:WPF_Detecting_rocket_hitsWPF_Detecting_rocket_hits  5      #    WPF_Detecting_rocket_hits.App   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      9local'clr-namespace:WPF_Detecting_rocket_hits     5        �� 	Resources  5         BackgroundColorLight �� Color  BackgroundColorNormal  BackgroundColorDark  ForegroundColorDark  ForegroundColorLight  ButonGradient �� RelativeTransform �� CenterY �� CenterX �� CenterY �� CenterX �� Angle �� CenterY	 �� CenterX
 � Color � Offset  ButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius F�Name �� Stretch �� EndPoint � MappingMode �� 
StartPoint ��Name �� Triggers P� Property P� Value �� 
TargetName  ButtonStyleNew  ButtonOrangeStyle 	 TextBlockStyle 
 BackgroundGradient��%  &	        &	 #     &	 A     &	 d     &	 �     &	 �     &	 �    7  7  &	 )    7  &	 �
    7  &		 �    7  '�� g    &	
     �� 5   
   $ 	#FFC8C8C8��67   �� 5	   
   $
 Gray��68   �� 5
   
   $ 	#FF5A5A5A��66   �� 5   
   $ 	#FFC25A1F��66   �� 5   
   $ 	#FFE5AC43��67   �� 5   
    5      V� 5      .~�5      �� $	 0.5Q�6%   $	 0.5Q�63   �� 5      $	 0.5Q�6$   $	 0.5Q�62   �� 5      $ 90Q�6&   $	 0.5Q�61   $		 0.5Q�6?   T� 5      5      .��5      � $
 	#FFB9811A��6   $ 0Q�6-   � 5      $
 	#FFE5AC43��6   $	 0.6Q�6-   5      �� 5   
   " ��6$   .�5      ��  � ��$ Center=�64   �� 5       � ��$ 28(�6)   66   �� 5       � ��$$ Tw Cen MT Condensed Extra Bold)�6+   6T   �� 5       � ��8   6Z   �� 5        � ��8  6[   �� 5!       � ��$ 5q�6'   63   �� 5#       � �� 5$      �� 5%      " ��6&   .R�5&      �� $ 10��6!   ���	#FF9F9696���	#0C000000._�5'      � .+�5(   "   F� $ PathIcon��6'   $��15��69   $��25��6D   $
 Fill=�6P   $
��Left=�6_   $��17,0,0,0q�6z   4�������<R���=�x�O���Tn5����<R��5)   &   �� 5*   *   $ 0.5,1&�6>   $ RelativeToBoundingBox=�6O   $ 0.5,0&�6s   .��5+   .   � $
 	#FFD1CBC5��6;   $ 0.532Q�6M   � 5,   .   $
 	#FFC35F26��6;   $ 0.228Q�6M   � 5-   .   $
 	#FFC35F26��6;   $ 0.873Q�6M   5.   +   50   #   �� 51   "   $ MyContentPresenter��63   #��z��6O   $��Center=�6s   $��Center=�6�   $��0,0,0,0q�6�   52      53       55      P� 56       �@J�IsMouseOver . . �57   "   ��  � �� �#E594006?   �� 58   "    � ��
 �����6?   �� 59   "   $ PathIcon��6)    � ��
 �   �6O   5:      P� 5<       � �� . . �5=   "   ��  � ��
 � E��6?   �� 5>   "    � ��
 �����6?   5?      5A      5C      5E      �� 5G   
   " ��6'   .�5H      ��  � ��$ Center=�64   �� 5I       � ��$ 22(�6)   66   �� 5J       � ��$$ Tw Cen MT Condensed Extra Bold)�6+   6T   �� 5K       � ��8   6Z   �� 5L       � ��$ 10q�6'   64   �� 5N       � �� 5O      �� 5P      " ��6&   .R�5Q      �� $ 10��6!   ���	#FF9F9696._�5R      � .+�5S   "   �� $ MyContentPresenter��63   #��z��6O   $��Center=�6s   $��Center=�6�   $��0,0,0,0q�6�   5T      5U       5W      P� 5X       �@J�IsMouseOver . . �5Y   "   ��  � �� �#E594006?   �� 5Z   "    � ��
 �����6?   5[      P� 5]       � {� .  . �5^   "   ��  � ��
 �   �6?   �� 5_   "    � �� �	#7FCBA86A6?   5`      P� 5b       � �� . . �5c   "   ��  � ��
 � E��6?   �� 5d   "    � ��
 �����6?   5e      5g      5i      5k      �� 5n   
   " ��6*   .�5o      ��  � ��$ Center=�64   �� 5p       � ��$ 20(�6)   66   �� 5q       � ��$$ Tw Cen MT Condensed Extra Bold)�6+   6T   �� 5r       � ��8   6Z   �� 5s       � �� �	#FFF3CC846?   �� 5t       � ��$ 5q�6'   63   �� 5v       � �� 5w      �� 5x      " ��6&   .R�5y      �� $ 5��6!   ���	#FF9F9696���	#FFFF9600._�5z      � .+�5{   "   �� $ MyContentPresenter��63   #��z��6O   $��Center=�6s   $��Center=�6�   $��0,0,0,0q�6�   5|      5}       5      P� 5�       � {� .  . �5�   "   ��  � ��
 �   �6?   �� 5�   "    � ��
 �   �6?   5�      P� 5�       �@J�IsMouseOver . . �5�   "   ��  � �� �#E594006?   �� 5�   "    � ��
 �����6?   5�      P� 5�       � �� . . �5�   "   ��  � ��
 � E��6?   �� 5�   "    � ��
 �����6?   5�      5�      5�      5�      �� 5�   
   " ��6(   .�5�      ��  � ��$ Center=�64   �� 5�       � ��$ 20(�6)   66   �� 5�       � ��$% Tw Cen MT Condensed Exstra Bold)�6+   6U   �� 5�       � ��8   6Z   5�      �� 5�   
   " ��6   .�5�      ��  � ��$ Center=�64   �� 5�       � ��$ Tw Cen MT Condensed)�6+   6I   �� 5�       � ��
 �   �6;   5�      �� 5�   
    5�      V� 5�      .~�5�      �� $	 0.5Q�6%   $	 0.5Q�63   �� 5�      $	 0.5Q�6$   $	 0.5Q�62   �� 5�      $	 140Q�6&   $	 0.5Q�62   $		 0.5Q�6@   T� 5�      5�      .��5�      � $
 	#FFC8C8C8��6   $ 0Q�6-   � 5�      $

 Gray��6   $	 0.6Q�6(   � 5�      $
 	#FF505050��6   $ 1Q�6-   5�      5�      5�      