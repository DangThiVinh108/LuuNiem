   M S B A M L   `   `   `  ����B  >LuuNiem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LuuNiemLuuNiem  5   	       LuuNiem.Customers   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:LuuNiem     5   	     � Title$  	Customers��5   	   $	��410��6   $
��1000��6(    � WindowStartupLocation$ CenterScreen=�65    � 
ResizeMode$ NoResize=�6Z   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��20 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Mã khách hàng:��6   $��1��6*   $��0��67   �� 5   
   $��Tên khách hàng:��6   $��2��6*   $��0��67   �� 5   
   $��Địa chỉ:��6   $��3��6$   $��0��61   �� 5   
   $��Số điện thoại:��6   $��4��6*   $��0��67   �� 5    
   $��Email:��6   $��5��6"   $��0��6/   �� 5!   
   $��	Mô tả:��6   $��6��6"   $��0��6/   �� 5#   
   -   5         ��Name$ txbCustomerID��5#   $   ${�False��6   $��1��6;   $��1��6H   $	��250��6X   ��5$      �� *SelectedItem.CustomerID+ �� ElementName$ dtgrCustomer���� 5%   
   -   5        $ txtFullName��5%      $��2��6'   $��1��64   $	��250��6D   ��5&      �� *SelectedItem.FullName+$ dtgrCustomer�� �� Mode$ OneWay=��� 5'   
   -   5        $ 
txtAddress��5'      $��3��6&   $��1��63   $	��250��6C   ��5(      �� *SelectedItem.Address+$ dtgrCustomer��$ OneWay=��� 5)   
   -   5        $ txtPhone��5)      $��4��6$   $��1��61   $	��250��6A   ��5*      �� *SelectedItem.Phone+$ dtgrCustomer��$ OneWay=��� 5+   
   -   5        $ txtEmail��5+      $��5��6$   $��1��61   $	��250��6A   ��5,      �� *SelectedItem.Email+$ dtgrCustomer��$ OneWay=��� 5-   
   -   5        $ txtDescription��5-      $��6��6*   $��1��67    �� AcceptsReturn$
 True��5.      $	��150��6'   $	��250��64   ��5/      �� *SelectedItem.Description+$ dtgrCustomer��$ OneWay=�&   System.Windows.Controls.DataGrid  50   
   -   5        	  Name$	 dtgrCustomer��50      $��2��6)   $��3��66   
 �� IsTextSearchEnabled$

 True��6F   $
��auto��51      $
��auto��6    $��5��6.      AutoGenerateColumns$ False��6?      
IsReadOnly$
 True��6[      Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã khách hàng��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *
CustomerID+  54      $ Tên khách hàng��6%    6=   �� *
FullName+  55      $ Địa chỉ��6%    66   �� *	Address+  56      $ Số điện thoại��6%    6<   �� *Phone+  57      $ Email��6%    64   �� *Email+  58      $ Mô tả��6%    64   �� *Description+5;      � 5<   
   $��Center=�6   $��7��61   $��2��6>   .+�5=      �� -   5         ��Name$ btnNew��5=      $	��100��6&   $��20q�62   .��6S   Thêm6Y   �� 5>      -	   5        $ 	btnUpdate��5>      $	��100��6)   $��20q�65   .��6Y   Sửa6^   �� 5?      -
   5        $ 	btnDelete��5?      $	��100��6)   $��20q�65   .��6Y   Xóa6^   5@      5A      5B      