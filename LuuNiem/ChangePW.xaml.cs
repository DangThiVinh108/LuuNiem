using System;
using System.Data.SqlClient;
using System.Windows;

namespace LuuNiem
{
    public partial class ChangePW : Window
    {
        private MyDb db = new MyDb();

        public ChangePW()
        {
            InitializeComponent();
        }

        private void ChangePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            // Lấy tên người dùng, mật khẩu hiện tại, mật khẩu mới và xác nhận mật khẩu mới từ các TextBox.
            string username = usernameTextBox.Text;
            string currentPassword = currentPasswordBox.Password;
            string newPassword = newPasswordBox.Password;
            string confirmPassword = confirmPasswordBox.Password;

            // Kiểm tra xem mật khẩu mới và xác nhận mật khẩu mới có khớp nhau không.
            if (newPassword == confirmPassword)
            {
                try
                {
                    // Sử dụng đối tượng kết nối từ lớp MyDb để thực hiện các thao tác truy cập dữ liệu.
                    using (SqlConnection connection = new SqlConnection())
                    {
                        if (connection.State == System.Data.ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        string updateQuery = "UPDATE tblUsers SET Password = @NewPassword WHERE UserName = @Username AND Password = @CurrentPassword";
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            // Tham số hóa truy vấn SQL để tránh SQL injection.
                            command.Parameters.AddWithValue("@NewPassword", newPassword);
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@CurrentPassword", currentPassword);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Hiển thị thông báo thành công.
                                resultTextBlock.Text = "Đổi mật khẩu thành công!";
                                resultTextBlock.Foreground = System.Windows.Media.Brushes.Green;
                            }
                            else
                            {
                                // Hiển thị thông báo lỗi khi mật khẩu hiện tại không khớp hoặc không thể cập nhật.
                                resultTextBlock.Text = "Mật khẩu hiện tại không đúng hoặc không thể cập nhật mật khẩu mới!";
                                resultTextBlock.Foreground = System.Windows.Media.Brushes.Red;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi kết nối hoặc thực hiện truy vấn.
                    resultTextBlock.Text = $"Lỗi: {ex.Message}";
                    resultTextBlock.Foreground = System.Windows.Media.Brushes.Red;
                }
            }
            else
            {
                // Hiển thị thông báo lỗi khi mật khẩu mới và xác nhận mật khẩu mới không khớp.
                resultTextBlock.Text = "Mật khẩu mới và xác nhận mật khẩu mới không khớp!";
                resultTextBlock.Foreground = System.Windows.Media.Brushes.Red;
            }
        }
    }
}
