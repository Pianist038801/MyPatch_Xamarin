using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyPatch
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            Label lbl = this.FindByName<Label>("txtUID");
            lbl.Text = DependencyService.Get<IDevInfo>().getID();
            //lbl.Text = "asfl;askjdf;sajdlfkjasldfkja;lskjfl;a1234152351235gygkjhgjkhgkjhgkjhgkjh";
        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            await DisplayAlert("Login Clicked", "check", "OK");
        }

    }
}
