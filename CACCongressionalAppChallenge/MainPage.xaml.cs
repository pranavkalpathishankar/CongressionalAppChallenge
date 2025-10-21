namespace CACCongressionalAppChallenge;

public partial class MainPage : ContentPage
{
    public string AlabamaText => "Alabama Universities";
    public string AlaskaText => "Alaska Universities";
    public string ArizonaText => "Arizona Universities";
    public string ArkansasText => "Arkansas Universities";
    public string CaliforniaText => "California Universities";
    public string ColoradoText => "Colorado Universities";
    public string ConnecticutText => "Connecticut Universities";
    public string DelawareText => "Delaware Universities";
    public string FloridaText => "Florida Universities";
    public string GeorgiaText => "Georgia Universities";
    public string HawaiiText => "Hawaii Universities";
    public string IdahoText => "Idaho Universities";
    public string IllinoisText => "Illinois Universities";
    public string IndianaText => "Indiana Universities";
    public string IowaText => "Iowa Universities";
    public string KansasText => "Kansas Universities";
    public string KentuckyText => "Kentucky Universities";
    public string LouisianaText => "Louisiana Universities";
    public string MaineText => "Maine Universities";
    public string MarylandText => "Maryland Universities";
    public string MassachusettsText => "Massachusetts Universities";
    public string MichiganText => "Michigan Universities";
    public string MinnesotaText => "Minnesota Universities";
    public string MississippiText => "Mississippi Universities";
    public string MissouriText => "Missouri Universities";
    public string MontanaText => "Montana Universities";
    public string NebraskaText => "Nebraska Universities";
    public string NevadaText => "Nevada Universities";
    public string NewHampshireText => "New Hampshire Universities";
    public string NewJerseyText => "New Jersey Universities";
    public string NewMexicoText => "New Mexico Universities";
    public string NewYorkText => "New York Universities";
    public string NorthCarolinaText => "North Carolina Universities";
    public string NorthDakotaText => "North Dakota Universities";
    public string OhioText => "Ohio Universities";
    public string OklahomaText => "Oklahoma Universities";
    public string OregonText => "Oregon Universities";
    public string PennsylvaniaText => "Pennsylvania Universities";
    public string RhodeIslandText => "Rhode Island Universities";
    public string SouthCarolinaText => "South Carolina Universities";
    public string SouthDakotaText => "South Dakota Universities";
    public string TennesseeText => "Tennessee Universities";
    public string TexasText => "Texas Universities";
    public string UtahText => "Utah Universities";
    public string VermontText => "Vermont Universities";
    public string VirginiaText => "Virginia Universities";
    public string WashingtonText => "Washington Universities";
    public string WestVirginiaText => "West Virginia Universities";
    public string WisconsinText => "Wisconsin Universities";
    public string WyomingText => "Wyoming Universities";

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;

