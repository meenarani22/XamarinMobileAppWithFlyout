using MobileApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemView : ContentPage
    {
        public ItemView()
        {
            InitializeComponent();
        }
        #region For button click loosly coupled 
        //private void button_click(object sender,EventArgs args)
        //{
        //    var itedata = (itemVM)BindingContext;
        //    var msg = "Item name:" + itedata.ItemName + " item value id:" + itedata.ItemValue;

        //}
        #endregion
    }
}