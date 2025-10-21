namespace CACCongressionalAppChallenge;

public partial class TexasUniversitiesPage : ContentPage
{
    public TexasUniversitiesPage()
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

        if (string.IsNullOrWhiteSpace(searchText))
        {
            ShowAllButtons();
        }
        else
        {
            UTAustinButton.IsVisible = "university of texas at austin".Contains(searchText) || "ut austin".Contains(searchText);
            TexasAMButton.IsVisible = "texas a&m".Contains(searchText) || "tamu".Contains(searchText);
            UTDallasButton.IsVisible = "university of texas at dallas".Contains(searchText) || "ut dallas".Contains(searchText);
            UHoustonButton.IsVisible = "university of houston".Contains(searchText) || "uh".Contains(searchText);
            TexasTechButton.IsVisible = "texas tech".Contains(searchText);
            UTArlingtonButton.IsVisible = "university of texas at arlington".Contains(searchText) || "ut arlington".Contains(searchText);
            UTSanAntonioButton.IsVisible = "university of texas at san antonio".Contains(searchText) || "utsa".Contains(searchText);
            UTElPasoButton.IsVisible = "university of texas at el paso".Contains(searchText) || "utep".Contains(searchText);
            TexasStateButton.IsVisible = "texas state".Contains(searchText);
            UNorthTexasButton.IsVisible = "university of north texas".Contains(searchText) || "unt".Contains(searchText);
            TexasWomanButton.IsVisible = "texas woman".Contains(searchText) || "twu".Contains(searchText);
            SamHoustonButton.IsVisible = "sam houston".Contains(searchText);
            StephenFAustinButton.IsVisible = "stephen f austin".Contains(searchText) || "sfa".Contains(searchText);
            TarletonButton.IsVisible = "tarleton".Contains(searchText);
            PrairieViewButton.IsVisible = "prairie view".Contains(searchText);
            TexasSouthernButton.IsVisible = "texas southern".Contains(searchText);
            RiceButton.IsVisible = "rice".Contains(searchText);
            SMUButton.IsVisible = "southern methodist".Contains(searchText) || "smu".Contains(searchText);
            TCUButton.IsVisible = "texas christian".Contains(searchText) || "tcu".Contains(searchText);
            BaylorButton.IsVisible = "baylor".Contains(searchText);
            TrinityButton.IsVisible = "trinity".Contains(searchText);
        }
    }

    private void ShowAllButtons()
    {
        UTAustinButton.IsVisible = true;
        TexasAMButton.IsVisible = true;
        UTDallasButton.IsVisible = true;
        UHoustonButton.IsVisible = true;
        TexasTechButton.IsVisible = true;
        UTArlingtonButton.IsVisible = true;
        UTSanAntonioButton.IsVisible = true;
        UTElPasoButton.IsVisible = true;
        TexasStateButton.IsVisible = true;
        UNorthTexasButton.IsVisible = true;
        TexasWomanButton.IsVisible = true;
        SamHoustonButton.IsVisible = true;
        StephenFAustinButton.IsVisible = true;
        TarletonButton.IsVisible = true;
        PrairieViewButton.IsVisible = true;
        TexasSouthernButton.IsVisible = true;
        RiceButton.IsVisible = true;
        SMUButton.IsVisible = true;
        TCUButton.IsVisible = true;
        BaylorButton.IsVisible = true;
        TrinityButton.IsVisible = true;
    }
}