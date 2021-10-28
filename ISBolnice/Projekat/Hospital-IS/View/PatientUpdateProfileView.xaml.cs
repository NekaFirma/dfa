using Hospital_IS.View.PatientViewModels;
using System.Windows.Controls;

namespace Hospital_IS.View
{
    /// <summary>
    /// Interaction logic for PatientUpdateProfileView.xaml
    /// </summary>
    public partial class PatientUpdateProfileView : UserControl
    {
        public PatientUpdateProfileView()
        {
            this.DataContext = new PatientUpdateProfileViewModel();
            InitializeComponent();
        }
    }
}
