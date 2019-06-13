namespace Mimirium.API.Settings
{
    public class CompanyDatabaseSettings : ICompanyDatabaseSettings
    {
        public string CompanyCollectionName { get; set; }

        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }
    }
}
