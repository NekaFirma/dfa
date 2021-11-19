using System.Windows.Controls;

namespace Hospital_IS.ManagerHelp
{
    /// <summary>
    /// Interaction logic for ManagerHelpPage4.xaml
    /// </summary>
    public partial class ManagerHelpPage4 : Page
    {
        public ManagerHelpPage4()
        {
            InitializeComponent();
            this.DataContext = HelpViewModel.Instance;
        }
    }
}
