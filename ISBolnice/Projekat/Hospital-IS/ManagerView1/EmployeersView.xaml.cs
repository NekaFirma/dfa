using Hospital_IS.ManagerViewModel;
using System.Windows;
using System.Windows.Controls;

namespace Hospital_IS.ManagerView1
{
    /// <summary>
    /// Interaction logic for EmployeersView.xaml
    /// </summary>
    public partial class EmployeersView : Page
    {
        public EmployeersView()
        {
            InitializeComponent();
        }

        private void OtherOptionsButton_Click(object sender, RoutedEventArgs e)
        {
            if (OtherOptions.Visibility == Visibility.Visible)
            {
                OtherOptions.Visibility = Visibility.Hidden;
            }
            else
            {
                OtherOptions.Visibility = Visibility.Visible;
            }
        }

        private void EmployeeOptions_Click(object sender, RoutedEventArgs e)
        {
            if (EmpoloyeerOptions.Visibility == Visibility.Collapsed)
            {
                EmpoloyeerOptions.Visibility = Visibility.Visible;
            }
            else
            {
                EmpoloyeerOptions.Visibility = Visibility.Collapsed;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = new EmployeersViewModel(this.NavigationService);
        }
    }
}
