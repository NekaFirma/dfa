using Hospital_IS.View.PatientViewModels;
using System.Windows.Controls;

namespace Hospital_IS.View
{
    /// <summary>
    /// Interaction logic for CalendarApponitmentView.xaml
    /// </summary>
    public partial class CalendarAppointmentView : UserControl
    {
        public CalendarAppointmentView()
        {
            InitializeComponent();
            this.DataContext = new CalendarAppointmentViewModel();
        }
    }
}
