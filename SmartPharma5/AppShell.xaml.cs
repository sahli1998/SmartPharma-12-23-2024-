﻿using Acr.UserDialogs;
using SmartPharma5.View;
using System.ComponentModel;

namespace SmartPharma5
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
            //Shell.Current.GoToAsync("//apsshell/LoginView");
        
        }
        private void RegisterRoutes()
        {
            // Enregistrez les routes de page comme vous l'avez fait précédemment.
            Routing.RegisterRoute(nameof(HomeView), typeof(HomeView));
            Routing.RegisterRoute(nameof(SammaryView), typeof(SammaryView));
            Routing.RegisterRoute(nameof(SalesModule), typeof(SalesModule));
            Routing.RegisterRoute(nameof(ProfilingModule), typeof(ProfilingModule));
            Routing.RegisterRoute(nameof(PaymentModule), typeof(PaymentModule));
            Routing.RegisterRoute(nameof(HrModule), typeof(HrModule));
            Routing.RegisterRoute(nameof(LoginView), typeof(LoginView));
            Routing.RegisterRoute(nameof(OpportunityView), typeof(OpportunityView));
        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading("Loaging");
            await Task.Delay(500);
            await App.Current.MainPage.Navigation.PushAsync(new LoginView());
            UserDialogs.Instance.HideLoading();


        }
    }
}