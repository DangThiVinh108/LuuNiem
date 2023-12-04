using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LuuNiem
{
    public partial class Customers : Window
    {
        private MyDb db = new MyDb();

        public Customers()
        {

            InitializeComponent();
            DataTable dataTable = db.GetDataTable("Select * from tblCustomers");

            dtgrCustomer.ItemsSource = dataTable.DefaultView;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txbCustomerID.Text))
            {
                string sql = "Delete from tblCustomers where CustomerID =" + txbCustomerID.Text;
                db.RunNonQuery(sql);
                DataTable dataTable = db.GetDataTable("Select * from tblCustomers");
                dtgrCustomer.ItemsSource = dataTable.DefaultView;
                MessageBox.Show("Khách hàng đã được xóa thành công.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            string CustomerID = txbCustomerID.Text;
            string FullName = txtFullName.Text;
            string Address = txtAddress.Text;
            string Phone = txtPhone.Text;
            string Email = txtEmail.Text;
            string Description = txtDescription.Text;

            string sql = $"Update tblCustomers set FullName = N'{FullName}', Address = N'{Address}', Phone = '{Phone}', Email = N'{Email}',Description = N'{Description}' where CustomerID = '{CustomerID}'";
            db.RunNonQuery(sql);
            DataRowView selectedRow = dtgrCustomer.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                selectedRow["FullName"] = FullName;
                selectedRow["Address"] = Address;
                selectedRow["Phone"] = Phone;
                selectedRow["Email"] = Email;
                selectedRow["Description"] = Description;
            }
            MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            if (btnNew.Content.ToString() == "Thêm")
            {

                txbCustomerID.Clear();
                txtFullName.Clear();
                txtAddress.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                txtDescription.Clear();

                btnNew.Content = "Lưu";

            }
            else
            {
                string CustomerID = txbCustomerID.Text;
                string FullName = txtFullName.Text;
                string Address = txtAddress.Text;
                string Phone = txtPhone.Text;
                string Email = txtEmail.Text;
                string Description = txtDescription.Text;
                //
                if (!string.IsNullOrEmpty(txtFullName.Text))
                {
                    string sql = $"INSERT INTO tblCustomers (FullName, Address,Phone, Email, Description) VALUES (N'{FullName}', N'{Address}','{Phone}',N'{Email}', N'{Description}')";
                    db.RunNonQuery(sql);
                    DataTable dataTable = db.GetDataTable("Select * from tblCustomers");

                    dtgrCustomer.ItemsSource = dataTable.DefaultView;
                    btnNew.Content = "Thêm";
                }
            }
        }
    }
}
