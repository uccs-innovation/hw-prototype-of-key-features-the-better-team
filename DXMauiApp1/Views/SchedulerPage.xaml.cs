using DevExpress.Maui.Scheduler;
using DXMauiApp1.ViewModels;

namespace DXMauiApp1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SchedulerPage : ContentPage
    {
        public SchedulerPage()
        {
            InitializeComponent();
            BindingContext = ViewModel = new SchedulerViewModel();
        }

        SchedulerViewModel ViewModel { get; }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.OnAppearing();
        }

        private void WorkWeekView_Tap(object sender, SchedulerGestureEventArgs e)
        {
            if (e.AppointmentInfo == null)
            {
                ShowNewAppointmentEditPage(e.IntervalInfo);
                return;
            }
            AppointmentItem appointment = e.AppointmentInfo.Appointment;
            ShowAppointmentEditPage(appointment);
        }

        private void ShowAppointmentEditPage(AppointmentItem appointment)
        {
            AppointmentEditPage appEditPage = new AppointmentEditPage(appointment, this.storage);
            Navigation.PushAsync(appEditPage);
        }

        private void ShowNewAppointmentEditPage(IntervalInfo info)
        {
            AppointmentEditPage appEditPage = new AppointmentEditPage(info.Start, info.End,
                                                                     info.AllDay, this.storage);
            Navigation.PushAsync(appEditPage);
        }
    }
}