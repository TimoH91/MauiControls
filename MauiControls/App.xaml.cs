using MauiControls.Pages;

namespace MauiControls
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            NavigationPage navPage1 = new NavigationPage(new MauiPresentationControls());

            MainPage = new NavigationPage(new MauiCommandControls());
        }
    }
}
