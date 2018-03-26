using Xamarin.Forms;
using nullwines.Pages;
using nullwines.Data;

namespace nullwines
{
    public partial class App : Application
    {
        public static WineManager WineManager { get; private set; }

        public App()
        {
            InitializeComponent();

            WineManager = new WineManager(new RestService());
            MainPage = new MainPage();
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
