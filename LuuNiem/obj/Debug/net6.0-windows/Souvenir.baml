   M S B A M L   `   `   `  ����B  >LuuNiem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LuuNiemLuuNiem  5   	       LuuNiem.Souvenir   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:LuuNiem     5   	     � Title$  Souvenir��5   	   $	��580��6   $
��1000��6'    � WindowStartupLocation$ CenterScreen=�64    � 
ResizeMode$ NoResize=�6Y   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��20 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��
Mã hàng:��6   $��1��6$   $��0��61   �� 5   
   $��Tên hàng:��6   $��2��6$   $��0��61   �� 5    
   $��	Mô tả:��6   $��4��6!   $��0��6.   �� 5!   
   $��
Giá bán:��6   $��5��6#   $��0��60   �� 5"   
   $��Nhóm hàng:��6   $��6��6&   $��0��63   �� 5$   
   -   5         ��Name$ txbSouvenirID��5$   $   ${�False��6   $��1��6;   $��1��6H   $	��250��6X   ��5%      �� *SelectedItem.SouvenirID+ �� ElementName$ dtgrSouvenir���� 5&   
   -   5        $ txtSouvenirName��5&      $��2��6+   $��1��68   $	��250��6H   ��5'      �� *SelectedItem.SouvenirName+$ dtgrSouvenir�� �� Mode$ OneWay=��� 5(   
   -   5         ��Name$ imgSvn��5(      $��3��6    $��1��6-   $	��200��6=   $��/Images/BanHang.png��5)      �� 5*   
   -   5        $ txtDescription��5*      $��4��6*   $��1��67   	 �� AcceptsReturn$
	 True��5+      $	��150��6'   $	��250��64   ��5,      �� *SelectedItem.Description+$ dtgrSouvenir��$ OneWay=��� 5-   
   -   5        $ txtPrice��5-      $��5��6$   $��1��61   $	��250��6A   ��5/      �� *SelectedItem.Price+$ dtgrSouvenir��$ OneWay=��� 50   
   -   5        $ 	txtSGroup��50      $��6��51      $��1��6   $	��250��6/   ��52      �� *SelectedItem.SGroup+$ dtgrSouvenir��$ OneWay=�&   System.Windows.Controls.DataGrid  53   
   -   5        
  Name$
 dtgrSouvenir��53      $��2��6)   $��3��66    �� IsTextSearchEnabled$
 True��6F   $
��auto��54      $
��auto��6    $��5��6.      AutoGenerateColumns$ False��6?      
IsReadOnly$
 True��6[      Columns 55      0  *System.Windows.Controls.DataGridTextColumn  56      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Mã Hàng��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *
SouvenirID+  57      $ 
Tên Hàng��6%    67   �� *SouvenirName+  58      $ 	Giá bán��6%    66   �� *Price+  59      $ Mô tả��6%    64   �� *Description+  5:      $ Nhóm��6%    63   �� *SGroup+5<      � 5=   
   $��Center=�6   $��7��61   $��2��6>   .+�5>      �� -   5         ��Name$ btnNew��5>      $	��100��6%   $��20q�61   .��6R   Thêm6X   �� 5?      -	   5        $ 	btnUpdate��5?      $	��100��6(   $��20q�64   .��6X   Sửa6]   �� 5@      -
   5        $ 	btnDelete��5@      $	��100��6(   $��20q�64   .��6X   Xóa6]   5A      5B      5D      