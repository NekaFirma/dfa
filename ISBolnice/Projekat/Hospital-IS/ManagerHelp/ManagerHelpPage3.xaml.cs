using System.Windows.Controls;

namespace Hospital_IS.ManagerHelp
{
    /// <summary>
    /// Interaction logic for ManagerHelpPage3.xaml
    /// </summary>
    public partial class ManagerHelpPage3 : Page
    {
        public ManagerHelpPage3()
        {
            InitializeComponent();
            this.DataContext = HelpViewModel.Instance;
        }
    }
}
