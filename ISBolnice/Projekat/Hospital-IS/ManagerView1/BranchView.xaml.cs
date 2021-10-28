using Hospital_IS.ManagerViewModel;
using System.Windows;
using System.Windows.Controls;

namespace Hospital_IS.ManagerView1
{
    /// <summary>
    /// Interaction logic for BranchView.xaml
    /// </summary>
    public partial class BranchView : Page
    {
        public BranchView()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = new BranchViewModel(this.NavigationService);
        }

        private void OtherOptionsButton_Click(object sender, RoutedEventArgs e)
        {

            BranchOptions.Visibility = Visibility.Collapsed;

            if (OtherOptions.Visibility == Visibility.Collapsed)
            {
                OtherOptions.Visibility = Visibility.Visible;
            }
            else
            {
                OtherOptions.Visibility = Visibility.Collapsed;
            }
        }

        private void BranchOptions_Click(object sender, RoutedEventArgs e)
        {
            OtherOptions.Visibility = Visibility.Collapsed;
            if (BranchOptions.Visibility == Visibility.Collapsed)
            {
                BranchOptions.Visibility = Visibility.Visible;
            }
            else
            {
                BranchOptions.Visibility = Visibility.Collapsed;
            }

        }
    }
}
