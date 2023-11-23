using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Linq;
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
            int userID = Convert.ToInt32(txbUserID.Text);
            string FullName = txtFullName.Text;
            string UserName = txtUserName.Text;
            string Password = txtPassword.Text;
            string Phone = txtPhone.Text;
            string Email = txtEmail.Text;
            DatePicker Birthday = dpBirthday;
            string Address = txtAddress.Text;
            string Permissions = txtPermissions.Text;
            int Status = Convert.ToInt32(txtStatus.Text);
            string Description = txtDescription.Text;
            string sql = $"Update tblUsers set FullName = '{FullName}', UserName = {UserName},Password= '{Password}',Phone = '{Phone}',Email = '{Email}',Birthday = '{Birthday}',Address = '{Address}',Status = '{Status}', Permissions = '{Permissions}', Description = '{Description}' where UserID = '{userID}'";
            db.RunNonQuery(sql);
            DataRowView selectedRow = dtgrUser.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                selectedRow["FullName"] = FullName;
                selectedRow["UserName"] = UserName;
                selectedRow["Password"] = Password;
                selectedRow["Phone"] = Phone;
                selectedRow["Email"] = Email;
                selectedRow["Birthday"] = Birthday;
                selectedRow["Address"] = Address;
                selectedRow["Permissions"] = Permissions;
                selectedRow["Status"] = Status;
                selectedRow["Description"] = Description;
            }
            MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
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
                txtStatus.Clear();
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

                if (string.IsNullOrEmpty(txtStatus.Text)) txtStatus.Text = "0";
                int Status = Convert.ToInt32(txtStatus.Text);
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
