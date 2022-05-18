using System.ComponentModel;
using WorkManagementApp.ViewModels;
using Xamarin.Forms;

namespace WorkManagementApp.Views
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