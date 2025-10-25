namespace CACCongressionalAppChallenge;
public partial class AlabamaUniversitiesPage : ContentPage
{
    public AlabamaUniversitiesPage()
    {
        InitializeComponent();
    }
    private async void OnUniversityClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var url = button.CommandParameter?.ToString();
        if (!string.IsNullOrEmpty(url))
        {
            try
            {
                await Launcher.OpenAsync(new Uri(url));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Unable to open link: {ex.Message}", "OK");
            }
        }
    }
    private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
    {
        var searchText = e.NewTextValue?.ToLower() ?? "";
        // Get the ScrollView and its content
        var scrollView = (ScrollView)this.FindByName("MainScrollView");
        if (scrollView?.Content is VerticalStackLayout stackLayout)
        {
            foreach (var child in stackLayout.Children)
            {
                if (child is Button button)
                {
                    if (string.IsNullOrWhiteSpace(searchText))
                    {
                        button.IsVisible = true;
                    }
                    else
                    {
                        button.IsVisible = button.Text.ToLower().Contains(searchText);
                    }
                }
            }
        }
    }
}