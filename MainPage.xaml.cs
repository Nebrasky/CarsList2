namespace CarLists
{
    public partial class MainPage : ContentPage
    {
        private readonly AppSettings appSettings;

        public MainPage(AppSettings appSettings)
        {
            this.appSettings = appSettings;
            InitializeComponent();
        }
    }
}
