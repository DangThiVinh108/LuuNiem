using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LuuNiem
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window    
    {

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void mnuSouvenir_Click(object sender, RoutedEventArgs e)
        {
            Souvenir frmSouvenir = new Souvenir();
            frmSouvenir.ShowDialog();
        }

        private void mnuLogout_Click(object sender, RoutedEventArgs e)
        {
            PerformLogout();
        }
        private void PerformLogout()
        {

            this.Close();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void mnuCustomer_Click(object sender, RoutedEventArgs e)
        {
            Customers frmCustomer= new Customers();
            frmCustomer.ShowDialog();
        }


        private void mnuSupplier_Click(object sender, RoutedEventArgs e)
        {
            Suppliers frmSupplier = new Suppliers();
            frmSupplier.ShowDialog();
        }

        private void mnuChangePassword_Click(object sender, RoutedEventArgs e)
        {
            ChangePW frmChangePW = new ChangePW();
            frmChangePW.ShowDialog();
        }

    }
}
