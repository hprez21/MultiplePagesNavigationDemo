namespace MultiplePagesNavigationDemo;

public partial class Page2 : ContentPage
{
     public Page2()
     {
          InitializeComponent();
     }

     private void btnPage3_Clicked(object sender, EventArgs e)
     {
          Navigation.PushAsync(new Page3());
     }

     private void btnPage1_Clicked(object sender, EventArgs e)
     {
          Navigation.PopAsync();
     }
}