using System.Windows;

namespace Hospital_IS.ManagerHelp
{
    /// <summary>
    /// Interaction logic for EquipmentHelpWindow.xaml
    /// </summary>
    public partial class EquipmentHelpWindow : Window
    {
        public EquipmentHelpWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
