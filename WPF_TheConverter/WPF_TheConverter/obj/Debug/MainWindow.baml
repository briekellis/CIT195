   M S B A M L   `   `   `  ����K  GWPF_TheConverter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WPF_TheConverterWPF_TheConverter  5   	   !    WPF_TheConverter.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WPF_TheConverter     5   	     � Title$  The Converter��5   	   $	��450��6   $	��800��6,   .��5	      � ���	#FF4D4A4A � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��5      $��0��5      $
��Feet��5      $��Right=�5      $��Center=�5      $��16(�5      $
��Bold"�5      $��PT Serif)�5      
������5      �� 5   
   -   5         ��Name$ Textbox_Feet��5      $��0��5      $��1��5       $	��100��5!      $��30��5"      $
��Left=�5#      �� 5$   
   $��1��5%      $��0��5&      $��Meters��5'      $��Right=�5(      $��Center=�5)      $��16(�5*      $
��Bold"�5+      $��PT Serif)�5,      
������5-      �� 5.   
   -   5        $ Textbox_Meters��5/      $��1��50      $��1��51      $	��100��52      $��30��53      $
��Left=�54      �� 55   
   -   5         ��Name$ Button_FeetToMeters��56      $��Feet > Meters��57      $��2��58      $��0��59      $	��100��5:      $��30��5;      5<      �� 5=   
   -   5        $ Button_MetersToFeet��5>      $��Meters > Feet��5?      $��2��5@      $��0��5A      $	��100��5B      $��30��5C      $	��Top=�5D      5E      �� 5F   
   -   5        $ Button_Reset��5G      $��Reset��5H      $��2��5I      $��0��5J      $	��100��5K      $��30��5L      $��Bottom=�5M      6(   5N      5O      