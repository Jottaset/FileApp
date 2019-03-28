using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FileApp
{
    public partial class ConsomeContexto : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        public ConsomeContexto()
        {
            InitializeComponent();
            lbl_secundaria.Text = App.ValodDoContexto;
        }
    }
}
