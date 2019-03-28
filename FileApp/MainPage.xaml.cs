using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FileApp
{
    public partial class MainPage : ContentPage
    {
        //string valorDesteContexto = "Olah";

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //Navigation.PushAsync(new ConsomeContexto());
            string nomeArquivo = Path.GetRandomFileName();
            lbl_inicial.Text = nomeArquivo + ".txt";
        }

        public MainPage()
        {
            InitializeComponent();
            lbl_inicial.Text = App.ValodDoContexto;
            editor_valor.Text = App.PastaDiretorio;
        }
    }
}
