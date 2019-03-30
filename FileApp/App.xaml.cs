using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FileApp
{
    public partial class App : Application
    {
        public static string ValorDoContexto { get; set; }

        public static string PastaDiretorio { get; set; }

        public App()
        {
            InitializeComponent();

            ValorDoContexto = "Nosso Valor";
            PastaDiretorio = Path.Combine(Environment.GetFolderPath
            (Environment.SpecialFolder.LocalApplicationData));

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
