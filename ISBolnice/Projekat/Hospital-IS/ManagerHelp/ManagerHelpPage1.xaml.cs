using System.Windows;
using System.Windows.Controls;

namespace Hospital_IS.ManagerHelp
{
    /// <summary>
    /// Interaction logic for ManagerHelpPage1.xaml
    /// </summary>
    public partial class ManagerHelpPage1 : Page
    {
        public ManagerHelpPage1()
        {
            InitializeComponent();
            this.DataContext = HelpViewModel.Instance;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            HelpViewModel.Instance.NavService = this.NavigationService;
        }
    }
}
