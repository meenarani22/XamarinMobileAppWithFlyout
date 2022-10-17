using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyFlyoutPageFlyout : ContentPage
    {
        public ListView ListView;

        public MyFlyoutPageFlyout()
        {
            InitializeComponent();

            BindingContext = new MyFlyoutPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class MyFlyoutPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MyFlyoutPageFlyoutMenuItem> MenuItems { get; set; }

            public MyFlyoutPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<MyFlyoutPageFlyoutMenuItem>(new[]
                {
                    new MyFlyoutPageFlyoutMenuItem { Id = 0, Title = "Home",TargetType=typeof(Home),IconSource="home.png"},
                    new MyFlyoutPageFlyoutMenuItem { Id = 1, Title = "Main Page" ,TargetType=typeof(MainPage),IconSource="default1.png"},
                    new MyFlyoutPageFlyoutMenuItem { Id = 2, Title = "Register" ,TargetType=typeof(Register),IconSource="register.jpg"},
                    new MyFlyoutPageFlyoutMenuItem { Id = 3, Title = "Login" ,TargetType=typeof(login),IconSource="login.jpg" },
                    new MyFlyoutPageFlyoutMenuItem { Id = 4, Title = "Item View" ,TargetType=typeof(MobileApp.View.ItemView),IconSource="user.jpg"},
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}