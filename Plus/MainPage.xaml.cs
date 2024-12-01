namespace Plus;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private async void ViewTwitter(object? sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://x.com/imadonsocial");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            await DisplayAlert("Unable to navigatie", "Due to unforeseen circumstances, a browser could not be opened to view the Twitter profile.", "OK");
        }
    }
}