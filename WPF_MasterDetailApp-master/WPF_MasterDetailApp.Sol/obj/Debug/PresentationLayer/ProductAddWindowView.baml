   M S B A M L   `   `   `  ����N  JWPF_MasterDetailApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:WPF_MasterDetailApp.PresentationLayer%WPF_MasterDetailApp.PresentationLayer  5   	   .    (WPF_MasterDetailApp.ProductAddWindowView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:WPF_MasterDetailApp.PresentationLayer     5   	   -   5          �Name$  
ListWindow��5   	    � Title$ Oak Laboratories��5   	   $	��500��5	   	   $	��600��5
   	   ���	#FF121419 � 
ResizeMode$ NoResize=�5   	    � WindowStyle$ SingleBorderWindow=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         HeaderStyle �� 
TargetType �� Property �� Value  SubHeaderStyle  DetailLabelStyle  RadioButtonStyle  DetailTextBoxStyle  MasterTextBoxStyle  ButtonStyle?   9WPF_MasterDetailApp.PresentationLayer.NullToDateConverter  DateConverter��%p  &	        &	 �     &	     &	 �    &	     &	     &	 0    &	     �� 5   
   " ��6$   .�5      ��  � ��
 ��� �6+   �� 5       � ��$ 24(�6)   �� 5       � ��$
 Bold"�6+   5      �� 5   
   " ��6'   .�5      ��  � ��
 ��� �6+   �� 5       � ��$ 16(�6)   5      �� 5   
   " ��6)   .�5      ��  � ��
 ��� �6+   �� 5       � ��$ 12(�6)   �� 5       � ��$
 Bold"�6+   5      �� 5   
   " 	�6)   .�5      ��  � ��
 ��� �6+   �� 5        � ��$ 12(�6)   5!      �� 5"   
   " ��6+   .�5#      ��  � ��$	 120��6&   �� 5$       � ��$ 20��6'   �� 5%       � ��
 ��� �6+   �� 5&       � ��$ 12(�6)   �� 5'       � ��$ Center=�69   �� 5(       � ��$ 0q�60   5)      �� 5*   
   " ��6+   .�5+      ��  � ��
 ��  �6+   �� 5,       � ��
 �����6+   �� 5-       � ��$ 12(�6)   �� 5.       � ��$ 0q�60   �� 5/       � ��$ 0q�6(   �� 50       � ��$ 0q�6'   �� 51       �@��
IsReadOnly . 6+   52      �� 53   
   " ��6$   .�54      ��  � ��
 ��� �6+   �� 55       � ��
 �����6+   �� 56       � ��$	 100��6&   �� 57       � ��$ 40��6'   �� 58       � ��$ 20(�6)   59        5:   
   6$   5;      .��5<      � .+�5=   
   �� $��1��5>      	 �� Orientation$	 Vertical=�5?      .+�5@      �� .+�5A      �� #��[  5B      $��Center=�5C      $��Troglodyte Talent Agency��5D      �� 5E      $��0,0,0,0q�5F      $��0,0,0,0q�5G      $��12(�5H      $��Center=�5I      #��[ 5K      ��5J      �� *Company.Address+5K      �� 5L      $��0,0,0,0q�5M      $��0,0,0,0q�5N      $��12(�5O      $��Center=�5P      #��[ 5R      ��5Q      �� *Company.City+5R      5S      � 5T      
 � ColumnDefinitions
 5U      �� 5V      $��* �6'   �� 5W      $��2* �6'   .+�5Y      �� $	 Vertical=�5Z      .+�5[      �� -   5         ��Name$ Image_ProductImage��5]      $��0��5\      $	��200��5^      $��20q�5_      �� 5`      -   5         ��Name$ Button_AddImage��5a      $��10,10,10,10q�5b      $��Center=�5c      $	��130��5d      $��	Add Image��5e      #��[ 5f      5g      5h      �� 5j      $��1��5k      $��10,10,10,10q�5l      $	 Vertical=�5m      .+�5n      �� $	 
Horizontal=�6!   .+�5o      �� $��First Name: ��6    #��[ 67   �� 5p      -   5         ��Name$ TextBox_FirstName��5p   "   #��[ 6=   5q      �� 5r      $	 
Horizontal=�6!   .+�5s      �� $��Last Name: ��6    #��[ 66   �� 5t      -   5        $ TextBox_LastName��5t   "   #��[ 6<   5u      �� 5v      $	 
Horizontal=�6!   .+�5w      �� $��Age: ��6    #��[ 60   �� 5x      -   5        $ TextBox_Age��5x   "   #��[ 67   5y      �� 5z      $	 
Horizontal=�6!   .+�5{      �� $��Gender: ��6    #��[ 63   �� 5|      -   5        $ TextBox_Gender��5|   "   #��[ 6:   5}      �� 5~      $	 
Horizontal=�6!   .+�5      �� $��Hire Date: ��6    #��[ 66   �� 5�      -   5        $ TextBox_HireDate��5�   "   #��[ 6<   5�      �� 5�      $	 
Horizontal=�6!   .+�5�      �� $��Average Annual Gross: ��6    #��[ 6A   �� 5�      -	   5        $ TextBox_AnnualGross��5�   "   #��[ 6?   5�      �� 5�      $	 Vertical=�6!   .+�5�      �� $��Description: ��6    #��[ 68   �� 5�      -
   5        $ TextBox_Description��5�      $
��Left=�5�      $	��300��5�      $	��120��5�       �� TextWrapping$
 Wrap=�5�       �� AcceptsReturn . $	��Top=�5�      " �� VerticalScrollBarVisibility$ Visible=�5�      #��[ 5�      5�      5�      5�      �� 5�      $	 
Horizontal=�5�      $��Right=�5�      .+�5�      �� -   5        $ Button_Save��5�      $��10,10,10,10q�5�      $��Center=�5�      $��20(�5�      $
��Save��5�      #��[ 5�      5�      �� 5�      -   5        $ Button_Cancel��5�      $��10,10,20,10q�5�      $��Right=�5�      $��Center=�5�      $��20(�5�      $��Cancel��5�      #��[ 5�      5�      5�      5�      5�      5�      