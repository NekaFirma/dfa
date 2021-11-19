using Hospital_IS.View.PatientViewModels;
using System.Windows;

namespace Hospital_IS.View
{
    /// <summary>
    /// Interaction logic for FeedbackView.xaml
    /// </summary>
    public partial class FeedbackView : Window
    {
        public FeedbackViewModel FeedbackViewModel { get; set; }
        public FeedbackView()
        {
            FeedbackViewModel = new FeedbackViewModel();
            this.DataContext = FeedbackViewModel;
            InitializeComponent();
        }
    }
}
