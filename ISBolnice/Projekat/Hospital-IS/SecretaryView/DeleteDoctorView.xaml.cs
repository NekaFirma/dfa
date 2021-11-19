using ClinicCore.DTOs;
using Controllers;
using System.Windows;

namespace Hospital_IS.SecretaryView
{
    /// <summary>
    /// Interaction logic for DeleteDoctorView.xaml
    /// </summary>
    public partial class DeleteDoctorView : Window
    {
        public DoctorDTO Doctor { get; set; }
        public UpdateDoctorView ud;
        public DeleteDoctorView(DoctorDTO doctor, UpdateDoctorView ud)
        {
            InitializeComponent();
            this.Doctor = doctor;
            this.ud = ud;

            this.DataContext = this;
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            DoctorController.Instance.DeleteDoctor(Doctor);
            ud.udv.RefreshGrid();
            this.Close();
            ud.Close();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
