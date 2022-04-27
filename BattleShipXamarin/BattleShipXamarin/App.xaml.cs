using BattleShipXamarin.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BattleShipXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LogIn();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
