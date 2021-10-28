using Hospital_IS.ManagerViewModel;
using System.Windows;
using System.Windows.Controls;

namespace Hospital_IS.ManagerView1
{
    /// <summary>
    /// Interaction logic for EmployeerDetailsView.xaml
    /// </summary>
    public partial class EmployeerDetailsView : Page
    {
        public EmployeerDetailsView()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = new EmployeersViewModel(this.NavigationService);
        }
    }
}
