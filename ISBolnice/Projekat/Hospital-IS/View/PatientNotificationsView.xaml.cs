using Hospital_IS.View.PatientViewModels;
using System.Windows.Controls;

namespace Hospital_IS.View
{
    /// <summary>
    /// Interaction logic for PatientNotifications.xaml
    /// </summary>
    public partial class PatientNotificationsView : UserControl
    {
        private PatientNotificationsViewModel patientNotificationsViewModel;
        public PatientNotificationsView()
        {
            patientNotificationsViewModel = new PatientNotificationsViewModel();
            this.DataContext = patientNotificationsViewModel;
            InitializeComponent();
        }
    }
}
