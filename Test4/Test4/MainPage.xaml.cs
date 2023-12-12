using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test4.ClassModel;
using Xamarin.Forms;

namespace Test4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GlobalClass.accounts.Add(new Account("4TP", "123", new UserClass("4TP", @"https://zstio.edu.pl/plan/u/podzgodz/plan.php?kl=123F69DA832927A6")));
            GlobalClass.accounts.Add(new Account("3TP", "321", new UserClass("3TP", @"https://zstio.edu.pl/plan/u/podzgodz/plan.php?kl=7C176FB779BD7149")));
            GlobalClass.accounts.Add(new Account("2TP", "asd", new UserClass("2TP", @"https://zstio.edu.pl/plan/u/podzgodz/plan.php?kl=3A4D87253A6AAA3F")));
        }

        private void Login(object sender, EventArgs e)
        {
            foreach(var account in GlobalClass.accounts) 
            {
                if(LoginTxT.Text == account.Login && Password.Text == account.Password)
                {
                    Navigation.PushAsync(new UserPage(account));
                }
            }
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoginTxT.Text = string.Empty;
            Password.Text = string.Empty;
        }
    }
}
