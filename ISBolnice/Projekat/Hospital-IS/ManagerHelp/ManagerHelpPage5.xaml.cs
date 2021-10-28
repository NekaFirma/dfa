using System.Windows.Controls;

namespace Hospital_IS.ManagerHelp
{
    /// <summary>
    /// Interaction logic for ManagerHelpPage5.xaml
    /// </summary>
    public partial class ManagerHelpPage5 : Page
    {
        public ManagerHelpPage5()
        {
            InitializeComponent();
            this.DataContext = HelpViewModel.Instance;
        }
    }
}
