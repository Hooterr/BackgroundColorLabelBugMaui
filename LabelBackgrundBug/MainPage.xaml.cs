namespace LabelBackgrundBug;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	int i = -1;
    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		if (++i > 2)
		{
			i = 0;
		}
		if (i == 0)
		{
			Label.BackgroundColor = Colors.Red;
            Label.Text = "Red";
        }
        else if (i == 1)
		{
			Label.BackgroundColor = Colors.Green;
			Label.Text = "Green";
        }
        else
		{
            Label.BackgroundColor = Colors.Blue;
			Label.Text = "Blue";
        }
    }

}


