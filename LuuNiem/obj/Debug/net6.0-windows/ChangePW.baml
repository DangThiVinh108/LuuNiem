   M S B A M L   `   `   `  ����B  >LuuNiem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LuuNiemLuuNiem  5   	       LuuNiem.ChangePW   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:LuuNiem     5   	   
�������  � Title$  ChangePW��5   	   $	��300��6   $	��450��6'   .��5	      � $��20q�6   $��Center=�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $'��!ĐỔI MẬT KHẨU ĐĂNG NHẬP��6   $��18(�62   $
��Bold"�6@   $��Center=�6R   $��0��6o   $��2��6|   $��0,0,0,20q�6�   �� 5   
   $ ��Mật khẩu hiện tại:��6   $��Center=�6-   $��2��6H   $��0��6U   �� 5   
   $��Mật khẩu mới:��6   $��3��6(   $��0��65   �� 5   
   $%��Xác nhận mật khẩu mới:��6   $��4��61   $��0��6>   �� 5   
   $��Tên người dùng:��6   $��1��6*   $��0��67   $��0,0,10,0q�6G   �� 5   
   -   5         ��Name$ usernameTextBox��5      $��1��6+   $��1��68   $��0,0,0,10q�6H   $	��200��6Z   G� 5   
   -   5         G�Name$ currentPasswordBox��5      $��2��62   $��1��6?   $��0,0,0,10q�6O   $	��200��6a   G� 5    
   -   5        $ newPasswordBox��5       $��3��6.   $��1��6;   $��0,0,0,10q�6K   $	��200��6]   G� 5!   
   -   5        $ confirmPasswordBox��5!      $��4��62   $��1��6?   $��0,0,0,10q�6O   $	��200��6a   �� 5#   
   -   5        $��Đổi mật khẩu��5#      
���2͚�$��5��6d   $��0��6q   $��2��6�   $��0,20,0,0q�6�   $	��120��6�   $��35��6�   $��Center=�6�   �� 5%   
   -   5         ��Name$ resultTextBlock��5%      $�� ��6-   
��� � �$��5��6H   $��0��6U   $��2��6e   $��Center=�6y   $��0,10,0,0q�6�   5&      5'      