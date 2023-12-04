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
    /// Interaction logic for Souvenir.xaml
    /// </summary>
    public partial class Souvenir : Window
    {
        private MyDb db = new MyDb();

       

        public Souvenir()
        {
            InitializeComponent();
            DataTable dataTable = db.GetDataTable("Select * from tblSouvenir");

            dtgrSouvenir.ItemsSource = dataTable.DefaultView;

        }



        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

            if (!string.IsNullOrEmpty(txbSouvenirID.Text))
            {
                string sql = "Delete from tblSouvenir where SouvenirID =" + txbSouvenirID.Text;
                db.RunNonQuery(sql);
                DataTable dataTable = db.GetDataTable("Select * from tblSouvenir");
                dtgrSouvenir.ItemsSource = dataTable.DefaultView;
                MessageBox.Show("Hàng lưu niệm đã được xóa thành công.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

            }


        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            string souvenirID = txbSouvenirID.Text;
            string souvenirName = txtSouvenirName.Text;
            int Price = Convert.ToInt32(txtPrice.Text);
            string Description = txtDescription.Text;
            string sGroup = txtSGroup.Text;
            string sql = $"Update tblSouvenir set SouvenirName = N'{souvenirName}', Price = {Price}, Description = N'{Description}', SGroup = N'{sGroup}' where SouvenirID = '{souvenirID}'";
            db.RunNonQuery(sql);
            DataRowView selectedRow = dtgrSouvenir.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                selectedRow["SouvenirName"] = souvenirName;
                selectedRow["Price"]=Price;
                selectedRow["Description"]=Description;
                selectedRow["SGroup"]= sGroup;
            }    
            MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            
            if (btnNew.Content.ToString() == "Thêm")
            {
                
                txbSouvenirID.Clear();
                txtSouvenirName.Clear();
                txtPrice.Clear();
                txtDescription.Clear();
                txtSGroup.Clear();

                btnNew.Content = "Lưu";

            }
            else
            {
                string souvenirID = txbSouvenirID.Text;
                string souvenirName = txtSouvenirName.Text;
                if(string.IsNullOrEmpty(txtPrice.Text)) txtPrice.Text="0";
                int Price = Convert.ToInt32(txtPrice.Text);
                string Description = txtDescription.Text;
                string sGroup = txtSGroup.Text;
                //
                if (!string.IsNullOrEmpty(txtSouvenirName.Text))
                {
                    string sql = $"INSERT INTO tblSouvenir (SouvenirName, Price, Description, SGroup) VALUES (N'{souvenirName}', {Price}, N'{Description}', N'{sGroup}')";
                    db.RunNonQuery(sql);
                    DataTable dataTable = db.GetDataTable("Select * from tblSouvenir");
                 
                    dtgrSouvenir.ItemsSource= dataTable.DefaultView;
                    btnNew.Content = "Thêm";
                }
            }
        }

        private void txtPrice_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        
    }
}
