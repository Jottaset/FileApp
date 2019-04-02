using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace FileApp
{
    public partial class ConsomeContexto : ContentPage
    {
        ArrayList listadearquivos = new ArrayList();

        public ConsomeContexto()
        {
            InitializeComponent();

            NavigationPage.SetHasBackButton(this, false);
            //MinhaLista.ItemsSource = listaNova;
        }

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var valor = sender;
            //var eh = e;
            //await DisplayAlert("Deseja Deletar  Arquivo: ", e.SelectedItem.ToString(), " Ok");

            string DeleteName = Path.Combine(App.PastaDiretorio, $"{e.SelectedItem}");

            var resposta = await DisplayAlert("", "Deseja Deletar  Arquivo: ", "Sim", "Nao");

            // Segredi Estado
            // Quando vc cria o arquivo, vc passa o valor absoluto
            // Pra excluir eh a mesma coisa
            if (resposta == true)
            {
                File.Delete(DeleteName);

                await Navigation.PushAsync(new ConsomeContexto());

            }

        }


        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //Navigation.PopAsync();
            Navigation.PushAsync(new MainPage());
        }


        protected override void OnAppearing()
        {
            var meusArquivos = new List<Arquivo>();

            var arquivos = Directory.EnumerateFiles(App.PastaDiretorio, "*.txt");
            foreach (var nomedearquivos in arquivos)
            {
                //int indice = nomedearquivos.LastIndexOf('/');
                //listadearquivos.Add(nomedearquivos.Substring(indice + 1));

                meusArquivos.Add(new Arquivo { Conteudo = "Testando..." });
                
            }
            MinhaLista.ItemsSource = meusArquivos;

        }
    }
}