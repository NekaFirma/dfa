﻿using Hospital_IS.View.PatientViewModels;
using System.Windows.Controls;

namespace Hospital_IS.View
{
    /// <summary>
    /// Interaction logic for DocumentationPatient.xaml
    /// </summary>
    public partial class TherapyPatientView : UserControl
    {

        private TherapyPatientViewModel therapyPatientViewModel;

        public TherapyPatientView()
        {
            //therapyPatientViewModel = new TherapyPatientViewModel();
            //this.DataContext = therapyPatientViewModel;
            InitializeComponent();
        }
    }
}
