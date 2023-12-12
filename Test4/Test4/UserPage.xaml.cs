using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test4.ClassModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPage : ContentPage
    {
        public UserPage(Account acc)
        {
            WebView.Source = acc.Class.Path;
        }

        private void LogOut(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
