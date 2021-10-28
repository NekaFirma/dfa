using Hospital_IS.ManagerViewModel;
using System.Windows;
using System.Windows.Controls;

namespace Hospital_IS.ManagerView1
{
    /// <summary>
    /// Interaction logic for AdvancedRoomOptionsView.xaml
    /// </summary>
    public partial class AdvancedRoomOptionsView : Page
    {
        public AdvancedRoomOptionsView()
        {
            InitializeComponent();
            this.DataContext = AdvancedRoomRenovationViewModel.Instance;
        }

        private void Transfer_Click(object sender, RoutedEventArgs e)
        {
            if(RenovationStart.Text.Equals("") || RenovationEnd.Text.Equals(""))
            {
                MessageBox.Show("Unesite datum u validnom obliku");
            }
            else
            {
                AdvancedRoomRenovationViewModel.Instance.OpenWindow();
            }

        }
    }
}
