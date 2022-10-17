using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public ICommand Commandbutton => new Command(Command_click);
        public login()
        {
            InitializeComponent();
            imglogo.Source = ImageSource.FromFile("xamagon.png");   //we can pass image using this method also
            BindingContext = this;
        }
        public void Command_click()
        {
            if (txtusername.Text == "admin" && txtpassword.Text == "123")
            {
                Navigation.PushAsync(new Home());
            }
            else
            {
                DisplayAlert("ops..!", "Username and Password are incorrect.", "Ok");
            }
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if(txtusername.Text=="admin" && txtpassword.Text == "123")
            {
                Navigation.PushAsync(new Home());
            }
            else
            {
                DisplayAlert("ops..!", "Username and Password are incorrect.", "Ok");
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register());
        }
    }
}