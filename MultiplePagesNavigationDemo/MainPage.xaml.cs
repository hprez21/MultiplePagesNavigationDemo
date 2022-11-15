namespace MultiplePagesNavigationDemo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void btnPage2_Clicked(object sender, EventArgs e)
    {
		  Navigation.PushAsync(new Page2());
    }
}

