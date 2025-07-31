using DevSport.MVVM.ViewModels;

namespace DevSport.MVVM.Views;

public partial class DevSportsViews : ContentPage
{
	public DevSportsViews()
	{
		InitializeComponent();
        BindingContext = new ViewModelDevSport();
    }
}