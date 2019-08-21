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
using System.Windows.Shapes;

namespace WpfTestCode
{
    /// <summary>
    /// Interaction logic for StartForm.xaml
    /// </summary>
    public partial class StartForm : Window
    {
        public StartForm()
        {
            InitializeComponent();
        }


        List<UserFormViewModel> usList = new List<UserFormViewModel>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            UserForm form = new UserForm();
            form.Owner = this;
            var result = form.ShowDialog();
            if (result == true)
            { 
                usList.Add(form.USERFORM);
                UserGrid.ItemsSource = null;
                UserGrid.ItemsSource = usList;
            }

            form.Close();
        }
    }
}
