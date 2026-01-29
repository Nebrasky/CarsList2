namespace CarLists
{
    public class AppSettings
    {
        public List<RepositorySettings> Repositories { get; set; } = new();
    }

    public class RepositorySettings
    {
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
    }
}
