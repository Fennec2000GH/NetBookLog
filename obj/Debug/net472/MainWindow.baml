   M S B A M L   `   `   `  ����E  ANetBookLog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:NetBookLog
NetBookLog  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       NetBookLog.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:NetBookLog     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	     � Title$  
NetBookLog��5	   	   $	��600��5
   	   $
��1000��5   	   
����p��.��5      �  � ShowGridLines$
 True��6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $	��200 �6   �� 5      $	��200 �6    � ColumnDefinitions 5   
   �� 5      $	��500 �6   �� 5      $	��500 �6   .+�5   
   �� -   5        $��buttonAddDocument��5      $��Add Document��5      $	��240��5      $	��100��5      $��20 20 10 10q�5      $	��Top=�5      $
��Left=�5      
����·�$��Arial)�5!      $��24(�5"      $��Normal$�5#      $��DemiBold"�5$      5%      �� 5(   
    �� Orientation$ 
Horizontal=�6   $��30��5)      $	��Top=�5*      $
��Left=�5+      $��0��5,      $��1��5-      .+�5.      �� $��Search:��6   $��60��6&   $	��Top=�61   $
��Left=�6I   �� 5/      
���   �$��1q�6)    �� CornerRadius$ 0��6=   $	��200��6N   $��20��6Z   ._�50      �� -   5        $��textBoxSearchBar��50       �� TextWrapping$ NoWrap=�62   
�������.��6^   51      52      53      �� 56   
   $ 
Horizontal=�6   $��1��6.   .+�57      �� $��First��6   $	��120��58      $��
20 10 10 5q�59      
������$��Times)�5;      $��24(�5<      $��Normal$�5=      5>      �� 5@      $��Second��6   $	��120��5A      $��	5 10 5 10q�5B      
������$��Times)�5D      $��24(�5E      $��Normal$�5F      5G      �� 5I      $	��120��6   $��	5 10 5 10q�5J      .��5K      �� .+�5L      �� $��./images/apples.jpg��6   5M      5N      �� 5P      $��40��6   $��10 10 10 10q�5Q      
��� ���$��Times)�5S      $��24(�5T      $��Normal$�5U      .��5V      � .+�5W      �� $��40��6    $��20��6+   69   5X      5Y      5[      �� 5]   
   $ 
Horizontal=�6   $��30��5^      $��Bottom=�5_      $
��Left=�5`      $��2��5a      $��0��5b      .+�5c      �� -   5        $��borderForProgressBar��5c      
�������$��5q�6D   $ 0��6X   ._�5d      � -   5        $��progressBarUpload��5d       � Minimum$ 0Q�5e       � Maximum$	 100Q�5f      	 � Value$	 90Q�5g      $	��240��5h      
���2�2�5i      5j      �� 5k      -   5        $��labelForProgressBarUpload��5k      $��60��5m      $��	10 0 10 0q�5n      $��Arial)�5o      $��12(�5p      $��DemiBold"�5q      ��5l      �� 
 �� Path$
 Value� �� ElementName$ progressBarUpload�� �� StringFormat$ {0:0}%��5r      5s      5t      5u      