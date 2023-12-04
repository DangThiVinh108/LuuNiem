using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private MyDb db = new MyDb();
        public Login()
        {
            InitializeComponent();
            txtUserName.Loaded += (s, e) => txtUserName.Focus();
            txtUserName.PreviewKeyDown += txtUserName_PreviewKeyDown;
            pbPassWord.PreviewKeyDown += pbPassWord_PreviewKeyDown;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string userName = txtUserName.Text;
            string password = pbPassWord.Password;
            string query = $"SELECT * FROM tblUsers WHERE UserName = '{userName}' AND Password = '{password}'";
            SqlDataReader sqlDataReader = db.GetDataReader(query);
            if (sqlDataReader.HasRows)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu chưa chính xác!");
            }
            sqlDataReader.Close();
        }

        private void chkShow_Checked(object sender, RoutedEventArgs e)
        {
            txtPasswordShow.Text = pbPassWord.Password;
            txtPasswordShow.Visibility = Visibility.Visible;
            pbPassWord.Visibility = Visibility.Hidden;
            
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void chkShow_Unchecked(object sender, RoutedEventArgs e)
        {
            txtPasswordShow.Visibility = Visibility.Hidden;
            pbPassWord.Visibility = Visibility.Visible;
            

        }

        private void txtPasswordShow_TextChanged(object sender, TextChangedEventArgs e)
        {
            pbPassWord.Password = txtPasswordShow.Text;
        }

        private void txtUserName_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                e.Handled = true;
                pbPassWord.Focus();
            }
        }

        private void pbPassWord_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                e.Handled = true;
                btnLogin_Click(sender, e);
            }
        }
    }
}
