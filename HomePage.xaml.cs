namespace PharC;

public partial class HomePage : TabbedPage
{
	public HomePage()
	{
        InitializeComponent();
        //*Nejla* Binding context
        BindingContext = new CombinedViewModel();
    }
}