using System.Windows;

namespace Hospital_IS.ManagerHelp
{
    /// <summary>
    /// Interaction logic for MedicineHelpWindow.xaml
    /// </summary>
    public partial class MedicineHelpWindow : Window
    {
        public MedicineHelpWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
