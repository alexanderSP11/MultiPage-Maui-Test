namespace MultiPageTestMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new TestMultiPage();
	}
}
