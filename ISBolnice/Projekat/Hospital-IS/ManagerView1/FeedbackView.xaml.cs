using Hospital_IS.ManagerViewModel;
using System.Windows.Controls;

namespace Hospital_IS.ManagerView1
{
    public partial class FeedbackView : Page
    {
        public FeedbackView()
        {
            InitializeComponent();
            this.DataContext = FeedbackViewModel.Instance;
        }
    }
}
