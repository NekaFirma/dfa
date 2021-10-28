using System.Windows;

namespace Hospital_IS.ManagerHelp
{
    /// <summary>
    /// Interaction logic for RoomHelpWindow.xaml
    /// </summary>
    public partial class RoomHelpWindow : Window
    {
        public RoomHelpWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