        // Wire up the Texas button click event
        TexasButton.Clicked += OnTexasButtonClicked;
    }

    private async void OnTexasButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TexasUniversitiesPage());
    }

    private void OnSearchButtonPressed(object sender, EventArgs e)
    {
        var searchBar = (SearchBar)sender;
        FilterStates(searchBar.Text);
    }

    private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
    {
        FilterStates(e.NewTextValue);
    }

    private void FilterStates(string searchText)
    {
        if (string.IsNullOrWhiteSpace(searchText))
        {
            ShowAllButtons();
        }
        else
        {
            searchText = searchText.ToLower();

            AlabamaButton.IsVisible = "alabama".Contains(searchText);
            AlaskaButton.IsVisible = "alaska".Contains(searchText);
            ArizonaButton.IsVisible = "arizona".Contains(searchText);
            ArkansasButton.IsVisible = "arkansas".Contains(searchText);
            CaliforniaButton.IsVisible = "california".Contains(searchText);
            ColoradoButton.IsVisible = "colorado".Contains(searchText);
            ConnecticutButton.IsVisible = "connecticut".Contains(searchText);
            DelawareButton.IsVisible = "delaware".Contains(searchText);
            FloridaButton.IsVisible = "florida".Contains(searchText);
            GeorgiaButton.IsVisible = "georgia".Contains(searchText);
            HawaiiButton.IsVisible = "hawaii".Contains(searchText);
            IdahoButton.IsVisible = "idaho".Contains(searchText);
            IllinoisButton.IsVisible = "illinois".Contains(searchText);
            IndianaButton.IsVisible = "indiana".Contains(searchText);
            IowaButton.IsVisible = "iowa".Contains(searchText);
            KansasButton.IsVisible = "kansas".Contains(searchText);
            KentuckyButton.IsVisible = "kentucky".Contains(searchText);
            LouisianaButton.IsVisible = "louisiana".Contains(searchText);
            MaineButton.IsVisible = "maine".Contains(searchText);
            MarylandButton.IsVisible = "maryland".Contains(searchText);
            MassachusettsButton.IsVisible = "massachusetts".Contains(searchText);
            MichiganButton.IsVisible = "michigan".Contains(searchText);
            MinnesotaButton.IsVisible = "minnesota".Contains(searchText);
            MississippiButton.IsVisible = "mississippi".Contains(searchText);
            MissouriButton.IsVisible = "missouri".Contains(searchText);
            MontanaButton.IsVisible = "montana".Contains(searchText);
            NebraskaButton.IsVisible = "nebraska".Contains(searchText);
            NevadaButton.IsVisible = "nevada".Contains(searchText);
            NewHampshireButton.IsVisible = "new hampshire".Contains(searchText);
            NewJerseyButton.IsVisible = "new jersey".Contains(searchText);
            NewMexicoButton.IsVisible = "new mexico".Contains(searchText);
            NewYorkButton.IsVisible = "new york".Contains(searchText);
            NorthCarolinaButton.IsVisible = "north carolina".Contains(searchText);
            NorthDakotaButton.IsVisible = "north dakota".Contains(searchText);
            OhioButton.IsVisible = "ohio".Contains(searchText);
            OklahomaButton.IsVisible = "oklahoma".Contains(searchText);
            OregonButton.IsVisible = "oregon".Contains(searchText);
            PennsylvaniaButton.IsVisible = "pennsylvania".Contains(searchText);
            RhodeIslandButton.IsVisible = "rhode island".Contains(searchText);
            SouthCarolinaButton.IsVisible = "south carolina".Contains(searchText);
            SouthDakotaButton.IsVisible = "south dakota".Contains(searchText);
            TennesseeButton.IsVisible = "tennessee".Contains(searchText);
            TexasButton.IsVisible = "texas".Contains(searchText);
            UtahButton.IsVisible = "utah".Contains(searchText);
            VermontButton.IsVisible = "vermont".Contains(searchText);
            VirginiaButton.IsVisible = "virginia".Contains(searchText);
            WashingtonButton.IsVisible = "washington".Contains(searchText);
            WestVirginiaButton.IsVisible = "west virginia".Contains(searchText);
            WisconsinButton.IsVisible = "wisconsin".Contains(searchText);
            WyomingButton.IsVisible = "wyoming".Contains(searchText);
        }
    }

    private void ShowAllButtons()
    {
        AlabamaButton.IsVisible = true;
        AlaskaButton.IsVisible = true;
        ArizonaButton.IsVisible = true;
        ArkansasButton.IsVisible = true;
        CaliforniaButton.IsVisible = true;
        ColoradoButton.IsVisible = true;
        ConnecticutButton.IsVisible = true;
        DelawareButton.IsVisible = true;
        FloridaButton.IsVisible = true;
        GeorgiaButton.IsVisible = true;
        HawaiiButton.IsVisible = true;
        IdahoButton.IsVisible = true;
        IllinoisButton.IsVisible = true;
        IndianaButton.IsVisible = true;
        IowaButton.IsVisible = true;
        KansasButton.IsVisible = true;
        KentuckyButton.IsVisible = true;
        LouisianaButton.IsVisible = true;
        MaineButton.IsVisible = true;
        MarylandButton.IsVisible = true;
        MassachusettsButton.IsVisible = true;
        MichiganButton.IsVisible = true;
        MinnesotaButton.IsVisible = true;
        MississippiButton.IsVisible = true;
        MissouriButton.IsVisible = true;
        MontanaButton.IsVisible = true;
        NebraskaButton.IsVisible = true;
        NevadaButton.IsVisible = true;
        NewHampshireButton.IsVisible = true;
        NewJerseyButton.IsVisible = true;
        NewMexicoButton.IsVisible = true;
        NewYorkButton.IsVisible = true;
        NorthCarolinaButton.IsVisible = true;
        NorthDakotaButton.IsVisible = true;
        OhioButton.IsVisible = true;
        OklahomaButton.IsVisible = true;
        OregonButton.IsVisible = true;
        PennsylvaniaButton.IsVisible = true;
        RhodeIslandButton.IsVisible = true;
        SouthCarolinaButton.IsVisible = true;
        SouthDakotaButton.IsVisible = true;
        TennesseeButton.IsVisible = true;
        TexasButton.IsVisible = true;
        UtahButton.IsVisible = true;
        VermontButton.IsVisible = true;
        VirginiaButton.IsVisible = true;
        WashingtonButton.IsVisible = true;
        WestVirginiaButton.IsVisible = true;
        WisconsinButton.IsVisible = true;
        WyomingButton.IsVisible = true;
    }
}