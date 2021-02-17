using Xamarin.Forms;

namespace EfCoreBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            _label.Text = BugFactory.GetLongDebugView(false);
        }
    }
}
