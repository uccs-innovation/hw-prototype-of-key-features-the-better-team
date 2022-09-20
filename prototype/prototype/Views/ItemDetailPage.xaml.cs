using System.ComponentModel;
using prototype.ViewModels;
using Xamarin.Forms;

namespace prototype.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}