namespace Mimirium.API.Settings
{
    public interface ICompanyDatabaseSettings
    {
        string CompanyCollectionName { get; set; }

        string ConnectionString { get; set; }

        string DatabaseName { get; set; }
    }
}
