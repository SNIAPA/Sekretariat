   M S B A M L   `   `   `  ����R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel  5   	   F Bdesktop app, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:desktop_appdesktop_app 5   	      desktop_app.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml      5   	   @d2http://schemas.microsoft.com/expression/blend/2008      5   	   Hscm8clr-namespace:System.ComponentModel;assembly=WindowsBase      5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006      5   	   +localclr-namespace:desktop_app      5   	     � Title$  
MainWindow��5	   	   $	��425��5
   	   $	��425��5   	   $	��885��5   	   .��5      �  � ShowGridLines$ False��6    � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $��* �6   6*   .+�5   
   ]� $	��Top=�6   $��0��6)   .+�5      o� $��0��6   $	��Top=�6!   $��Stretch=�69   
�������
�������$��1q�6�   .@�5      m� $
��File��6   
�������$��1q�6=   .@�5      m� $��_Export��6      desktop_app.MainWindow   ExportHotkey � DataContext# Z 61    m� Command 6h   �� *	command+m� 5      $��_Import��6       ImportHotkey# Z 61    6h   �� *	command+5      m� 5      $
��Help��6   
�������$��1q�6=   .@�5      m� -   5         m�Name$ FilterHelpButton��5      $��_Filter��6X   5      m� 5       $��Hotkeys��6   
�������$��1q�6@   .@�5!      m� -   5        # Z 5!      $��Export��6W    m� InputGestureText 6g   �� *InputGestureText+	 �� Mode$	 TwoWay=�6�   m� 5"      -   5        # Z 5"      $��Import��6W    6g   �� *InputGestureText+$	 TwoWay=�6�   m� 5#      -   5        
   FilterResetHotkey# Z
 5#      $��FilterReset��6\    6q   �� *InputGestureText+$	 TwoWay=�6�   m� 5$      -   5           FilterApplyHotkey# Z 5$      $��FilterApply��6\    6q   �� *InputGestureText+$	 TwoWay=�6�   5&      5'      5(      � 5)   
   -   5         �Name$ Popup��5)      $
��Left=�6   $	��Top=�6:   $	��200��6R   $	��200��6^   $��Center=�6k   .��5*      � 
����ح�$��Stretch=�6+   $��Stretch=�6G   .+�5+      �� -   5         ��Name$ 	PopupText��5+      $��Center=�6+   $��Center=�6F   $��Press a key��6c   �� 5,      -   5        $��Bottom=�5,      $��25��64   $
��Done��6@   6_   5-      5.      � 5/   
   $��0,2,0,0q�6   $ False��6    $��1��66    � 	Resources 51         DateTemplate(  "System.Windows.Controls.DatePicker   SelectedDate �� Path  EmploymentDateTemplate  PhotoTemplate  PhotoEditTemplate  DeleteButtonTemplate��%�  &	        &	 F     &	 �     &	 �     &	 ;    �� 52      .R�53         6!   �� $ 	birthDate�54      �� 55      .R�56         6!   �� $ employmentDate�57      �� 58      .R�59      �� $��50��6   ��6'   �� $ photo�6G   5:      �� 5;      .R�5<      �� $��50��6   ��6)   �� $ photo�6G   5=      �� 5>      .R�5?      �� $��Delete��6   $��delete��6.   6A   5@      5A       5B      �� 5C      $
��auto �6    60   �� 5D      $��* �6    6-   .+�5H      �� -	   5         ��Name$ tableControl��5H   &   $��0��6   $
��auto��6<   $	��300��6J   $	��Top=�6Z   $
��Left=�6r   .@�5J      �� $��students��6   .��5L      &   System.Windows.Controls.DataGrid  -
   5        $��student_list_grid��5Q         AutoGenerateColumns$ False��5L      $
��auto��5M      $	��300��5N      $	��700��5O      $
��Left=�5P      $	��Top=�5R         	RowHeight$ 50Q�5S         Columns 5T      0  *System.Windows.Controls.DataGridTextColumn  5V      ,  &System.Windows.Controls.DataGridColumn   Header$ id��61      
IsReadOnly$
 True��6=      CanUserResize$ False��6k      Width5  /System.Windows.Controls.DataGridLengthConverter$	 230 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6O   �� $ id�6�     5W      $ 	firstName��61      MinWidth$ 50Q�6g    6D   �� $ 	firstName�6g     5X      $ 
secondName��61   $ 50Q�6i    6E   �� $ 
secondName�6i     5Y      $ lastName��61   $ 50Q�6e    6C   �� $ lastName�6e     5Z      $ maidensName��61   $ 50Q�6j    6F   �� $ 
maidenName�6j     5[      $ mothersName��61   $ 50Q�6k    6F   �� $ mothersName�6k     5\      $ fathersName��61   $ 50Q�6k    6F   �� $ fathersName�6k     5]      $ gender��61   $ 50Q�6a    6A   �� $ gender�6a     5^      $ pesel��61   $ 50Q�6_    6@   �� $ pesel�6_     5_      $ grade��61   $ 50Q�6_    6@   �� $ grade�6_     5`      $ groups��61   $ 50Q�6B    6P   �� *groups+4  .System.Windows.Controls.DataGridTemplateColumn  5a      $ 	birthDate��65      CellTemplate# [  6H      CellEditingTemplate# [  6u     5b      $ photo��65   # [ 6D   # [ 6r     5c      $ Delete��65   # [ 6E   5g      5h      �� 5j      $��groups��6   .��5l        -   5        $��group_list_grid��5q      $ False��5l      $
��auto��5m      $	��300��5n      $	��700��5o      $
��Left=�5p      $	��Top=�5r      $ 50Q�5s       5t        5v      $ id��61   $
 True��6=   $ False��6k   $	 230 6�    6O   �� $ id�6�     5w      $
 name��61   $ 50Q�6^    6@   �� $
 name�6^   5{      5|      �� 5~      $��teachers��6   .��5�        -   5        $��teacher_list_grid��5�      $ False��5�      $
��auto��5�      $	��300��5�      $	��700��5�      $
��Left=�5�      $	��Top=�5�         CanUserSortColumns$
 True��5�         CanUserDeleteRows$
 True��5�      $ 50Q�5�       5�        5�      $ id��61   $
 True��6=   $ False��6k   $	 230 6�    6O   �� $ id�6�     5�      $ 	firstName��61   $ 50Q�6g    6D   �� $ 	firstName�6g     5�      $ 
secondName��61   $ 50Q�6i    6E   �� $ 
secondName�6i     5�      $ lastName��61   $ 50Q�6e    6C   �� $ lastName�6e     5�      $ maidensName��61   $ 50Q�6j    6F   �� $ 
maidenName�6j     5�      $ mothersName��61   $ 50Q�6k    6F   �� $ mothersName�6k     5�      $ fathersName��61   $ 50Q�6k    6F   �� $ fathersName�6k     5�      $ gender��61   $ 50Q�6a    6A   �� $ gender�6a     5�      $ pesel��61   $ 50Q�6_    6@   �� $ pesel�6_     5�      $ supervisedClasses��61   $ 50Q�6w    6L   �� $ supervisedClasses�6w     5�      $ subjects��61   $ 50Q�6C    6Q   �� $ subjects�  5�      $ jobPosition��61   $ 50Q�6F    6T   �� $ jobPosition�  5�      $ 	workHours��61   $ 50Q�6D    6R   �� $ 	workHours�  5�      $ 	birthDate��65   # [  6I   # [  6v     5�      $ employmentDate��65   # [ 6M   # [ 6�     5�      $ photo��65   # [ 6D   # [ 6r     5�   "   $ Delete��69   # [ 6I   5�      5�      �� 5�      $��	Employees��6   .��5�        -   5        $��employee_list_grid��5�      $ False��5�      $
��auto��5�      $	��300��5�      $	��700��5�      $
��Left=�5�      $	��Top=�5�      $
 True��5�      $
 True��5�      $ 50Q�5�       5�        5�      $ id��61   $
 True��6=   $ False��6k   $	 230 6�    6O   �� $ id�6�     5�      $ 	firstName��61   $ 50Q�6g    6D   �� $ 	firstName�6g     5�      $ 
secondName��61   $ 50Q�6i    6E   �� $ 
secondName�6i     5�      $ lastName��61   $ 50Q�6e    6C   �� $ lastName�6e     5�      $ maidensName��61   $ 50Q�6j    6F   �� $ 
maidenName�6j     5�      $ mothersName��61   $ 50Q�6k    6F   �� $ mothersName�6k     5�      $ fathersName��61   $ 50Q�6k    6F   �� $ fathersName�6k     5�      $ gender��61   $ 50Q�6a    6A   �� $ gender�6a     5�      $ pesel��61   $ 50Q�6_    6@   �� $ pesel�6_     5�      $ jobPosition��61   $ 50Q�6F    6T   �� $ jobPosition�  5�      $ 	workHours��61   $ 50Q�6D    6R   �� $ 	workHours�  5�      $ 	birthDate��65   # [  6I   # [  6v     5�      $ employmentDate��65   # [ 6M   # [ 6�     5�      $ photo��65   # [ 6D   # [ 6r     5�      $ Delete��65   # [ 6E   5�      5�      5�      � 5�      $��1��6   $	��Top=�6    $
��Left=�68   $��30��6S   $	��0,5q�6_   .+�5�      �� $��Filter��6   $��24,0,0,0q�6,   # Z 6?   $	��Top=�6�   $
��Left=�6�   $��25��6�   $��50��6�   ��6{   �� *	command+6�   �� 5�      $��Reset��6   $��	427,0,0,0q�6,   # Z
 6?   $	��Top=�6�   $
��Left=�6�   $��25��6�   $��50��6�   ��6{   �� *	command+6�   �� 5�      -   5         ��Name$ 	filterBox��5�   .   $��	100,0,0,0q�6   $	��Top=�6]   $
��Left=�6u   $��25��6�   $	��300��6�   6�   5�      5�      5�      5�      