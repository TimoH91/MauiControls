using MauiControls.Pages;

namespace MauiControls
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            NavigationPage navPage1 = new NavigationPage(new MauiPresentationControls());
            NavigationPage navPage2 = new NavigationPage(new MauiCommandControls());
            NavigationPage navPage3 = new NavigationPage(new MauiSetValueControls());
            NavigationPage navPage4 = new NavigationPage(new MauiEditControls());
            
            MainPage = new NavigationPage(new MauiCollectionControls());
        }
    }
}
