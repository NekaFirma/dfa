using System.Windows;

namespace Hospital_IS.ManagerView1
{
    /// <summary>
    /// Interaction logic for HelpWindow.xaml
    /// </summary>
    public partial class HelpWindow : Window
    {
        public HelpWindow()
        {
            InitializeComponent();
        }

      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
