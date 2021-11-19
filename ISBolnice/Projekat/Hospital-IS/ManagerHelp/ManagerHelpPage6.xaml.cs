using System.Windows;
using System.Windows.Controls;

namespace Hospital_IS.ManagerHelp
{
    /// <summary>
    /// Interaction logic for ManagerHelpPage6.xaml
    /// </summary>
    public partial class ManagerHelpPage6 : Page
    {
        public ManagerHelpPage6()
        {
            InitializeComponent();
            this.DataContext = HelpViewModel.Instance;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);
            
            window.Close();
            MessageBox.Show("Sretno u nastavku rada sa aplikacijom");
        }
    }
}
