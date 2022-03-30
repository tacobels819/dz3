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
using Avtoriz;

namespace dz3.Pages
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string avtorizaciya = this.LoginTextBox.Text;
            string vvodparolia = this.PaswordTextBox.Text;
            bool cumback;

            Class1.avtoriz(avtorizaciya, vvodparolia, out cumback);
           
            if (cumback == true)
            {
                var h = Window.GetWindow(this) as MainWindow;
                h.Oleg.Navigate(new Pages.Page1());
            }


        }
    }
}
