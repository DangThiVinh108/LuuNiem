   M S B A M L   `   `   `  ����B  >LuuNiem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LuuNiemLuuNiem  5   	       LuuNiem.Users   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:LuuNiem     5   	     � Title$  Users��5
   	   $	��570��6   $
��1000��6$    � WindowStartupLocation$ CenterScreen=�61    � 
ResizeMode$ NoResize=�6V   .��5      � $��10q�6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��20 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       $
��Auto �6   �� 5!      $
��Auto �6   �� 5"      $��* �6   .+�5%   
   �� $��Mã nhân viên:��6   $��1��6)   $��0��66   �� 5&   
   $��Tên nhân viên:��6   $��2��6)   $��0��66   �� 5'   
   $��Tên đăng nhập:��6   $��3��6)   $��0��66   �� 5(   
   $��Mật khẩu:��6   $��4��6$   $��0��61   �� 5)   
   $��Số điện thoại:��6   $��5��6*   $��0��67   �� 5*   
   $��Email:��6   $��6��6"   $��0��6/   �� 5+   
   $��Ngày sinh:��6   $��7��6&   $��0��63   �� 5,   
   $��Địa chỉ:��6   $��8��6$   $��0��61   �� 5-   
   $��Trạng thái:��6   $��9��6'   $��0��64   �� 5.   
   $��Phân quyền:��6   $��10��6'   $��0��65   �� 5/   
   $��	Mô tả:��6   $��11��6"   $��0��60   �� 50   
   -   5         ��Name$ 	txbUserID��50   $   ${�False��6   $��1��67   $��1��6D   $	��250��6T   ��51      �� *SelectedItem.UserID+ �� ElementName$ dtgrUser���� 52   
   -   5        $ txtFullName��52      $��2��6'   $��1��64   $	��250��6D   ��53      �� *SelectedItem.FullName+$ dtgrUser�� �� Mode$ OneWay=��� 54   
   -   5        $ txtUserName��54      $��3��6'   $��1��64   $	��250��6D   ��55      �� *SelectedItem.UserName+$ dtgrUser��$ OneWay=��� 56   
   -   5        $ txtPassword��56      $��4��6'   $��1��64   $	��250��6D   ��57      �� *SelectedItem.Password+$ dtgrUser��$ OneWay=��� 58   
   -   5        $ txtPhone��58      $��5��6$   $��1��61   $	��250��6A   ��59      �� *SelectedItem.Phone+$ dtgrUser��$ OneWay=��� 5:   
   -   5        $ txtEmail��5:      $��6��6$   $��1��61   $	��250��6A   ��5;      �� *SelectedItem.Email+$ dtgrUser��$ OneWay=�(  "System.Windows.Controls.DatePicker  5<   
   -   5          Name$ 
dpBirthday��5<      $��7��6)   $��1��66   $	��250��6F   	   Text	 5=      �� *SelectedItem.Birthday+$ dtgrUser��$ OneWay=��� 5>   
   -   5        $ 
txtAddress��5>      $��8��6&   $��1��63   $	��250��6C   ��5?      �� *SelectedItem.Address+$ dtgrUser��$ OneWay=��� 5@   
   -	   5        
 ��Name$
 cbStatus��5@      $��9��6%   $��1��62   $	��250��6C    d� 	IsChecked 5A      �� *SelectedItem.Status+$ dtgrUser��$ OneWay=��� 5B   
   -
   5        $ txtPermissions��5B      $��10��6*   $��1��68   $	��250��6H   ��5C      �� *SelectedItem.Permissions+$ dtgrUser��$ OneWay=��� 5D   
   -   5        $ txtDescription��5D      $��11��6*   $��1��68    �� AcceptsReturn$
 True��5E      $	��150��6'   $	��250��64   ��5F      �� *SelectedItem.Description+$ dtgrUser��$ OneWay=�&   System.Windows.Controls.DataGrid  5G   
   -   5          Name$ dtgrUser��5G      $��2��6%   $��3��62    �� IsTextSearchEnabled$
 True��6B   $
��auto��5H      $
��auto��6    $��10��6.      AutoGenerateColumns$ False��6@      
IsReadOnly$
 True��6\      Columns 5I      0  *System.Windows.Controls.DataGridTextColumn  5J      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã nhân viên��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *UserID+  5K      $ Tên nhân viên��6%    6<   �� *
FullName+  5L      $ Tên đăng nhập��6%    6<   �� *
UserName+  5M      $ Mật khẩu��6%    67   �� *
Password+  5N      $ Số điện thoại��6%    6<   �� *Phone+  5O      $ Email��6%    64   �� *Email+  5P      $ 
Ngày sinh��6%    68   �� *
Birthday+  5Q      $ Địa chỉ��6%    66   �� *	Address+4  .System.Windows.Controls.DataGridCheckBoxColumn  5R      $ Trạng thái��6)    6=   �� *Status+  5S      $ Phân quyền��6)    6=   �� *Permissions+  5T      $ Mô tả��6%    64   �� *Description+5W      � 5Y   
   $��Center=�6   $��12��61   $��2��6?   .+�5Z      �� -   5         ��Name$ btnNew��5Z      $	��100��6'   $��20q�63   .��6T   Thêm6Z   �� 5\      -   5        $ 	btnUpdate��5\      $	��100��6(   $��20q�64   .��6X   Sửa6]   �� 5^      -   5        $ 	btnDelete��5^      $	��100��6(   $��20q�64   .��6X   Xóa6]   5_      5`      5b      