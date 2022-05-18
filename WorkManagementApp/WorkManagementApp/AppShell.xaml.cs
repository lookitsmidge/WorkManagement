using System;
using System.Collections.Generic;
using WorkManagementApp.ViewModels;
using WorkManagementApp.Views;
using Xamarin.Forms;

namespace WorkManagementApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
