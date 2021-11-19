using Hospital_IS.ManagerViewModel;
using System.Windows;
using System.Windows.Controls;

namespace Hospital_IS.ManagerView1
{
    /// <summary>
    /// Interaction logic for EmployyerInsight.xaml
    /// </summary>
    public partial class EmployyerInsight : Page
    {
        public EmployyerInsight()
        {
            InitializeComponent();
           
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = new EmployeersViewModel(this.NavigationService);
        }
    }
}
