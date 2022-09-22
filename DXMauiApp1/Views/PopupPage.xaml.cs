using DXMauiApp1.ViewModels;

namespace DXMauiApp1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupPage : ContentPage
    {
        public bool isStudying = false;
        public PopupPage()
        {
            InitializeComponent();
            BindingContext = new PopupViewModel();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            if (isStudying == false)
            {
                isStudying = true;
                StartStudy.IsOpen = true;
                Task.Delay(new TimeSpan(0, 0, 3)).ContinueWith(o => { Notify(); });
            }

            else
            {
                isStudying = false;
                StopStudy.IsOpen = true;
            }
        }

        void Notify()
        {
            StartStudy.IsOpen = false;
            NotifyPopup.IsOpen = true;
        }
    }
}