using PlutoFramework.Model;
using PlutoFramework.Templates.PageTemplate;

namespace AppTemplate.Pages;

public partial class SettingsPage : PageTemplate
{
	public SettingsPage()
	{
		InitializeComponent();

		//BindingContext = new SettingsPageViewModel();
    }

    private void UseRostasAddress(object sender, TappedEventArgs e)
    {
        Preferences.Set(PreferencesModel.PUBLIC_KEY, "5EU6EyEq6RhqYed1gCYyQRVttdy6FC9yAtUUGzPe3gfpFX8y");
    }
}