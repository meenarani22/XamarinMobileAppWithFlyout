using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileApp.ViewModel
{
    public class itemVM:INotifyPropertyChanged
    {
        public ICommand submitCommand => new Command(submit);

        private void submit()
        {
            Message = "itme name " + this.ItemName + " and value is: " + this.ItemValue;
        }

        public string ItemName { get; set; }
        public string ItemValue { get; set; }
        public string _message { get; set; }
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                onPropertyChanged();
            }
        }

        
        //private event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        void onPropertyChanged([CallerMemberName] string propertyname = "")
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }


    }
}
