using Hospital_IS.ManagerViewModel;
using System.Windows;

namespace Hospital_IS.ManagerView1
{
    /// <summary>
    /// Interaction logic for ReportRenovationWindow.xaml
    /// </summary>
    public partial class ReportRenovationWindow : Window
    {
        public ReportRenovationWindow()
        {
            InitializeComponent();
            this.DataContext = RenovationReportVIewModel.Instance;
        }

        private void SendReNotification_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
