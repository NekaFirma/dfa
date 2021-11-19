using System.Windows.Controls;

namespace Hospital_IS.ManagerHelp
{
    /// <summary>
    /// Interaction logic for ManagerHelpPage2.xaml
    /// </summary>
    public partial class ManagerHelpPage2 : Page
    {
        public ManagerHelpPage2()
        {
            InitializeComponent();
            this.DataContext = HelpViewModel.Instance;
        }
    }
}
