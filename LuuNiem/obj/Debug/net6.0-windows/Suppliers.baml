   M S B A M L   `   `   `  ����B  >LuuNiem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LuuNiemLuuNiem  5   	       LuuNiem.Suppliers   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:LuuNiem     5   	     � Title$  	Suppliers��5   	   $	��450��6   $
��1000��6(    � WindowStartupLocation$ CenterScreen=�65    � 
ResizeMode$ NoResize=�6Z   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��20 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Mã NCC:��6   $��1��6"   $��0��6/   �� 5   
   $��	Tên NCC:��6   $��2��6#   $��0��60   �� 5    
   $��Tên liên lạc:��6   $��3��6(   $��0��65   �� 5!   
   $��Địa chỉ:��6   $��4��6#   $��0��60   �� 5"   
   $��Số điện thoại:��6   $��5��6)   $��0��66   �� 5#   
   $��Email:��6   $��6��6!   $��0��6.   �� 5$   
   $��	Mô tả:��6   $��7��6!   $��0��6.   �� 5%   
   -   5         ��Name$ txbSupplierID��5%   $   ${�False��6   $��1��6<   $��1��6I   $	��250��6Y   ��5&      �� *SelectedItem.SupplierID+ �� ElementName$ dtgrSupplier���� 5'   
   -   5        $ txtCompanyName��5'      $��2��6*   $��1��67   $	��250��6G   ��5(      �� *SelectedItem.CompanyName+$ dtgrSupplier�� �� Mode$ OneWay=��� 5)   
   -   5        $ txtContactName��5)      $��3��6*   $��1��67   $	��250��6G   ��5*      �� *SelectedItem.ContactName+$ dtgrSupplier��$ OneWay=��� 5+   
   -   5        $ 
txtAddress��5+      $��4��6&   $��1��63   $	��250��6C   ��5,      �� *SelectedItem.Address+$ dtgrSupplier��$ OneWay=��� 5-   
   -   5        $ txtPhone��5-      $��5��6$   $��1��61   $	��250��6A   ��5.      �� *SelectedItem.Phone+$ dtgrSupplier��$ OneWay=��� 5/   
   -   5        $ txtEmail��5/      $��6��6$   $��1��61   $	��250��6A   ��50      �� *SelectedItem.Email+$ dtgrSupplier��$ OneWay=��� 51   
   -   5        $ txtDescription��51   '    �� AcceptsReturn$
 True��6   $��7��6?   $��1��6L   $	��250��6\   $	��150��6h   ��52      �� *SelectedItem.Description+$ dtgrSupplier��$ OneWay=�&   System.Windows.Controls.DataGrid  53   
   -   5        	  Name$	 dtgrSupplier��53      $��2��6)   $��3��66   
 �� IsTextSearchEnabled$

 True��6F   $
��auto��54      $
��auto��6    $��6��6.      AutoGenerateColumns$ False��6?      
IsReadOnly$
 True��6[      Columns 56      0  *System.Windows.Controls.DataGridTextColumn  57      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã NCC��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *
SupplierID+  58      $ Tên NCC��6%    66   �� *CompanyName+  59      $ Tên liên lạc��6%    6;   �� *ContactName+  5:      $ Địa chỉ��6%    66   �� *	Address+  5;      $ Số điện thoại��6%    6<   �� *Phone+  5<      $ Email��6%    64   �� *Email+  5=      $ Mô tả��6%    64   �� *Description+5?      � 5@   
   $��Center=�6   $��8��61   $��2��6>   .+�5A      �� -	   5         ��Name$ btnNew��5A      $	��100��6%   $��20q�61   .��6S   Thêm6Y   �� 5B      -
   5        $ 	btnUpdate��5B      $	��100��6(   $��20q�64   .��6Y   Sửa6^   �� 5C      -   5        $ 	btnDelete��5C      $	��100��6(   $��20q�64   .��6X   Xóa6]   5D      5E      5F      