using Hospital_IS.ManagerViewModel;
using System.Windows;
using System.Windows.Controls;

namespace Hospital_IS.ManagerView1
{
    /// <summary>
    /// Interaction logic for BranchWorkerInsight.xaml
    /// </summary>
    public partial class BranchWorkerInsight : Page
    {
        public BranchWorkerInsight()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = new BranchViewModel(this.NavigationService);
        }
    }
}
