using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoniHealth.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MoniHealth.View;
using System.Text.RegularExpressions;

namespace MoniHealth.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        void LoginProcedure(object sender, EventArgs e)
        {
            User user = new User(emailEntry.Text, passwordEntry.Text);
            var email = emailEntry.Text;
            var emailPattern = (@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (user.checkInformation() && Regex.IsMatch(email, emailPattern))
            {
                DisplayAlert("Login", "Successful Login", "OK");
            }
            else
            {
                DisplayAlert("Login", "Login Unsuccessful, empty/invalid email or password", "OK");
            }
        }
        async void CreateAcctProcedure(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountCreationPage());
        }
    }
}