namespace MultiplePagesNavigationDemo;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}

    private void btnPage1_Clicked(object sender, EventArgs e)
    {
          Navigation.PopToRootAsync();
    }

    private void btnPage2_Clicked(object sender, EventArgs e)
    {
          Navigation.PopAsync();
     }
}