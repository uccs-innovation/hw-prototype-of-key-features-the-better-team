using System;
using System.Collections.Generic;
using System.ComponentModel;
using prototype.Models;
using prototype.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prototype.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}