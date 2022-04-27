using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace BattleShipXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogIn : ContentPage
    {

        public LogIn()
        {
            InitializeComponent();
        }

        enum EntryOption
        {
            Register = 0,
            Returning = 1,
            Cancel = 2
        }


         void ToggleEntryView(EntryOption option)
        {
            switch (option)
            {
                case EntryOption.Register:
                    {
                        lblWelcome.IsVisible = false;
                        layoutChoose.IsVisible = false;
                        layoutLogin.IsVisible = false;
                        layoutRegister.IsVisible = true;
                        break;
                    }
                case EntryOption.Returning:
                    {
                        lblWelcome.IsVisible = false;
                        layoutChoose.IsVisible = false;
                        layoutRegister.IsVisible = false;
                        layoutLogin.IsVisible = true;
                        break;
                    }
                case EntryOption.Cancel:
                    {
                        lblWelcome.IsVisible = true;
                        layoutChoose.IsVisible = true;
                        layoutRegister.IsVisible = false;
                        layoutLogin.IsVisible = false;
                        break;
                    }
            }
        }
        void OnbtnNewClicked(object sender, EventArgs args)
        {
            ToggleEntryView(EntryOption.Register);
        }
        void OnbtnReturnClicked(object sender, EventArgs args)
        {
            ToggleEntryView(EntryOption.Returning);
        }
        void OnbtnCancelLoginClicked(object sender, EventArgs args)
        {
            ToggleEntryView(EntryOption.Cancel);
        }
        void OnbtnCancelRegisterClicked(object sender, EventArgs args)
        {
            ToggleEntryView(EntryOption.Cancel);
        }

        void OnbtnRegisterClicked(object sender, EventArgs args)
        {
            if (string.IsNullOrEmpty(entryFirstName.Text) || string.IsNullOrEmpty(entryLastName.Text) || string.IsNullOrEmpty(entryEmail.Text))
                App.Current.MainPage.DisplayAlert("Error", "Please supply the required fields.", "Got it");
            
                
        }

        void OnbtnLoginClicked(object sender, EventArgs args)
        {
            if (string.IsNullOrEmpty(entryExistingEmail.Text))
                App.Current.MainPage.DisplayAlert("Error", "Please supply your email.", "Got it");
            else
            {
                btnLogin.IsEnabled = false;
              
            }
        }
    }
}  


   