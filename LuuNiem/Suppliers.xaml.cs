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
    /// <summary>
    /// Interaction logic for Suppliers.xaml
    /// </summary>
    public partial class Suppliers : Window
    {
        private MyDb db= new MyDb();
        public Suppliers()
        {
            InitializeComponent();
            DataTable dataTable = db.GetDataTable("Select * from tblSuppliers");

            dtgrSupplier.ItemsSource = dataTable.DefaultView;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txbSupplierID.Text))
            {
                string sql = "Delete from tblSuppliers where SupplierID =" + txbSupplierID.Text;
                db.RunNonQuery(sql);
                DataTable dataTable = db.GetDataTable("Select * from tblSuppliers");
                dtgrSupplier.ItemsSource = dataTable.DefaultView;
                MessageBox.Show("Nhà cung cấp đã được xóa thành công.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            string SupplierID = txbSupplierID.Text;
            string CompanyName = txtCompanyName.Text;
            string ContactName = txtContactName.Text;
            string Address = txtAddress.Text;
            string Phone = txtPhone.Text;
            string Email = txtEmail.Text;
            string Description = txtDescription.Text;

            string sql = $"Update tblSuppliers set CompanyName = N'{CompanyName}',ContactName=N'{ContactName}', Address = N'{Address}', Phone = '{Phone}', Email = N'{Email}',Description = N'{Description}' where SupplierID = '{SupplierID}'";
            db.RunNonQuery(sql);
            DataRowView selectedRow = dtgrSupplier.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                selectedRow["CompanyName"] = CompanyName;
                selectedRow["ContactName"] = ContactName;
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

                txbSupplierID.Clear();
                txtCompanyName.Clear();
                txtCompanyName.Clear();
                txtContactName.Clear();
                txtAddress.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                txtDescription.Clear();

                btnNew.Content = "Lưu";

            }
            else
            {
                string SupplierID = txbSupplierID.Text;
                string CompanyName = txtCompanyName.Text;
                string ContactName = txtContactName.Text;
                string Address = txtAddress.Text;
                string Phone = txtPhone.Text;
                string Email = txtEmail.Text;
                string Description = txtDescription.Text;
                //
                if (!string.IsNullOrEmpty(txtCompanyName.Text))
                {
                    string sql = $"INSERT INTO tblSuppliers (CompanyName, ContactName,Address,Phone, Email, Description) VALUES (N'{CompanyName}',N'{ContactName}', N'{Address}','{Phone}',N'{Email}', N'{Description}')";
                    db.RunNonQuery(sql);
                    DataTable dataTable = db.GetDataTable("Select * from tblSuppliers");

                    dtgrSupplier.ItemsSource = dataTable.DefaultView;
                    btnNew.Content = "Thêm";
                }
            }
        }
    }
}
