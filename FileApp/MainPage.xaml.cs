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

        List<string> stringList = new List<string>();

        void Handle_Clicked(object sender, System.EventArgs e)
        {

            //Arquivo.Text = lbl_inicial;

            string nome = Path.GetRandomFileName() + ".txt";
            string nomeArquivo = Path.Combine(App.PastaDiretorio,$"{nome}");

            string conteudoTexto = editor_valor.Text;

            //File.Create(nomearquivo);
            File.WriteAllText(nomeArquivo, conteudoTexto);

            lbl_inicial.Text = "Adicionando";

            stringList.Add(nomeArquivo);

            editor_valor.Text = string.Empty;

            //Navigation.PushAsync(new ConsomeContexto());
            //string nomeArquivo = Path.GetRandomFileName();
        }

        void breakString(object sender, System.EventArgs e)
        {
            string teste = editor_valor.Text;
            //var arrayConteudo = teste.Split('/');
            //lbl_inicial.Text = arrayConteudo[arrayConteudo.Count() - 1];

            int indice = teste.LastIndexOf('/');
            lbl_inicial.Text = teste.Substring(indice + 1);

        }

        void VerificarDados(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ConsomeContexto());
        }

        public MainPage()
        {
            InitializeComponent();
            lbl_inicial.Text = App.ValorDoContexto;
            //editor_valor.Text = App.PastaDiretorio;
            NavigationPage.SetHasBackButton(this, false);
        }
    }
}
