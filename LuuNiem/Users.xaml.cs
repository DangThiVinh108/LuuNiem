using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Converters;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xaml;

namespace LuuNiem
{
    /// <summary>
    /// Interaction logic for Users.xaml
    /// </summary>
    public partial class Users : Window

    {
        private MyDb db = new MyDb();
        public Users()
        {
            InitializeComponent();
            DataTable dataTable = db.GetDataTable("Select * from tblUsers");

            dtgrUser.ItemsSource = dataTable.DefaultView;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txbUserID.Text))
            {
                string sql = "Delete from tblUsers where UserID =" + txbUserID.Text;
                db.RunNonQuery(sql);
                DataTable dataTable = db.GetDataTable("Select * from tblUsers");
                dtgrUser.ItemsSource = dataTable.DefaultView;
                MessageBox.Show("Nhân viên đã được xóa thành công.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int userID = Convert.ToInt32(txbUserID.Text);
                string FullName = txtFullName.Text;
                string UserName = txtUserName.Text;
                string Password = txtPassword.Text; // Note: Consider using a secure password hashing algorithm
                string Phone = txtPhone.Text;
                string Email = txtEmail.Text;
                DateTime Birthday = dpBirthday.SelectedDate ?? DateTime.MinValue; // Use selected date or a default value
                string Address = txtAddress.Text;
                string Permissions = txtPermissions.Text;
                int Status = (cbStatus.IsChecked == true) ? 1 : 0;
                string Description = txtDescription.Text;

                // Using parameterized query to prevent SQL injection
                string sql = "UPDATE tblUsers SET FullName = @FullName, UserName = @UserName, Password = @Password, Phone = @Phone, " +
                             "Email = @Email, Birthday = @Birthday, Address = @Address, Status = @Status, " +
                             "Permissions = @Permissions, Description = @Description WHERE UserID = @UserID";

                using (SqlConnection connection = new SqlConnection("your_connection_string_here"))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@FullName", FullName);
                        cmd.Parameters.AddWithValue("@UserName", UserName);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.Parameters.AddWithValue("@Phone", Phone);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@Birthday", Birthday);
                        cmd.Parameters.AddWithValue("@Address", Address);
                        cmd.Parameters.AddWithValue("@Status", Status);
                        cmd.Parameters.AddWithValue("@Permissions", Permissions);
                        cmd.Parameters.AddWithValue("@Description", Description);
                        cmd.Parameters.AddWithValue("@UserID", userID);

                        // Execute the query
                        cmd.ExecuteNonQuery();
                    }
                }

                // Update the DataRowView in the DataGrid
                DataRowView selectedRow = dtgrUser.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    selectedRow["FullName"] = FullName;
                    selectedRow["UserName"] = UserName;
                    // Update other fields as needed...
                }

                MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            if (btnNew.Content.ToString() == "Thêm")
            {

                txbUserID.Clear();
                txtFullName.Clear();
                txtUserName.Clear();
                txtPassword.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                dpBirthday.SelectedDate = null;
                txtAddress.Clear();
                txtPermissions.Clear();
                cbStatus.IsChecked = false;
                txtDescription.Clear();
                

                btnNew.Content = "Lưu";

            }
            else
            {
                string UserID = txbUserID.Text;
                string FullName = txtFullName.Text;
                string UserName = txtFullName.Text;
                string Password = txtFullName.Text;
                string Phone = txtFullName.Text;
                string Email = txtFullName.Text;
                string Birthday = txtFullName.Text;
                string Address = txtFullName.Text;
                int Status = (cbStatus.IsChecked == true) ? 1 : 0;
                string Description = txtDescription.Text;
                //
                if (!string.IsNullOrEmpty(txtFullName.Text))
                {
                    string sql = $"INSERT INTO tblUsers (FullName, UserName,Password,Phone,Email,Birthday,Address,Status, Description) VALUES ('{FullName}','{UserName}','{Password}','{Phone}','{Email}','{Birthday}','{Address}', {Status}, '{Description}')";
                    db.RunNonQuery(sql);
                    DataTable dataTable = db.GetDataTable("Select * from tblUsers");

                    dtgrUser.ItemsSource = dataTable.DefaultView;
                    btnNew.Content = "Thêm";
                }
            }
        }
    }
}
