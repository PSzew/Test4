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
        }

        private void Login(object sender, EventArgs e)
        {

        }
    }
}
