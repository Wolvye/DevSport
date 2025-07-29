using DevSport.MVVM.ViewModels;
using DevSport.MVVM.Views;

namespace DevSport
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new DevSportsViews());
        }

    }
}